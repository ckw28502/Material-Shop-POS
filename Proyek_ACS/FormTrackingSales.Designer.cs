
namespace Proyek_ACS
{
    partial class FormTrackingSales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonBerhasil = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPacking = new System.Windows.Forms.RadioButton();
            this.radioButtonDikirim = new System.Windows.Forms.RadioButton();
            this.radioButtonSampai = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 238);
            this.dataGridView1.TabIndex = 10;
            // 
            // radioButtonBerhasil
            // 
            this.radioButtonBerhasil.AutoSize = true;
            this.radioButtonBerhasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBerhasil.Location = new System.Drawing.Point(443, 58);
            this.radioButtonBerhasil.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBerhasil.Name = "radioButtonBerhasil";
            this.radioButtonBerhasil.Size = new System.Drawing.Size(118, 19);
            this.radioButtonBerhasil.TabIndex = 9;
            this.radioButtonBerhasil.TabStop = true;
            this.radioButtonBerhasil.Text = "Berhasil Terkirim";
            this.radioButtonBerhasil.UseVisualStyleBackColor = true;
            this.radioButtonBerhasil.Click += new System.EventHandler(this.radioButtonBerhasil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status :";
            // 
            // radioButtonPacking
            // 
            this.radioButtonPacking.AutoSize = true;
            this.radioButtonPacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPacking.Location = new System.Drawing.Point(12, 58);
            this.radioButtonPacking.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPacking.Name = "radioButtonPacking";
            this.radioButtonPacking.Size = new System.Drawing.Size(128, 19);
            this.radioButtonPacking.TabIndex = 25;
            this.radioButtonPacking.TabStop = true;
            this.radioButtonPacking.Text = "Sedang di Packing";
            this.radioButtonPacking.UseVisualStyleBackColor = true;
            this.radioButtonPacking.Click += new System.EventHandler(this.radioButtonPacking_Click);
            // 
            // radioButtonDikirim
            // 
            this.radioButtonDikirim.AutoSize = true;
            this.radioButtonDikirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDikirim.Location = new System.Drawing.Point(147, 58);
            this.radioButtonDikirim.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDikirim.Name = "radioButtonDikirim";
            this.radioButtonDikirim.Size = new System.Drawing.Size(110, 19);
            this.radioButtonDikirim.TabIndex = 30;
            this.radioButtonDikirim.TabStop = true;
            this.radioButtonDikirim.Text = "Sedang Dikirim";
            this.radioButtonDikirim.UseVisualStyleBackColor = true;
            this.radioButtonDikirim.Click += new System.EventHandler(this.radioButtonDikirim_Click);
            // 
            // radioButtonSampai
            // 
            this.radioButtonSampai.AutoSize = true;
            this.radioButtonSampai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSampai.Location = new System.Drawing.Point(273, 58);
            this.radioButtonSampai.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSampai.Name = "radioButtonSampai";
            this.radioButtonSampai.Size = new System.Drawing.Size(167, 19);
            this.radioButtonSampai.TabIndex = 31;
            this.radioButtonSampai.TabStop = true;
            this.radioButtonSampai.Text = "Sampai di Tempat Tujuan";
            this.radioButtonSampai.UseVisualStyleBackColor = true;
            this.radioButtonSampai.Click += new System.EventHandler(this.radioButtonSampai_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(474, 12);
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
            this.pictureBox1.Location = new System.Drawing.Point(193, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 41);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FormTrackingSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.radioButtonSampai);
            this.Controls.Add(this.radioButtonDikirim);
            this.Controls.Add(this.radioButtonPacking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonBerhasil);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTrackingSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tracking";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonBerhasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPacking;
        private System.Windows.Forms.RadioButton radioButtonDikirim;
        private System.Windows.Forms.RadioButton radioButtonSampai;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}