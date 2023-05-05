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
    public partial class FormTracking : Form
    {
        public FormTracking()
        {
            InitializeComponent();
        }

        String connStr;
        OracleConnection conn;

        String queryStr;
        OracleCommand query;
        OracleDataAdapter adapter;
        DataSet dataset;

        OracleCommand cmd;

        String Update;
        OracleCommand cmd_Update;

        String Insert;
        OracleCommand cmd_Insert;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdmin frmadmin = new FormAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void FormTracking_Load(object sender, EventArgs e)
        {
            buttonBack.Text = "";
            buttonUpdate.Text = "";

            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HeaderTracking.png");

            buttonBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");
            buttonUpdate.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Update.png");

            this.conn = Login.conn;
            loadDGV();

            dateTimePickerPengiriman.Format = DateTimePickerFormat.Custom;
            dateTimePickerPengiriman.CustomFormat = "dd-MMM-yyyy";
        }

        void loadDGV()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "select  ht.NOMOR_NOTA as \"Nomor Nota\", h.TANGGAL_PERUBAHAN as \"Tanggal\", m.JENIS_ANGKUTAN as \"Angkutan\", k.NAMA_KARYAWAN as \"Supir\", case when p.STATUS = 0 then 'Barang sedang di Packing' when p.STATUS = 1 then 'Barang Menuju ke Tempat Tujuan' when p.STATUS = 2 then 'Barang Telah Sampai di Tujuan' else 'Barang Telah di Terima' end as \"Status\", p.ID from JABATAN j, KARYAWAN k, MOBIL m, HISTORI h, PENGIRIMAN p, H_TRANS ht where j.id_jabatan = k.FK_JABATAN and k.ID_KARYAWAN = m.FK_KARYAWAN and m.ID = p.MOBIL and p.ID = ht.FK_PENGIRIMAN and p.id=h.fk_pengiriman and h.id in (select max(id) from histori group by fk_pengiriman) order by ht.tanggal_transaksi";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Tracking");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Tracking";

                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[4].Width = 170;

                dataGridView1.Columns[5].Visible = false;
                //dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MMM-yyyy";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int idx;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;

            String nota = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textBoxId.Text = nota;

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = $"SELECT b.id_barang, initcap(b.nama_barang) as nama FROM D_TRANS d, BARANG b where d.FK_BAHAN = b.id_barang and d.nomor_nota = '{nota}'";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Nama_Barang");

                comboBoxNamaBarang.DataSource = dataset.Tables["Nama_Barang"];
                comboBoxNamaBarang.ValueMember = "id_barang";
                comboBoxNamaBarang.DisplayMember = "nama";

                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

            String date = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            dateTimePickerPengiriman.Value = DateTime.Parse(date);

            String status = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            if (status == "Barang sedang di Packing")
            {
                radioButtonPacking.Checked = true;
            }
            else if (status == "Barang Menuju ke Tempat Tujuan")
            {
                radioButtonDikirim.Checked = true;
            }
            else if (status == "Barang Telah Sampai di Tempat Tujuan")
            {
                radioButtonSampai.Checked = true;
            }
            else if (status == "Barang Telah di Terima")
            {
                radioButtonBerhasil.Checked = true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                int id_histori = 0;
                int id_pengiriman = Convert.ToInt32(dataGridView1.Rows[idx].Cells[5].Value.ToString());
                String date = dateTimePickerPengiriman.Value.ToString("dd-MMM-yyyy");

                if (radioButtonPacking.Checked == true)
                {
                    Update = "select max(id) from histori";
                    cmd_Update = new OracleCommand(Update, conn);
                    OracleDataReader reader = cmd_Update.ExecuteReader();
                    while (reader.Read())
                    {
                        id_histori = Convert.ToInt32(reader[0].ToString());
                    }
                    id_histori += 1;
                    queryStr = $"update pengiriman set status = {0} where ID = {id_pengiriman}";
                    Insert = $"insert into histori values({id_histori}, {id_pengiriman}, '{date}', {0})";
                }
                else if (radioButtonDikirim.Checked == true)
                {
                    Update = "select max(id) from histori";
                    cmd_Update = new OracleCommand(Update, conn);
                    OracleDataReader reader = cmd_Update.ExecuteReader();
                    while (reader.Read())
                    {
                        id_histori = Convert.ToInt32(reader[0].ToString());
                    }
                    id_histori += 1;
                    queryStr = $"update pengiriman set status = {1} where ID = {id_pengiriman}";
                    Insert = $"insert into histori values({id_histori}, {id_pengiriman}, '{date}', {1})";
                }
                else if (radioButtonSampai.Checked == true)
                {
                    Update = "select max(id) from histori";
                    cmd_Update = new OracleCommand(Update, conn);
                    OracleDataReader reader = cmd_Update.ExecuteReader();
                    while (reader.Read())
                    {
                        id_histori = Convert.ToInt32(reader[0].ToString());
                    }
                    id_histori += 1;
                    queryStr = $"update pengiriman set status = {2} where ID = {id_pengiriman}";
                    Insert = $"insert into histori values({id_histori}, {id_pengiriman}, '{date}', {2})";
                }
                else if (radioButtonBerhasil.Checked == true)
                {
                    Update = "select max(id) from histori";
                    cmd_Update = new OracleCommand(Update, conn);
                    OracleDataReader reader = cmd_Update.ExecuteReader();
                    while (reader.Read())
                    {
                        id_histori = Convert.ToInt32(reader[0].ToString());
                    }
                    id_histori += 1;
                    queryStr = $"update pengiriman set status = {3} where ID = {id_pengiriman}";
                    Insert = $"insert into histori values({id_histori}, {id_pengiriman}, '{date}', {3})";
                }

                cmd = new OracleCommand(queryStr, conn);
                cmd.ExecuteNonQuery();

                cmd_Insert = new OracleCommand(Insert, conn);
                cmd_Insert.ExecuteNonQuery();

                conn.Close();

                loadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
