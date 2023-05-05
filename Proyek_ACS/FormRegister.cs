using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace Proyek_ACS
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTglLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textConPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        String Nama;
        String Password ;
        String con ;
        OracleCommand cmd;
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Nama = textNama.Text;
            Password = textPassword.Text;
            con = textConPass.Text;

            int idx = comboBox1.SelectedIndex;

            if (Nama != "")
            {
                if (Password != "")
                {
                    if (con != "")
                    {
                        if (Password == con)
                        {

                            try
                            {
                                if (idx == 0)
                                {
                                    cmd = new OracleCommand();

                                    cmd.Connection = conn;
                                    cmd.CommandText = "INSERT INTO karyawan(id_karyawan, username_karyawan, password_karyawan, nama_karyawan, notel_karyawan, fk_jabatan) VALUES (generateID('" + textNama.Text + "'),'" + textUser.Text + "','" + textPassword.Text + "','" + textNama.Text + "'," + textnotelp.Text + ",1)";
                                    if (conn.State == ConnectionState.Open)
                                    {
                                        conn.Close();
                                    }

                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Berhasil");


                                    loaddata();
                                }
                                else if (idx == 1)
                                {
                                    cmd = new OracleCommand();

                                    cmd.Connection = conn;
                                    cmd.CommandText = "INSERT INTO karyawan(id_karyawan, username_karyawan, password_karyawan, nama_karyawan, notel_karyawan, fk_jabatan) VALUES (generateID('" + textNama.Text + "'),'" + textUser.Text + "','" + textPassword.Text + "','" + textNama.Text + "'," + textnotelp.Text + ",2)";
                                    if (conn.State == ConnectionState.Open)
                                    {
                                        conn.Close();
                                    }

                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Berhasil");


                                    loaddata();
                                }
                                else if (idx == 2)
                                {
                                    cmd = new OracleCommand();

                                    cmd.Connection = conn;
                                    cmd.CommandText = "INSERT INTO karyawan(id_karyawan, username_karyawan, password_karyawan, nama_karyawan, notel_karyawan, fk_jabatan) VALUES (generateID('" + textNama.Text + "'),'" + textUser.Text + "','" + textPassword.Text + "','" + textNama.Text + "'," + textnotelp.Text + ",3)";
                                    if (conn.State == ConnectionState.Open)
                                    {
                                        conn.Close();
                                    }

                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Berhasil");


                                    loaddata();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confirm Password dan Password tidak sama!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confirm Password harus diisi!!");
                    }
                }
                else
                {
                    MessageBox.Show("Password harus diisi!!");
                }
            }
            else
            {
                MessageBox.Show("Nama harus diisi!!");
            }
        }
        OracleConnection conn=Login.conn;

        OracleCommand storedProcedure;
        OracleParameter pkode;
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                storedProcedure = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "generateID"
                };

                pkode = new OracleParameter();
                pkode.OracleDbType = OracleDbType.Varchar2;
                pkode.Size = 10000;
                pkode.Direction = ParameterDirection.ReturnValue;
                storedProcedure.Parameters.Add(pkode);

                storedProcedure.Parameters.Add(new OracleParameter("pnama", OracleDbType.Varchar2, 100, textNama.Text, ParameterDirection.Input));

                storedProcedure.ExecuteNonQuery();

                //TbKd.Text = pkode.Value.ToString();
                MessageBox.Show(pkode.Value.ToString());



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            btnBack.Text = "";
            buttonRegister.Text = "";
            buttonUpdate.Text = "";
            buttonDelete.Text = "";
            button1.Text = "";
            button2.Text = "";

            btnBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HeaderRegister.png");
            buttonRegister.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Register.png");
            buttonUpdate.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Update.png");
            buttonDelete.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Delete.png");
            button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\ShowPass.png");
            button2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\ShowPass.png");

            loaddata();

        }

        private void loaddata()
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id_karyawan as \"ID Karyawan\",username_karyawan AS \"Username\", nama_karyawan AS \"Nama Karyawan\",notel_karyawan AS \"No Telepon\",  password_karyawan as \"mm\", Fk_Jabatan FROM karyawan";


            conn.Close();
            conn.Open();

            cmd.ExecuteReader();
            da.SelectCommand = cmd;
            da.Fill(dt);
            DgvSales.DataSource = dt;
            DgvSales.Columns[4].Visible = false;
            DgvSales.Columns[5].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin frmadmin = new FormAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Nama = textNama.Text;
            Password = textPassword.Text;
            con = textConPass.Text;

            if (Nama != "")
            {
                if (Password != "")
                {
                    if (con != "")
                    {
                        if (Password == con)
                        {

                            try
                            {
                                cmd = new OracleCommand();

                                cmd.Connection = conn;
                                cmd.CommandText = "update karyawan set username_karyawan ='"+textUser.Text+"', password_karyawan ='"+textPassword.Text+"',nama_karyawan ='"+textNama.Text+"',notel_karyawan='"+textnotelp.Text+"' where id_karyawan='"+DgvSales.Rows[SI].Cells[0].Value.ToString()+"'";
                                if (conn.State == ConnectionState.Open)
                                {
                                    conn.Close();
                                }

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Berhasil");


                                loaddata();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confirm Password dan Password tidak sama!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confirm Password harus diisi!!");
                    }
                }
                else
                {
                    MessageBox.Show("Password harus diisi!!");
                }
            }
            else
            {
                MessageBox.Show("Nama harus diisi!!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OracleCommand();

                cmd.Connection = conn;
                cmd.CommandText = "update karyawan set FK_JABATAN=0 where id_karyawan='"+DgvSales.Rows[SI].Cells[0].Value.ToString()+"'";

                                if (conn.State == ConnectionState.Open)
                                {
                                    conn.Close();
                                }

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Berhasil");


                loaddata();
;                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
        }
        int SI;
        private void DgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                SI = e.RowIndex;
                textUser.Text = DgvSales.Rows[e.RowIndex].Cells[1].Value.ToString();
                textNama.Text = DgvSales.Rows[e.RowIndex].Cells[2].Value.ToString();
                textnotelp.Text = DgvSales.Rows[e.RowIndex].Cells[3].Value.ToString();
                textPassword.Text= DgvSales.Rows[e.RowIndex].Cells[4].Value.ToString();
                textConPass.Text= DgvSales.Rows[e.RowIndex].Cells[4].Value.ToString();
                int jabatan = Convert.ToInt32(DgvSales.Rows[e.RowIndex].Cells[5].Value);
                if (jabatan == 1)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else if (jabatan == 2)
                {
                    comboBox1.SelectedIndex = 1;
                }
                else if (jabatan == 3)
                {
                    comboBox1.SelectedIndex = 2;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textPassword.UseSystemPasswordChar == false)
            {
                textPassword.UseSystemPasswordChar = true;
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\ShowPass.png");
            }
            else
            {
                textPassword.UseSystemPasswordChar = false;
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HidePass.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textConPass.UseSystemPasswordChar == false)
            {
                textConPass.UseSystemPasswordChar = true;
                button2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\ShowPass.png");
            }
            else
            {
                textConPass.UseSystemPasswordChar = false;
                button2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HidePass.png");
            }
        }
    }
}
