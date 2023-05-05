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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister frmRegister = new FormRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            FormMaster frmMaster = new FormMaster();
            frmMaster.Show();
            this.Hide();
        }

        private void buttonTracking_Click(object sender, EventArgs e)
        {
            FormTracking frmtracking = new FormTracking();
            frmtracking.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Login frmlogin = new Login();
            frmlogin.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            buttonmaster.Text = "";
            buttonRegister.Text = "";
            buttonTracking.Text = "";
            button1.Text = "";
            buttonBack.Text = "";
            buttonHistori.Text = "";

            buttonmaster.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Admin.png");
            buttonRegister.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\RegisterLong.png");
            buttonTracking.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Tracking.png");
            buttonHistori.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\History.png");
            button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Laporan.png");
            buttonBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\BackWide.png");
        }

        private void buttonHistori_Click(object sender, EventArgs e)
        {
            FormHistori histori = new FormHistori();
            histori.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button laporan
            FormPenghubungLaporanAdmin kesini = new FormPenghubungLaporanAdmin();
            kesini.Show();
            this.Hide();
        }
    }
}
