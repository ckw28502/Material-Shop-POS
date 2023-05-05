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
    public partial class FormHistori : Form
    {
        public FormHistori()
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdmin menu = new FormAdmin();
            menu.Show();
            this.Hide();
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

                queryStr = "select distinct ht.NOMOR_NOTA as \"Nomor Nota\", h.TANGGAL_PERUBAHAN as \"Tanggal\", case when h.STATUS = 0 then 'Barang sedang di Packing' when h.STATUS = 1 then 'Barang Menuju ke Tempat Tujuan' when h.STATUS = 2 then 'Barang Telah Sampai di Tujuan' else 'Barang Telah di Terima' end as \"Status\" from JABATAN j, KARYAWAN k, MOBIL m, HISTORI h, PENGIRIMAN p, H_TRANS ht where j.id_jabatan = k.FK_JABATAN and k.ID_KARYAWAN = m.FK_KARYAWAN and m.ID = p.MOBIL and p.ID = ht.FK_PENGIRIMAN";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                dataset = new DataSet();

                adapter.Fill(dataset, "Tracking");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Tracking";

                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[2].Width = 170;

                dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormHistori_Load(object sender, EventArgs e)
        {
            this.conn = Login.conn;

            buttonBack.Text = "";
            buttonBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HeaderHistory.png");

            loadDGV();
        }
    }
}
