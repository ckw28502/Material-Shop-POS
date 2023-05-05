
namespace Proyek_ACS
{
    partial class FormAdmin
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonmaster = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonHistori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTracking
            // 
            this.buttonTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTracking.FlatAppearance.BorderSize = 0;
            this.buttonTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTracking.Location = new System.Drawing.Point(9, 140);
            this.buttonTracking.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTracking.Name = "buttonTracking";
            this.buttonTracking.Size = new System.Drawing.Size(255, 51);
            this.buttonTracking.TabIndex = 2;
            this.buttonTracking.Text = "Tracking";
            this.buttonTracking.UseVisualStyleBackColor = true;
            this.buttonTracking.Click += new System.EventHandler(this.buttonTracking_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(9, 335);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(255, 51);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Laporan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonmaster
            // 
            this.buttonmaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonmaster.FlatAppearance.BorderSize = 0;
            this.buttonmaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmaster.Location = new System.Drawing.Point(9, 10);
            this.buttonmaster.Margin = new System.Windows.Forms.Padding(2);
            this.buttonmaster.Name = "buttonmaster";
            this.buttonmaster.Size = new System.Drawing.Size(255, 51);
            this.buttonmaster.TabIndex = 0;
            this.buttonmaster.Text = "Master Admin";
            this.buttonmaster.UseVisualStyleBackColor = true;
            this.buttonmaster.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Location = new System.Drawing.Point(9, 75);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(255, 51);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHistori
            // 
            this.buttonHistori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHistori.FlatAppearance.BorderSize = 0;
            this.buttonHistori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistori.Location = new System.Drawing.Point(9, 270);
            this.buttonHistori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHistori.Name = "buttonHistori";
            this.buttonHistori.Size = new System.Drawing.Size(255, 51);
            this.buttonHistori.TabIndex = 5;
            this.buttonHistori.Text = "Histori";
            this.buttonHistori.UseVisualStyleBackColor = true;
            this.buttonHistori.Click += new System.EventHandler(this.buttonHistori_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 396);
            this.Controls.Add(this.buttonHistori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTracking);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonmaster);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonmaster;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonTracking;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHistori;
    }
}