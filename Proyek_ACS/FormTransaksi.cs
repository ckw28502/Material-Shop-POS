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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }
        int biaya;
        private void Form8_Load(object sender, EventArgs e)
        {
            btnBack.Text = "";
            btnadd.Text = "";
            btnbuy.Text = "";
            btnremove.Text = "";
            btnclear.Text = "";

            btnBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Back.png");
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\HeaderTransaksi.png");
            btnadd.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\AddtoCart.png");
            btnbuy.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\CheckOut.png");
            btnremove.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\Remove.png");
            btnclear.BackgroundImage = Image.FromFile(Application.StartupPath + "\\SymbolProyek\\ClearCart.png");
            
            ubah = false;
            total = 0;
            ubahHarga();
            this.conn = Login.conn;
            dtc = new DataTable();
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new OracleCommand("select id_pelanggan,nama_pelanggan from pelanggan", conn);
            adp = new OracleDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            cmbcust.DataSource = tb.DefaultView;
            cmbcust.DisplayMember = tb.Columns[1].ToString();
            cmbcust.ValueMember = "id_pelanggan";
            cmd = new OracleCommand("select id,jenis_angkutan from mobil", conn);
            adp = new OracleDataAdapter(cmd);
            tb = new DataTable();
            adp.Fill(tb);
            cmbtransport.DataSource = tb.DefaultView;
            cmbtransport.DisplayMember = tb.Columns[1].ToString();
            cmbtransport.ValueMember = "id";
            biaya = 0;
            cmd.CommandText = $"select nama_karyawan from karyawan where id_karyawan ='{Login.id}'";
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                lblnama.Text += r[0].ToString();
            }
            conn.Close();
            loaddgv();
            cart();
            ubah = true;
        }
        private void cart()
        {
            dtc = new DataTable();
            dtc.Columns.Add("ID");
            dtc.Columns.Add("Nama");
            dtc.Columns.Add("Harga");
            dtc.Columns.Add("QTY");
            dtc.Columns.Add("Subtotal");
        }

        DataTable dtb;
        private void loaddgv()
        {
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new OracleCommand("select b.id_barang as \"Id\", b.nama_barang as \"Nama\", b.harga_barang as \"Harga\", b.stok_barang as \"Stok\", b.satuan as \"Satuan\", k.nama_kategori as \"Kategori\" from barang b join kategori k on b.fk_kategori=k.id_kategori where b.status=1 order by b.id_barang", conn);
            adp = new OracleDataAdapter(cmd);
            dtb = new DataTable();
            adp.Fill(dtb);
            dgvbarang.DataSource = dtb.DefaultView;
            dgvbarang.Columns["Harga"].DefaultCellStyle.Format = "Rp 0,000.00##";
            conn.Close();
        }

        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adp;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        int total;
        private void button4_Click(object sender, EventArgs e)
        {
            dtc.Rows.Clear();
            dgvcart.DataSource = dtc.DefaultView;
            total = 0;
            ubahHarga();
        }
        DataTable dtc;
        private void ubahHarga()
        {
            if (total<0)
            {
                total = 0;
            }
            lblharga.Text = "Rp. " + Convert.ToDouble(total).ToString("N");
        }
        DataRow drb;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (drb is null)
            {
                MessageBox.Show("Belum ada item yang dipilih!");
            }
            else if (numqty.Value>0)
            {
                if (numqty.Value>Convert.ToInt32(drb[3].ToString()))
                {
                    MessageBox.Show("Stok tidak cukup!");
                }
                else
                {
                    DataRow dr = null;
                    foreach (DataRow item in dtc.Rows)
                    {
                        if (item[0].ToString().Equals(drb[0].ToString()))
                        {
                            dr = item;

                        }
                    }
                    if (dr is null)
                    {
                        dtc.Rows.Add(drb[0].ToString(), drb[1].ToString(), drb[2].ToString(), numqty.Value, Convert.ToInt32(drb[2].ToString()) * numqty.Value);
                        total += Convert.ToInt32(dtc.Rows[dtc.Rows.Count - 1][4].ToString());
                    }
                    else
                    {
                        if (numqty.Value + Convert.ToInt32(dr[3].ToString())<= Convert.ToInt32(drb[3].ToString()))
                        {
                            total -= Convert.ToInt32(dr[4].ToString());
                            dr[3] = numqty.Value + Convert.ToInt32(dr[3].ToString());
                            dr[4] = numqty.Value * Convert.ToInt32(dr[2].ToString()) + Convert.ToInt32(dr[4].ToString());
                            total += Convert.ToInt32(dr[4].ToString());
                            changeRow(dr);
                        }
                        else
                        {
                            MessageBox.Show("Stok tidak cukup!");
                        }
                    }
                    ubahHarga();
                    ubahCart();
                    drb = null;
                    numqty.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Item yang dibeli harus lebih dari 0!");
            }
        }

        private void ubahCart()
        {
            dgvcart.DataSource = dtc.DefaultView;
            dgvcart.Columns[2].DefaultCellStyle.Format = "Rp 0,000.00##";
            dgvcart.Columns[4].DefaultCellStyle.Format = "Rp 0,000.00##";
        }

        private void changeRow(DataRow dr)
        {
            for (int i = 0; i < dtc.Rows.Count; i++)
            {
                if (dtc.Rows[i][0].ToString().Equals(dr[0].ToString()))
                {
                    for (int j = 0; j < dtc.Columns.Count; j++)
                    {
                        dtc.Rows[i][j] = dr[j].ToString();
                    }
                }
            }
        }

        private void dgvbarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            drb = dtb.Rows[dgvbarang.CurrentCell.RowIndex];
        }
        DataRow drc;
        private void dgvcart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            drc = dtc.Rows[dgvcart.CurrentCell.RowIndex];
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (!(drc is null))
            {
                total -= Convert.ToInt32(drc[4].ToString());
                dtc.Rows.Remove(drc);
                ubahHarga();
                drc = null;
                ubahCart();
            }
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            if (cmbtransport.SelectedIndex > -1 && cmbcust.SelectedIndex > -1 && dtc.Rows.Count > 0)
            {
                conn.Open();
                using (OracleTransaction t = conn.BeginTransaction())
                {
                    try
                    {
                        String nota = "NOTA";
                        nota += DateTime.Today.ToString("ddMMyyyy");
                        cmd = new OracleCommand($"select nvl(count(*),0) from h_trans where instr(nomor_nota,'{nota}')>0", conn);
                        OracleDataReader r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            nota += (Convert.ToInt32(r[0].ToString()) + 1).ToString("000");
                        }
                        int sum = 0;
                        foreach (DataRow item in dtc.Rows)
                        {
                            sum += Convert.ToInt32(item[3].ToString());
                        }
                        int max = 0;
                        if (cmbtransport.SelectedIndex == 1)
                        {
                            max = 25;
                        }
                        else if (cmbtransport.SelectedIndex == 2)
                        {
                            max = 50;
                        }
                        if (sum > max && cmbtransport.SelectedIndex > 0)
                        {
                            MessageBox.Show("Mobil tidak bisa membawa barang terlalu banyak!");
                        }
                        else
                        {
                            cmd.CommandText = $"select id,status,qty from pengiriman where mobil ={cmbtransport.SelectedIndex}";
                            r = cmd.ExecuteReader();
                            int id = -1;
                            bool insert = true;
                            while (r.Read() && insert)
                            {
                                id = Convert.ToInt32(r[0].ToString());
                                if (id > 0)
                                {
                                    if (r[1].ToString().Equals("0") && cmbtransport.SelectedIndex > 0)
                                    {
                                        if (cmbtransport.SelectedIndex == 1)
                                        {
                                            insert = cekQTY(25, Convert.ToInt32(r[2].ToString()) + sum);
                                        }
                                        else
                                        {
                                            insert = cekQTY(50, Convert.ToInt32(r[2].ToString()) + sum);
                                        }
                                    }
                                }
                            }
                            if (insert)
                            {
                                cmd.CommandText = $"select max(id) from pengiriman";
                                r = cmd.ExecuteReader();
                                while (r.Read())
                                {
                                    id = Convert.ToInt32(r[0].ToString());
                                }
                                id++;
                                cmd.CommandText = $"insert into pengiriman (id,mobil,status,qty) values ({id},{cmbtransport.SelectedIndex},0,{sum})";
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd.CommandText = $"select qty from pengiriman where id={id}";
                                r = cmd.ExecuteReader();
                                int qty = sum;
                                while (r.Read())
                                {
                                    qty += Convert.ToInt32(r[0].ToString());
                                }
                                cmd.CommandText = $"update pengiriman set qty={qty} where id={id}";
                                cmd.ExecuteNonQuery();
                            }
                            cmd.CommandText = $"insert into h_trans values('{nota}',{sum},to_date('{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}','dd-mm-yyyy-hh24-mi-ss'),'{Login.id}',{cmbcust.SelectedIndex + 1},{id})";
                            cmd.ExecuteNonQuery();
                            foreach (DataRow item in dtc.Rows)
                            {
                                cmd.CommandText = $"insert into d_trans values('{nota}',{item[3].ToString()},{item[0].ToString()},{item[2].ToString()},{item[4].ToString()})";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = $"select stok_barang from barang where id_barang={item[0].ToString()}";
                                r = cmd.ExecuteReader();
                                int stok = 0;
                                stok -= Convert.ToInt32(item[3].ToString());
                                while (r.Read())
                                {
                                    stok += Convert.ToInt32(r[0].ToString());
                                }
                                cmd.CommandText = $"update barang set stok_barang={stok} where id_barang={item[0].ToString()}";
                                cmd.ExecuteNonQuery();
                                int h = -1;
                                cmd.CommandText = "select max(id) from histori";
                                r = cmd.ExecuteReader();
                                while (r.Read())
                                {
                                    h = Convert.ToInt32(r[0].ToString()) + 1;
                                }
                                if (cmbtransport.SelectedIndex > 0)
                                {
                                    cmd.CommandText = $"insert into histori values({h},{id},to_date('{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}','dd-mm-yyyy-hh24-mi-ss'),0)";
                                    cmd.ExecuteNonQuery();
                                }
                                if (cmbtransport.SelectedIndex == 0)
                                {
                                    total = 0;
                                }
                                else if (cmbtransport.SelectedIndex == 1)
                                {
                                    total = 50000;
                                }
                                else
                                {
                                    total = 100000;
                                }
                                ubahHarga();
                                cart();
                                ubahCart();
                            }
                        }
                        t.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        t.Rollback();
                    }
                }
                conn.Close();
                loaddgv();
            }
        }

        private bool cekQTY(int v1, int v2)
        {
            if (v1 < v2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ubah;
        private void cmbtransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ubah)
            {
                total -= biaya;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new OracleCommand($"select harga_angkutan from mobil where id={cmbtransport.SelectedValue}", conn);
                OracleDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    biaya = Convert.ToInt32(r[0].ToString());
                    total += biaya;
                    ubahHarga();
                }
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenuSales sales = new FormMenuSales();
            sales.Show();
            this.Hide();
        }

        private void numqty_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
