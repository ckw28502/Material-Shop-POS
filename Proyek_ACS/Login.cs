using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_ACS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            connectDB();
        }
        String connStr;
        public static OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader reader;
        String queryStr;
        string username, pass;

        void connectDB()
        {
            //Ivander
            connStr = "DATA SOURCE=LOCALHOST:1521/XEPDB1;PERSIST SECURITY INFO=True;USER ID = IBW25; PASSWORD = Sapi2121";
            //Kwan
            //connStr = "DATA SOURCE=LOCALHOST:1521/XE;PERSIST SECURITY INFO=True;USER ID = calvin; PASSWORD = kwan";
            //Anno 
            //connStr = "Data Source = LOCALHOST:1521/XEPDB1; User ID = edo; password = edo";
            //Axel
            //connStr = "DATA SOURCE=LOCALHOST:1521/XEPDB1;PERSIST SECURITY INFO=True;USER ID = AXEL; PASSWORD = 12345";
            //Chiari
            //connStr = "DATA SOURCE=LOCALHOST:1521/XEPDB1; USER ID = PRAK_ACS; PASSWORD = chiari2002";


            conn = new OracleConnection(connStr);
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error karena " + ex.Message);
            }
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            String Username = textBoxUsername.Text;
            String Password = textBoxPassword.Text;

            if (Username == "" || Password == "")
            {
                MessageBox.Show("Semua Harus Diisi");
            }
            else if(Username != "" && Password != "")
            {
                conn.Open();
                queryStr = "select * from karyawan where fk_jabatan = 1 and username_karyawan = '" + Username + "' and password_karyawan = '" + Password + "'";
                cmd = new OracleCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Add(textBoxUsername.Text, username);
                cmd.Parameters.Add(textBoxPassword.Text, pass);

                reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                try
                {
                    while (reader.Read())
                    {
                        id = reader[0].ToString();
                        string namaadmin = reader["username_karyawan"].ToString();
                        string passsadmin = reader["password_karyawan"].ToString();

                        if (namaadmin == Username && passsadmin == Password)
                        {
                            MessageBox.Show("Login Berhasil sebagai Admin");
                            FormAdmin frmpilihan = new FormAdmin();
                            frmpilihan.Show();
                            this.Hide();
                        }
                        else if (namaadmin != Username || passsadmin != Password)
                        {
                            MessageBox.Show("Pass atau username salah untuk Sales");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }

                conn.Close();
            }

            if (Username != "" && Password != "")
            {
                conn.Open();
                queryStr = "select * from karyawan where fk_jabatan = 2 and username_karyawan = '" + Username + "' and password_karyawan = '" + Password + "'";
                cmd = new OracleCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Add(textBoxUsername.Text, username);
                cmd.Parameters.Add(textBoxPassword.Text, pass);

                reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                try
                {
                    while (reader.Read())
                    {
                        id = reader[0].ToString();
                        string namasales = reader["username_karyawan"].ToString();
                        string passsales = reader["password_karyawan"].ToString();

                        if (namasales == Username && passsales == Password)
                        {
                            MessageBox.Show("Login Berhasil sebagai Sales");
                            FormMenuSales kesini = new FormMenuSales();
                            this.Hide();
                            kesini.Show();
                        }
                        else if (namasales != Username || passsales != Password)
                        {
                            MessageBox.Show("Pass atau username salah untuk Sales");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }

                conn.Close();
            }

            
        }
        public static String id;
        private void Login_Load(object sender, EventArgs e)
        {
            BLogin.Text = "";
            button1.Text = "";

            BLogin.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Login.png");
            pictureBoxLogin.BackgroundImage = Image.FromFile (Application.StartupPath + "\\SymbolProyek\\HeaderLogin.png");
            button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\ShowPass.png");
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == false)
            {
                textBoxPassword.UseSystemPasswordChar = true;
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\ShowPass.png");
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HidePass.png");
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
