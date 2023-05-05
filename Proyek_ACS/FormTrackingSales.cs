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
    public partial class FormTrackingSales : Form
    {
        public FormTrackingSales()
        {
            InitializeComponent();
        }

        String connStr;
        OracleConnection conn;

        String queryStr;
        OracleCommand query;
        OracleDataAdapter adapter;
        DataSet dataset;

        String cmdStr;
        OracleCommand cmd;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnBack.Text = "";

            btnBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HeaderTracking.png");

            this.conn = Login.conn;
            loadDV();

            radioButtonBerhasil.Checked = false;
            radioButtonDikirim.Checked = false;
            radioButtonPacking.Checked = false;
            radioButtonSampai.Checked = false;
        }

        void loadDV()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "select ht.NOMOR_NOTA as \"Nomor Nota\", h.TANGGAL_PERUBAHAN as \"Tanggal\", m.JENIS_ANGKUTAN as \"Angkutan\", k.NAMA_KARYAWAN as \"Supir\", case when h.STATUS = 0 then 'Barang sedang di Packing' when h.STATUS = 1 then 'Barang Menuju ke Tempat Tujuan' when h.STATUS = 2 then 'Barang Telah Sampai di Tujuan' else 'Barang Telah di Terima' end as \"Status\", h.ID from JABATAN j, KARYAWAN k, MOBIL m, HISTORI h, PENGIRIMAN p, H_TRANS ht where j.id_jabatan = k.FK_JABATAN and k.ID_KARYAWAN = m.FK_KARYAWAN and m.ID = p.MOBIL and p.ID = ht.FK_PENGIRIMAN";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Tracking");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Tracking";

                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[4].Width = 170;

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load1()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "select  ht.NOMOR_NOTA as \"Nomor Nota\", h.TANGGAL_PERUBAHAN as \"Tanggal\", m.JENIS_ANGKUTAN as \"Angkutan\", k.NAMA_KARYAWAN as \"Supir\", case when p.STATUS = 0 then 'Barang sedang di Packing' when p.STATUS = 1 then 'Barang Menuju ke Tempat Tujuan' when p.STATUS = 2 then 'Barang Telah Sampai di Tujuan' else 'Barang Telah di Terima' end as \"Status\", p.ID from JABATAN j, KARYAWAN k, MOBIL m, HISTORI h, PENGIRIMAN p, H_TRANS ht where j.id_jabatan = k.FK_JABATAN and k.ID_KARYAWAN = m.FK_KARYAWAN and m.ID = p.MOBIL and p.ID = ht.FK_PENGIRIMAN and p.id=h.fk_pengiriman and h.id in (select max(id) from histori group by fk_pengiriman) and h.status=0 order by ht.tanggal_transaksi";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Tracking");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Tracking";

                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[4].Width = 170;

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load2()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "select  ht.NOMOR_NOTA as \"Nomor Nota\", h.TANGGAL_PERUBAHAN as \"Tanggal\", m.JENIS_ANGKUTAN as \"Angkutan\", k.NAMA_KARYAWAN as \"Supir\", case when p.STATUS = 0 then 'Barang sedang di Packing' when p.STATUS = 1 then 'Barang Menuju ke Tempat Tujuan' when p.STATUS = 2 then 'Barang Telah Sampai di Tujuan' else 'Barang Telah di Terima' end as \"Status\", p.ID from JABATAN j, KARYAWAN k, MOBIL m, HISTORI h, PENGIRIMAN p, H_TRANS ht where j.id_jabatan = k.FK_JABATAN and k.ID_KARYAWAN = m.FK_KARYAWAN and m.ID = p.MOBIL and p.ID = ht.FK_PENGIRIMAN and p.id=h.fk_pengiriman and h.id in (select max(id) from histori group by fk_pengiriman) and h.status=1 order by ht.tanggal_transaksi";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Tracking");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Tracking";

                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[4].Width = 170;

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load3()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "select  ht.NOMOR_NOTA as \"Nomor Nota\", h.TANGGAL_PERUBAHAN as \"Tanggal\", m.JENIS_ANGKUTAN as \"Angkutan\", k.NAMA_KARYAWAN as \"Supir\", case when p.STATUS = 0 then 'Barang sedang di Packing' when p.STATUS = 1 then 'Barang Menuju ke Tempat Tujuan' when p.STATUS = 2 then 'Barang Telah Sampai di Tujuan' else 'Barang Telah di Terima' end as \"Status\", p.ID from JABATAN j, KARYAWAN k, MOBIL m, HISTORI h, PENGIRIMAN p, H_TRANS ht where j.id_jabatan = k.FK_JABATAN and k.ID_KARYAWAN = m.FK_KARYAWAN and m.ID = p.MOBIL and p.ID = ht.FK_PENGIRIMAN and p.id=h.fk_pengiriman and h.id in (select max(id) from histori group by fk_pengiriman) and h.status=2 order by ht.tanggal_transaksi";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Tracking");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Tracking";

                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[4].Width = 170;

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load4()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = "select  ht.NOMOR_NOTA as \"Nomor Nota\", h.TANGGAL_PERUBAHAN as \"Tanggal\", m.JENIS_ANGKUTAN as \"Angkutan\", k.NAMA_KARYAWAN as \"Supir\", case when p.STATUS = 0 then 'Barang sedang di Packing' when p.STATUS = 1 then 'Barang Menuju ke Tempat Tujuan' when p.STATUS = 2 then 'Barang Telah Sampai di Tujuan' else 'Barang Telah di Terima' end as \"Status\", p.ID from JABATAN j, KARYAWAN k, MOBIL m, HISTORI h, PENGIRIMAN p, H_TRANS ht where j.id_jabatan = k.FK_JABATAN and k.ID_KARYAWAN = m.FK_KARYAWAN and m.ID = p.MOBIL and p.ID = ht.FK_PENGIRIMAN and p.id=h.fk_pengiriman and h.id in (select max(id) from histori group by fk_pengiriman) and h.status=3 order by ht.tanggal_transaksi";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Tracking");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Tracking";

                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[4].Width = 170;

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonPacking_Click(object sender, EventArgs e)
        {
            load1();
        }

        private void radioButtonDikirim_Click(object sender, EventArgs e)
        {
            load2();
        }

        private void radioButtonSampai_Click(object sender, EventArgs e)
        {
            load3();
        }

        private void radioButtonBerhasil_Click(object sender, EventArgs e)
        {
            load4();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenuSales frmsales = new FormMenuSales();
            frmsales.Show();
            this.Hide();
        }
    }
}
