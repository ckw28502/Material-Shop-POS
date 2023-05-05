
namespace Proyek_ACS
{
    partial class FormPenghubungLaporanAdmin
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
            this.btnpenjualan = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnTracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpenjualan
            // 
            this.btnpenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpenjualan.FlatAppearance.BorderSize = 0;
            this.btnpenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpenjualan.Location = new System.Drawing.Point(9, 10);
            this.btnpenjualan.Name = "btnpenjualan";
            this.btnpenjualan.Size = new System.Drawing.Size(255, 51);
            this.btnpenjualan.TabIndex = 0;
            this.btnpenjualan.Text = "Laporan Penjualan";
            this.btnpenjualan.UseVisualStyleBackColor = true;
            this.btnpenjualan.Click += new System.EventHandler(this.btnpenjualan_Click);
            // 
            // btnsales
            // 
            this.btnsales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsales.FlatAppearance.BorderSize = 0;
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.Location = new System.Drawing.Point(9, 75);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(255, 51);
            this.btnsales.TabIndex = 1;
            this.btnsales.Text = "Kinerja Sales";
            this.btnsales.UseVisualStyleBackColor = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(9, 205);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(255, 51);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnTracking
            // 
            this.btnTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTracking.FlatAppearance.BorderSize = 0;
            this.btnTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracking.Location = new System.Drawing.Point(9, 140);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(255, 51);
            this.btnTracking.TabIndex = 3;
            this.btnTracking.Text = "Laporan Tracking";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // FormPenghubungLaporanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 266);
            this.Controls.Add(this.btnTracking);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsales);
            this.Controls.Add(this.btnpenjualan);
            this.Name = "FormPenghubungLaporanAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.FormPenghubungLaporanAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpenjualan;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnTracking;
    }
}