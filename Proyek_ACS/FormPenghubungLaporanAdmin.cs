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
    public partial class FormPenghubungLaporanAdmin : Form
    {
        public FormPenghubungLaporanAdmin()
        {
            InitializeComponent();
        }

        private void btnpenjualan_Click(object sender, EventArgs e)
        {
            FormLaporanPenjualan kesinilagi = new FormLaporanPenjualan();
            kesinilagi.Show();
            this.Hide();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            FormLaporanKinerjaSales hai = new FormLaporanKinerjaSales();
            hai.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormAdmin kesinihehe = new FormAdmin();
            kesinihehe.Show();
            this.Hide();
        }

        private void btnTracking_Click(object sender, EventArgs e)
        {
            FormLaporanTracking sini = new FormLaporanTracking();
            sini.Show();
            this.Hide();
        }

        private void FormPenghubungLaporanAdmin_Load(object sender, EventArgs e)
        {
            btnpenjualan.Text = "";
            btnsales.Text = "";
            btnTracking.Text = "";
            btnback.Text = "";

            btnpenjualan.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\LaporanPenjualan.png");
            btnsales.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\KinerjaSales.png");
            btnTracking.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\LaporanTracking.png");
            btnback.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\BackWide.png");
        }
    }
}
