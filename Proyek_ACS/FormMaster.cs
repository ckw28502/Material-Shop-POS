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
    public partial class FormMaster : Form
    {
        public Login logins;
        OracleConnection conn;
        public FormMaster()
        {
            InitializeComponent();
            conn = Login.conn;
        }

        String queryStr;
        DataSet dataset;
        OracleCommand query;
        OracleDataAdapter adapter;
        OracleCommand cmd;
        DataTable dtBarang;
        OracleDataAdapter daBarang;

        private void Form3_Load(object sender, EventArgs e)
        {
            btnFilter.Text = "";
            btnBack.Text = "";
            btnUpdate.Text = "";
            btnInsert.Text = "";
            btnDelete.Text = "";
            btnClear.Text = "";

            btnFilter.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Filter.png");
            btnBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");
            btnUpdate.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Update.png");
            btnInsert.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Insert.png");
            btnDelete.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Delete.png");
            btnClear.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Clear.png");

            loaddgv();
            txtboxid.Enabled = false;
            loadcmbkategori();
            dgvBarang.Columns["Kategori"].Visible = false;
            
        }

        int idx;
        private void dgvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string kategori;
            idx = e.RowIndex;
            txtboxid.Text = dgvBarang.Rows[idx].Cells[0].Value.ToString();
            txtboxnama.Text = dgvBarang.Rows[idx].Cells[1].Value.ToString();
            txtboxharga.Text = dgvBarang.Rows[idx].Cells[2].Value.ToString();
            numStok.Text = dgvBarang.Rows[idx].Cells[3].Value.ToString();
            txtboxSatuan.Text = dgvBarang.Rows[idx].Cells[4].Value.ToString();
            kategori = Convert.ToString(dgvBarang.Rows[idx].Cells[5].Value.ToString());

            if (kategori == "1")
            {
                cmbboxkategori.SelectedIndex = 0;
            }
            else if (kategori == "2")
            {
                cmbboxkategori.SelectedIndex = 1;
            }
            else if (kategori == "3")
            {
                cmbboxkategori.SelectedIndex = 2;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // gausa dipake
        }

        void loaddgv()
        {
            conn.Close();
            conn.Open();

            queryStr = "select id_barang as \"Id Barang\", nama_barang as \"Nama Barang\", harga_barang as \"Harga Barang\", stok_barang as \"Stok\", satuan as \"Satuan\", fk_kategori as \"Kategori\" from barang where status = 1"; ;
            query = new OracleCommand(queryStr, conn);
            adapter = new OracleDataAdapter(query);
            dataset = new DataSet();

            adapter.Fill(dataset, "barang");

            dgvBarang.DataSource = dataset;
            dgvBarang.DataMember = "barang";

            dgvBarang.Columns["Harga Barang"].DefaultCellStyle.Format = "Rp 0,000.00##";

            conn.Close();
        }

        void loadcmbkategori()
        {
            daBarang = new OracleDataAdapter("select nama_kategori from kategori", conn);
            dtBarang = new DataTable();
            daBarang.Fill(dtBarang);
            cmbboxkategori.DataSource = dtBarang.DefaultView;
            cmbboxkategori.DisplayMember = dtBarang.Columns["nama_kategori"].ToString();
            cmbboxkategori.SelectedIndex = 0;
            cmbboxkategori.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void carinamabarang()
        {
            conn.Close();
            conn.Open();
            queryStr = $"select id_barang as \"Id Barang\", nama_barang as \"Nama Barang\", harga_barang as \"Harga Barang\", stok_barang as \"Stok\", satuan as \"Satuan\" from barang WHERE nama_barang LIKE '{ txtfilter.Text}%'";
            query = new OracleCommand(queryStr, conn);
            adapter = new OracleDataAdapter(query);
            dataset = new DataSet();

            adapter.Fill(dataset, "barang");
            dgvBarang.DataSource = dataset;
            dgvBarang.DataMember = "barang";
            dgvBarang.Columns["Harga Barang"].DefaultCellStyle.Format = "Rp 0,000.00##";

            query.ExecuteNonQuery();
            conn.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
                carinamabarang();
        }


        int max = 0;
        void cekidbarang()
        {
            conn.Close();
            conn.Open();
            queryStr = "select MAX(id_barang) from barang";
            cmd = new OracleCommand(queryStr, conn);
            max = Int32.Parse(cmd.ExecuteScalar().ToString());
            max += 1;
            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cekidbarang();
                conn.Open();
                String kategori;
                kategori = Convert.ToString(dgvBarang.Rows[idx].Cells[5].Value.ToString());
                if (cmbboxkategori.SelectedIndex == 0)
                {
                    kategori = "1";
                }
                else if (cmbboxkategori.SelectedIndex == 1)
                {
                    kategori = "2";
                }
                else if (cmbboxkategori.SelectedIndex == 2)
                {
                    kategori = "3";
                }
                queryStr = $"INSERT INTO barang VALUES ({max},'{txtboxnama.Text}', '{txtboxharga.Text}', {numStok.Text},'{txtboxSatuan.Text}',{1},'{kategori}')";
                cmd = new OracleCommand(queryStr, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Sukses Insert");
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin frmadmin = new FormAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idx != -1)
            {
                
                try
                {
                    conn.Open();
                    String kategori;
                    kategori = Convert.ToString(dgvBarang.Rows[idx].Cells[5].Value.ToString());

                    if (cmbboxkategori.SelectedIndex == 0)
                    {
                        kategori = "1";
                    }
                    else if (cmbboxkategori.SelectedIndex == 1)
                    {
                        kategori = "2";
                    }
                    else if (cmbboxkategori.SelectedIndex == 2)
                    {
                        kategori = "3";
                    }


                    queryStr = $"UPDATE barang SET nama_barang = '{txtboxnama.Text}', harga_barang = '{txtboxharga.Text}', stok_barang = {numStok.Text}, satuan = '{txtboxSatuan.Text}' , fk_kategori = '{kategori}' WHERE id_barang = {dgvBarang.Rows[idx].Cells[0].Value.ToString()}";
                    cmd = new OracleCommand(queryStr,conn);
                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                    
                    MessageBox.Show("Sukses Update");
                    loaddgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }       
            }
            else
            {
                MessageBox.Show("Hmmmm");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idx != -1)
            {
                conn.Open();
                queryStr = $"update barang set status = 0 WHERE id_barang = {dgvBarang.Rows[idx].Cells[0].Value.ToString()}";
                cmd = new OracleCommand(queryStr, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Sukses Delete");
                loaddgv();
            }
            else
            {
                MessageBox.Show("Hmmmm");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtfilter.Text = "";
            txtboxid.Text = "";
            txtboxnama.Text = "";
            txtboxharga.Text = "";
            txtboxSatuan.Text = "";
            numStok.Value = 0;
        }
    }
}
