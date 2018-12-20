namespace SQL_Project
{
    partial class frmYonetim
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
            this.gbAracBilgileri = new System.Windows.Forms.GroupBox();
            this.btnParcalar = new System.Windows.Forms.Button();
            this.btnSistemSabitleri = new System.Windows.Forms.Button();
            this.btnYedekleGeriYukle = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnAraclar = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.gbAracBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAracBilgileri.Controls.Add(this.btnParcalar);
            this.gbAracBilgileri.Controls.Add(this.btnSistemSabitleri);
            this.gbAracBilgileri.Controls.Add(this.btnYedekleGeriYukle);
            this.gbAracBilgileri.Controls.Add(this.btnMusteriler);
            this.gbAracBilgileri.Controls.Add(this.btnAraclar);
            this.gbAracBilgileri.Controls.Add(this.btnPersoneller);
            this.gbAracBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAracBilgileri.Location = new System.Drawing.Point(0, 0);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Size = new System.Drawing.Size(353, 167);
            this.gbAracBilgileri.TabIndex = 3;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Yönetim Paneli";
            // 
            // btnParcalar
            // 
            this.btnParcalar.Location = new System.Drawing.Point(22, 92);
            this.btnParcalar.Margin = new System.Windows.Forms.Padding(2);
            this.btnParcalar.Name = "btnParcalar";
            this.btnParcalar.Size = new System.Drawing.Size(92, 50);
            this.btnParcalar.TabIndex = 5;
            this.btnParcalar.Text = "Parçalar";
            this.btnParcalar.UseVisualStyleBackColor = true;
            this.btnParcalar.Click += new System.EventHandler(this.btnParcalar_Click);
            // 
            // btnSistemSabitleri
            // 
            this.btnSistemSabitleri.Location = new System.Drawing.Point(239, 92);
            this.btnSistemSabitleri.Margin = new System.Windows.Forms.Padding(2);
            this.btnSistemSabitleri.Name = "btnSistemSabitleri";
            this.btnSistemSabitleri.Size = new System.Drawing.Size(92, 50);
            this.btnSistemSabitleri.TabIndex = 4;
            this.btnSistemSabitleri.Text = "Sistem Sabitleri";
            this.btnSistemSabitleri.UseVisualStyleBackColor = true;
            this.btnSistemSabitleri.Click += new System.EventHandler(this.btnSistemSabitleri_Click);
            // 
            // btnYedekleGeriYukle
            // 
            this.btnYedekleGeriYukle.Location = new System.Drawing.Point(132, 92);
            this.btnYedekleGeriYukle.Margin = new System.Windows.Forms.Padding(2);
            this.btnYedekleGeriYukle.Name = "btnYedekleGeriYukle";
            this.btnYedekleGeriYukle.Size = new System.Drawing.Size(92, 50);
            this.btnYedekleGeriYukle.TabIndex = 3;
            this.btnYedekleGeriYukle.Text = "Yedek/Geri Yükle";
            this.btnYedekleGeriYukle.UseVisualStyleBackColor = true;
            this.btnYedekleGeriYukle.Click += new System.EventHandler(this.btnYedekleGeriYukle_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(239, 28);
            this.btnMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(92, 50);
            this.btnMusteriler.TabIndex = 2;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnAraclar
            // 
            this.btnAraclar.Location = new System.Drawing.Point(132, 28);
            this.btnAraclar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.Size = new System.Drawing.Size(92, 50);
            this.btnAraclar.TabIndex = 1;
            this.btnAraclar.Text = "Araçlar";
            this.btnAraclar.UseVisualStyleBackColor = true;
            this.btnAraclar.Click += new System.EventHandler(this.btnAraclar_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(22, 28);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(92, 50);
            this.btnPersoneller.TabIndex = 0;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // frmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 167);
            this.Controls.Add(this.gbAracBilgileri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmYonetim";
            this.Text = "frmYonetim";
            this.Load += new System.EventHandler(this.frmYonetim_Load);
            this.gbAracBilgileri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.Button btnSistemSabitleri;
        private System.Windows.Forms.Button btnYedekleGeriYukle;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnAraclar;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnParcalar;
    }
}