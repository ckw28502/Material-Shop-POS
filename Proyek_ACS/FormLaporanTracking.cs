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
    public partial class FormLaporanTracking : Form
    {
        OracleConnection conn;
        public FormLaporanTracking()
        {
            conn = Login.conn;
            InitializeComponent();
        }

        private void FormLaporanTracking_Load(object sender, EventArgs e)
        {
            btngenerate.Text = "";
            btnback.Text = "";

            btngenerate.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Generate.png");
            btnback.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");

            cmbstatus.Items.Add("Barang yang sedang packing");
            cmbstatus.Items.Add("Barang telah di kirim dari toko menuju tempat tujuan");
            cmbstatus.Items.Add("Barang telah sampai di tempat tujuan");
            cmbstatus.Items.Add("Barang telah di terima oleh pembeli");
            cmbstatus.SelectedIndex = 0;
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            String tanggalawalstring;
            String tanggalakhirstring;

            DateTime tanggalakhir;
            DateTime tanggalawal;

            tanggalawalstring = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            tanggalakhirstring = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            tanggalawal = Convert.ToDateTime(dateTimePicker1.Text);
            tanggalakhir = Convert.ToDateTime(dateTimePicker2.Text);

            if (dateTimePicker1.Value.ToString() == "" || dateTimePicker2.Value.ToString() == "")
            {
                MessageBox.Show("Tidak ada yang boleh kosong");
            }
            else if (tanggalakhir < tanggalawal)
            {
                MessageBox.Show("tanggal akhir harus lebih besar!");
            }
            else if (tanggalakhir > tanggalawal)
            {
                DataSetLaporanPenjualan beli = new DataSetLaporanPenjualan();
                DataSetNama belibeda = new DataSetNama();
                OracleCommand query = new OracleCommand();
                query.Connection = conn;
                OracleDataAdapter adapter = new OracleDataAdapter(query);

                int selected = cmbstatus.SelectedIndex;
                string kondisi = "";

                query.CommandText = $"select * from pengiriman where status = '{cmbstatus.SelectedIndex}'";
                adapter.Fill(belibeda, "pengiriman");

                query.CommandText = $"select * from h_trans where tanggal_transaksi >= to_date('{tanggalawalstring}','yyyy-MM-dd') and tanggal_transaksi <= to_date('{tanggalakhirstring}', 'yyyy-MM-dd')";
                adapter.Fill(belibeda, "h_trans");

                query.CommandText = "select * from mobil";
                adapter.Fill(belibeda, "mobil");

                query.CommandText = "select * from karyawan";
                adapter.Fill(belibeda, "karyawan");

                CrystalReportLaporanTracking report = new CrystalReportLaporanTracking();

                if (selected == 0)
                {
                    kondisi = "Barang yang sedang packing";
                    report.SetDataSource(belibeda);
                }
                else if (selected == 1)
                {
                    kondisi = "Barang telah di kirim dari toko menuju tempat tujuan";
                    report.SetDataSource(belibeda);
                }
                else if (selected == 2)
                {
                    kondisi = "Barang telah sampai di tempat tujuan";
                    report.SetDataSource(belibeda);
                }
                else if (selected == 3)
                {
                    kondisi = "Barang telah di terima oleh pembeli";
                    report.SetDataSource(belibeda);
                }

                report.SetParameterValue("KondisiStatus", kondisi);
                report.SetParameterValue("TanggalAwal", tanggalawalstring);
                report.SetParameterValue("TanggalAkhir", tanggalakhirstring);
                //report.SetDatabaseLogon(Form1.user, Form1.pass, Form1.source, "");
                crystalReportViewer1.ReportSource = report;
                conn.Close();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormPenghubungLaporanAdmin baleks = new FormPenghubungLaporanAdmin();
            baleks.Show();
            this.Hide();
        }
    }
}
