
namespace Proyek_ACS
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnremove = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.numqty = new System.Windows.Forms.NumericUpDown();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbcust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvcart = new System.Windows.Forms.DataGridView();
            this.lblnama = new System.Windows.Forms.Label();
            this.dgvbarang = new System.Windows.Forms.DataGridView();
            this.lblharga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbtransport = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnremove
            // 
            this.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Location = new System.Drawing.Point(276, 393);
            this.btnremove.Margin = new System.Windows.Forms.Padding(2);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(132, 41);
            this.btnremove.TabIndex = 24;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Location = new System.Drawing.Point(276, 453);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(132, 41);
            this.btnclear.TabIndex = 23;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuy.FlatAppearance.BorderSize = 0;
            this.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuy.Location = new System.Drawing.Point(276, 333);
            this.btnbuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(132, 41);
            this.btnbuy.TabIndex = 22;
            this.btnbuy.Text = "Buy";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // numqty
            // 
            this.numqty.Location = new System.Drawing.Point(276, 233);
            this.numqty.Margin = new System.Windows.Forms.Padding(2);
            this.numqty.Name = "numqty";
            this.numqty.Size = new System.Drawing.Size(132, 20);
            this.numqty.TabIndex = 21;
            this.numqty.ValueChanged += new System.EventHandler(this.numqty_ValueChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(276, 273);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(132, 41);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = ">>";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbcust
            // 
            this.cmbcust.FormattingEnabled = true;
            this.cmbcust.Location = new System.Drawing.Point(81, 124);
            this.cmbcust.Margin = new System.Windows.Forms.Padding(2);
            this.cmbcust.Name = "cmbcust";
            this.cmbcust.Size = new System.Drawing.Size(146, 21);
            this.cmbcust.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer :";
            // 
            // dgvcart
            // 
            this.dgvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcart.Location = new System.Drawing.Point(414, 208);
            this.dgvcart.Margin = new System.Windows.Forms.Padding(2);
            this.dgvcart.Name = "dgvcart";
            this.dgvcart.RowHeadersWidth = 51;
            this.dgvcart.RowTemplate.Height = 24;
            this.dgvcart.Size = new System.Drawing.Size(253, 340);
            this.dgvcart.TabIndex = 17;
            this.dgvcart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcart_CellClick);
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama.Location = new System.Drawing.Point(13, 85);
            this.lblnama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(110, 24);
            this.lblnama.TabIndex = 16;
            this.lblnama.Text = "Welcome, ";
            // 
            // dgvbarang
            // 
            this.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbarang.Location = new System.Drawing.Point(17, 208);
            this.dgvbarang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvbarang.Name = "dgvbarang";
            this.dgvbarang.RowHeadersWidth = 51;
            this.dgvbarang.RowTemplate.Height = 24;
            this.dgvbarang.Size = new System.Drawing.Size(253, 340);
            this.dgvbarang.TabIndex = 15;
            this.dgvbarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbarang_CellClick);
            // 
            // lblharga
            // 
            this.lblharga.AutoSize = true;
            this.lblharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblharga.Location = new System.Drawing.Point(371, 165);
            this.lblharga.Name = "lblharga";
            this.lblharga.Size = new System.Drawing.Size(70, 25);
            this.lblharga.TabIndex = 26;
            this.lblharga.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Transportasi :";
            // 
            // cmbtransport
            // 
            this.cmbtransport.FormattingEnabled = true;
            this.cmbtransport.Items.AddRange(new object[] {
            "Mobil Pribadi ",
            "Truk",
            "Pick Up"});
            this.cmbtransport.Location = new System.Drawing.Point(81, 165);
            this.cmbtransport.Margin = new System.Windows.Forms.Padding(2);
            this.cmbtransport.Name = "cmbtransport";
            this.cmbtransport.Size = new System.Drawing.Size(146, 21);
            this.cmbtransport.TabIndex = 28;
            this.cmbtransport.SelectedIndexChanged += new System.EventHandler(this.cmbtransport_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(581, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 31);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(232, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 39);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbtransport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblharga);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.numqty);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbcust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvcart);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.dgvbarang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.NumericUpDown numqty;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmbcust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvcart;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.DataGridView dgvbarang;
        private System.Windows.Forms.Label lblharga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbtransport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}