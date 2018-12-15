namespace SQL_Project
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.gbDemografikBilgiler = new System.Windows.Forms.GroupBox();
            this.btnTCNoDoldur = new System.Windows.Forms.Button();
            this.btnPersonelNoDoldur = new System.Windows.Forms.Button();
            this.lblPersonelSoyad = new System.Windows.Forms.Label();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.lblPersonelTCNo = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.tbPersonelSoyad = new System.Windows.Forms.TextBox();
            this.tbPersonelAd = new System.Windows.Forms.TextBox();
            this.tbPersonelTCNo = new System.Windows.Forms.TextBox();
            this.tbPersonelNo = new System.Windows.Forms.TextBox();
            this.gbiletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.lblPersonelAdres = new System.Windows.Forms.Label();
            this.lblPersonelEPosta = new System.Windows.Forms.Label();
            this.lblPersonelTelNo = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbEPosta = new System.Windows.Forms.TextBox();
            this.tbTelNo = new System.Windows.Forms.TextBox();
            this.gbDemografikBilgiler.SuspendLayout();
            this.gbiletisimBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDemografikBilgiler
            // 
            this.gbDemografikBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDemografikBilgiler.Controls.Add(this.btnTCNoDoldur);
            this.gbDemografikBilgiler.Controls.Add(this.btnPersonelNoDoldur);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelSoyad);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelAd);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelTCNo);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelNo);
            this.gbDemografikBilgiler.Controls.Add(this.tbPersonelSoyad);
            this.gbDemografikBilgiler.Controls.Add(this.tbPersonelAd);
            this.gbDemografikBilgiler.Controls.Add(this.tbPersonelTCNo);
            this.gbDemografikBilgiler.Controls.Add(this.tbPersonelNo);
            this.gbDemografikBilgiler.Location = new System.Drawing.Point(12, 12);
            this.gbDemografikBilgiler.Name = "gbDemografikBilgiler";
            this.gbDemografikBilgiler.Size = new System.Drawing.Size(260, 147);
            this.gbDemografikBilgiler.TabIndex = 0;
            this.gbDemografikBilgiler.TabStop = false;
            this.gbDemografikBilgiler.Text = "Demografik Bilgiler";
            // 
            // btnTCNoDoldur
            // 
            this.btnTCNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTCNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCNoDoldur.Location = new System.Drawing.Point(229, 50);
            this.btnTCNoDoldur.Name = "btnTCNoDoldur";
            this.btnTCNoDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnTCNoDoldur.TabIndex = 3;
            this.btnTCNoDoldur.Tag = "";
            this.btnTCNoDoldur.Text = "...";
            this.btnTCNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTCNoDoldur.UseVisualStyleBackColor = true;
            // 
            // btnPersonelNoDoldur
            // 
            this.btnPersonelNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPersonelNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelNoDoldur.Location = new System.Drawing.Point(229, 24);
            this.btnPersonelNoDoldur.Name = "btnPersonelNoDoldur";
            this.btnPersonelNoDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnPersonelNoDoldur.TabIndex = 1;
            this.btnPersonelNoDoldur.Tag = "";
            this.btnPersonelNoDoldur.Text = "...";
            this.btnPersonelNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelNoDoldur.UseVisualStyleBackColor = true;
            // 
            // lblPersonelSoyad
            // 
            this.lblPersonelSoyad.AutoSize = true;
            this.lblPersonelSoyad.Location = new System.Drawing.Point(6, 108);
            this.lblPersonelSoyad.Name = "lblPersonelSoyad";
            this.lblPersonelSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblPersonelSoyad.TabIndex = 10;
            this.lblPersonelSoyad.Text = "Soyad";
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.Location = new System.Drawing.Point(6, 78);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(20, 13);
            this.lblPersonelAd.TabIndex = 9;
            this.lblPersonelAd.Text = "Ad";
            // 
            // lblPersonelTCNo
            // 
            this.lblPersonelTCNo.AutoSize = true;
            this.lblPersonelTCNo.Location = new System.Drawing.Point(6, 52);
            this.lblPersonelTCNo.Name = "lblPersonelTCNo";
            this.lblPersonelTCNo.Size = new System.Drawing.Size(98, 13);
            this.lblPersonelTCNo.TabIndex = 8;
            this.lblPersonelTCNo.Text = "TC Kimlik Numarası";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Location = new System.Drawing.Point(6, 26);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(95, 13);
            this.lblPersonelNo.TabIndex = 7;
            this.lblPersonelNo.Text = "Personel Numarası";
            // 
            // tbPersonelSoyad
            // 
            this.tbPersonelSoyad.Location = new System.Drawing.Point(106, 102);
            this.tbPersonelSoyad.Name = "tbPersonelSoyad";
            this.tbPersonelSoyad.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelSoyad.TabIndex = 5;
            // 
            // tbPersonelAd
            // 
            this.tbPersonelAd.Location = new System.Drawing.Point(106, 76);
            this.tbPersonelAd.Name = "tbPersonelAd";
            this.tbPersonelAd.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelAd.TabIndex = 4;
            // 
            // tbPersonelTCNo
            // 
            this.tbPersonelTCNo.Location = new System.Drawing.Point(106, 50);
            this.tbPersonelTCNo.Name = "tbPersonelTCNo";
            this.tbPersonelTCNo.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelTCNo.TabIndex = 2;
            // 
            // tbPersonelNo
            // 
            this.tbPersonelNo.Location = new System.Drawing.Point(106, 24);
            this.tbPersonelNo.Name = "tbPersonelNo";
            this.tbPersonelNo.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelNo.TabIndex = 0;
            // 
            // gbiletisimBilgileri
            // 
            this.gbiletisimBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbiletisimBilgileri.Controls.Add(this.lblPersonelAdres);
            this.gbiletisimBilgileri.Controls.Add(this.lblPersonelEPosta);
            this.gbiletisimBilgileri.Controls.Add(this.lblPersonelTelNo);
            this.gbiletisimBilgileri.Controls.Add(this.tbAdres);
            this.gbiletisimBilgileri.Controls.Add(this.tbEPosta);
            this.gbiletisimBilgileri.Controls.Add(this.tbTelNo);
            this.gbiletisimBilgileri.Location = new System.Drawing.Point(278, 12);
            this.gbiletisimBilgileri.Name = "gbiletisimBilgileri";
            this.gbiletisimBilgileri.Size = new System.Drawing.Size(260, 147);
            this.gbiletisimBilgileri.TabIndex = 1;
            this.gbiletisimBilgileri.TabStop = false;
            this.gbiletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // lblPersonelAdres
            // 
            this.lblPersonelAdres.AutoSize = true;
            this.lblPersonelAdres.Location = new System.Drawing.Point(6, 74);
            this.lblPersonelAdres.Name = "lblPersonelAdres";
            this.lblPersonelAdres.Size = new System.Drawing.Size(34, 13);
            this.lblPersonelAdres.TabIndex = 10;
            this.lblPersonelAdres.Text = "Adres";
            // 
            // lblPersonelEPosta
            // 
            this.lblPersonelEPosta.AutoSize = true;
            this.lblPersonelEPosta.Location = new System.Drawing.Point(6, 48);
            this.lblPersonelEPosta.Name = "lblPersonelEPosta";
            this.lblPersonelEPosta.Size = new System.Drawing.Size(50, 13);
            this.lblPersonelEPosta.TabIndex = 9;
            this.lblPersonelEPosta.Text = "E - Posta";
            // 
            // lblPersonelTelNo
            // 
            this.lblPersonelTelNo.AutoSize = true;
            this.lblPersonelTelNo.Location = new System.Drawing.Point(6, 22);
            this.lblPersonelTelNo.Name = "lblPersonelTelNo";
            this.lblPersonelTelNo.Size = new System.Drawing.Size(90, 13);
            this.lblPersonelTelNo.TabIndex = 8;
            this.lblPersonelTelNo.Text = "Telefon Numarası";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(106, 71);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(148, 70);
            this.tbAdres.TabIndex = 8;
            // 
            // tbEPosta
            // 
            this.tbEPosta.Location = new System.Drawing.Point(106, 45);
            this.tbEPosta.Name = "tbEPosta";
            this.tbEPosta.Size = new System.Drawing.Size(148, 20);
            this.tbEPosta.TabIndex = 7;
            // 
            // tbTelNo
            // 
            this.tbTelNo.Location = new System.Drawing.Point(106, 19);
            this.tbTelNo.Name = "tbTelNo";
            this.tbTelNo.Size = new System.Drawing.Size(148, 20);
            this.tbTelNo.TabIndex = 6;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 260);
            this.Controls.Add(this.gbiletisimBilgileri);
            this.Controls.Add(this.gbDemografikBilgiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.gbDemografikBilgiler.ResumeLayout(false);
            this.gbDemografikBilgiler.PerformLayout();
            this.gbiletisimBilgileri.ResumeLayout(false);
            this.gbiletisimBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDemografikBilgiler;
        private System.Windows.Forms.Label lblPersonelSoyad;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.Label lblPersonelTCNo;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.TextBox tbPersonelSoyad;
        private System.Windows.Forms.TextBox tbPersonelAd;
        private System.Windows.Forms.TextBox tbPersonelTCNo;
        private System.Windows.Forms.TextBox tbPersonelNo;
        private System.Windows.Forms.GroupBox gbiletisimBilgileri;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbEPosta;
        private System.Windows.Forms.TextBox tbTelNo;
        private System.Windows.Forms.Button btnTCNoDoldur;
        private System.Windows.Forms.Button btnPersonelNoDoldur;
        private System.Windows.Forms.Label lblPersonelAdres;
        private System.Windows.Forms.Label lblPersonelEPosta;
        private System.Windows.Forms.Label lblPersonelTelNo;
    }
}