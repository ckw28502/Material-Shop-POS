
namespace Proyek_ACS
{
    partial class FormTracking
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dateTimePickerPengiriman = new System.Windows.Forms.DateTimePicker();
            this.radioButtonBerhasil = new System.Windows.Forms.RadioButton();
            this.radioButtonPacking = new System.Windows.Forms.RadioButton();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonDikirim = new System.Windows.Forms.RadioButton();
            this.radioButtonSampai = new System.Windows.Forms.RadioButton();
            this.comboBoxNamaBarang = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(549, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 38);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 293);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nomor Nota :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tanggal Pengiriman :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status :";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(245, 384);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(244, 22);
            this.textBoxId.TabIndex = 21;
            // 
            // dateTimePickerPengiriman
            // 
            this.dateTimePickerPengiriman.Location = new System.Drawing.Point(245, 462);
            this.dateTimePickerPengiriman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerPengiriman.Name = "dateTimePickerPengiriman";
            this.dateTimePickerPengiriman.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerPengiriman.TabIndex = 22;
            // 
            // radioButtonBerhasil
            // 
            this.radioButtonBerhasil.AutoSize = true;
            this.radioButtonBerhasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBerhasil.Location = new System.Drawing.Point(245, 580);
            this.radioButtonBerhasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBerhasil.Name = "radioButtonBerhasil";
            this.radioButtonBerhasil.Size = new System.Drawing.Size(140, 22);
            this.radioButtonBerhasil.TabIndex = 25;
            this.radioButtonBerhasil.TabStop = true;
            this.radioButtonBerhasil.Text = "Berhasil Terkirim";
            this.radioButtonBerhasil.UseVisualStyleBackColor = true;
            // 
            // radioButtonPacking
            // 
            this.radioButtonPacking.AutoSize = true;
            this.radioButtonPacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPacking.Location = new System.Drawing.Point(245, 502);
            this.radioButtonPacking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPacking.Name = "radioButtonPacking";
            this.radioButtonPacking.Size = new System.Drawing.Size(151, 22);
            this.radioButtonPacking.TabIndex = 24;
            this.radioButtonPacking.TabStop = true;
            this.radioButtonPacking.Text = "Sedang di Packing";
            this.radioButtonPacking.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(233, 609);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(189, 63);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nama Barang :";
            // 
            // radioButtonDikirim
            // 
            this.radioButtonDikirim.AutoSize = true;
            this.radioButtonDikirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDikirim.Location = new System.Drawing.Point(245, 528);
            this.radioButtonDikirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDikirim.Name = "radioButtonDikirim";
            this.radioButtonDikirim.Size = new System.Drawing.Size(129, 22);
            this.radioButtonDikirim.TabIndex = 29;
            this.radioButtonDikirim.TabStop = true;
            this.radioButtonDikirim.Text = "Sedang Dikirim";
            this.radioButtonDikirim.UseVisualStyleBackColor = true;
            // 
            // radioButtonSampai
            // 
            this.radioButtonSampai.AutoSize = true;
            this.radioButtonSampai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSampai.Location = new System.Drawing.Point(245, 554);
            this.radioButtonSampai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSampai.Name = "radioButtonSampai";
            this.radioButtonSampai.Size = new System.Drawing.Size(196, 22);
            this.radioButtonSampai.TabIndex = 30;
            this.radioButtonSampai.TabStop = true;
            this.radioButtonSampai.Text = "Sampai di Tempat Tujuan";
            this.radioButtonSampai.UseVisualStyleBackColor = true;
            // 
            // comboBoxNamaBarang
            // 
            this.comboBoxNamaBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamaBarang.FormattingEnabled = true;
            this.comboBoxNamaBarang.Location = new System.Drawing.Point(245, 420);
            this.comboBoxNamaBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNamaBarang.Name = "comboBoxNamaBarang";
            this.comboBoxNamaBarang.Size = new System.Drawing.Size(244, 24);
            this.comboBoxNamaBarang.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(233, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 50);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FormTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxNamaBarang);
            this.Controls.Add(this.radioButtonSampai);
            this.Controls.Add(this.radioButtonDikirim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.radioButtonBerhasil);
            this.Controls.Add(this.radioButtonPacking);
            this.Controls.Add(this.dateTimePickerPengiriman);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tracking";
            this.Load += new System.EventHandler(this.FormTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dateTimePickerPengiriman;
        private System.Windows.Forms.RadioButton radioButtonBerhasil;
        private System.Windows.Forms.RadioButton radioButtonPacking;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonDikirim;
        private System.Windows.Forms.RadioButton radioButtonSampai;
        private System.Windows.Forms.ComboBox comboBoxNamaBarang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}