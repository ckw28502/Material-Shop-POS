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
    public partial class FormLaporanKinerjaSales : Form
    {
        OracleConnection conn;
        public FormLaporanKinerjaSales()
        {
            conn = Login.conn;
            InitializeComponent();
        }

        private void FormLaporanKinerjaSales_Load(object sender, EventArgs e)
        {
            btngenerate.Text = "";
            btnback.Text = "";

            btngenerate.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Generate.png");
            btnback.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");

            cmbsales.Items.Add("Semua Sales");
            cmbsales.SelectedIndex = 0;
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            String tanggalawalstring;
            String tanggalakhirstring;

            DateTime tanggalakhir;
            DateTime tanggalawal;

            tanggalawalstring = dateTimePicker1.Value.ToString("dd-MMMM-yyyy");
            tanggalakhirstring = dateTimePicker2.Value.ToString("dd-MMMM-yyyy");

            tanggalawal = Convert.ToDateTime(dateTimePicker1.Text);
            tanggalakhir = Convert.ToDateTime(dateTimePicker2.Text);

            int selected = cmbsales.SelectedIndex;
            string kinerja = "";

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
                DataSetLaporanPenjualan belibeda = new DataSetLaporanPenjualan();
                OracleCommand query = new OracleCommand();
                query.Connection = conn;
                OracleDataAdapter adapter = new OracleDataAdapter(query);

                query.CommandText = "select * from jabatan";
                adapter.Fill(beli, "jabatan");

                query.CommandText = "select * from karyawan where fk_jabatan = 2";
                adapter.Fill(beli, "karyawan");

                query.CommandText = "select * from h_trans";
                adapter.Fill(beli, "h_trans");

                CrystalReportKinerjaSales report = new CrystalReportKinerjaSales();
                if (selected == 0)
                {
                    kinerja = "Semua Sales";
                    report.SetDataSource(beli);
                }
                report.SetParameterValue("Parameter", kinerja);
                report.SetParameterValue("TanggalAwal", tanggalawalstring);
                report.SetParameterValue("TanggalAkhir", tanggalakhirstring);
                //report.SetDatabaseLogon(Form1.user, Form1.pass, Form1.source, "");
                crystalReportViewer1.ReportSource = report;
                conn.Close();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormPenghubungLaporanAdmin balik = new FormPenghubungLaporanAdmin();
            balik.Show();
            this.Hide();
        }
    }
}
