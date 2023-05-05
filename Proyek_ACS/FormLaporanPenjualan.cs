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
    public partial class FormLaporanPenjualan : Form
    {
        OracleConnection conn;
        public FormLaporanPenjualan()
        {
            conn = Login.conn;
            InitializeComponent();
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
                //DataSetLaporanPenjualan beli = new DataSetLaporanPenjualan();
                DataSetLaporanPenjualan belibeda = new DataSetLaporanPenjualan();
                OracleCommand query = new OracleCommand();
                query.Connection = conn;
                OracleDataAdapter adapter = new OracleDataAdapter(query);

                query.CommandText = "select * from mobil";
                adapter.Fill(belibeda, "mobil");

                query.CommandText = "select * from pengiriman";
                adapter.Fill(belibeda, "pengiriman");

                query.CommandText = $"select * from h_trans where tanggal_transaksi >= to_date('{tanggalawalstring}','yyyy-MM-dd') and tanggal_transaksi <= to_date('{tanggalakhirstring}', 'yyyy-MM-dd')";
                adapter.Fill(belibeda, "h_trans");

                query.CommandText = "select * from barang";
                adapter.Fill(belibeda, "barang");

                query.CommandText = $"select * from d_trans where nomor_nota in (select nomor_nota from h_trans where tanggal_transaksi >= to_date('{tanggalawalstring}', 'yyyy-MM-dd') and tanggal_transaksi <= to_date('{tanggalakhirstring}', 'yyyy-MM-dd'))";
                adapter.Fill(belibeda, "d_trans");

                CrystalReportLaporanPenjualan report = new CrystalReportLaporanPenjualan();
                /*report.SetParameterValue("Parameter", belibeda);*/
                report.SetDataSource(belibeda);
                report.SetParameterValue("TanggalAwal", tanggalawalstring);
                report.SetParameterValue("TanggalAkhir", tanggalakhirstring);
                //report.SetDatabaseLogon(Form1.user, Form1.pass, Form1.source, "");
                crystalReportViewer1.ReportSource = report;
                conn.Close();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormPenghubungLaporanAdmin kesinilagi = new FormPenghubungLaporanAdmin();
            kesinilagi.Show();
            this.Hide();
        }

        private void FormLaporanPenjualan_Load(object sender, EventArgs e)
        {
            btngenerate.Text = "";
            btnback.Text = "";

            btngenerate.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Generate.png");
            btnback.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");
        }
    }
}
