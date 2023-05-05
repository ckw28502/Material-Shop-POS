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
    public partial class FormMenuSales : Form
    {
        public FormMenuSales()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Login frmlogin = new Login();
            frmlogin.Show();
            this.Hide();
        }

        private void buttonTracking_Click(object sender, EventArgs e)
        {
            FormTrackingSales frmtracking = new FormTrackingSales();
            frmtracking.Show();
            this.Hide();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi frmtrans = new FormTransaksi();
            frmtrans.Show();
            this.Hide();
        }

        private void FormMenuSales_Load(object sender, EventArgs e)
        {
            buttonTransaksi.Text = "";
            buttonTracking.Text = "";
            buttonBack.Text = "";

            buttonTransaksi.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Transaksi.png");
            buttonTracking.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Tracking.png");
            buttonBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\BackWide.png");
        }
    }
}
