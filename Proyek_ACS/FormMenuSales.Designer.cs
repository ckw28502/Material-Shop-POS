
namespace Proyek_ACS
{
    partial class FormMenuSales
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
            this.buttonTracking = new System.Windows.Forms.Button();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTracking
            // 
            this.buttonTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTracking.FlatAppearance.BorderSize = 0;
            this.buttonTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTracking.Location = new System.Drawing.Point(9, 75);
            this.buttonTracking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTracking.Name = "buttonTracking";
            this.buttonTracking.Size = new System.Drawing.Size(255, 51);
            this.buttonTracking.TabIndex = 4;
            this.buttonTracking.Text = "Tracking";
            this.buttonTracking.UseVisualStyleBackColor = true;
            this.buttonTracking.Click += new System.EventHandler(this.buttonTracking_Click);
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransaksi.FlatAppearance.BorderSize = 0;
            this.buttonTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransaksi.Location = new System.Drawing.Point(9, 10);
            this.buttonTransaksi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Size = new System.Drawing.Size(255, 51);
            this.buttonTransaksi.TabIndex = 3;
            this.buttonTransaksi.Text = "Transaksi";
            this.buttonTransaksi.UseVisualStyleBackColor = true;
            this.buttonTransaksi.Click += new System.EventHandler(this.buttonTransaksi_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(9, 140);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(255, 51);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormMenuSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 203);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTracking);
            this.Controls.Add(this.buttonTransaksi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenuSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.FormMenuSales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTracking;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button buttonBack;
    }
}