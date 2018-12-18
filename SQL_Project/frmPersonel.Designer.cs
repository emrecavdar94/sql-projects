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
            this.tbTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.btnTCNoDoldur = new System.Windows.Forms.Button();
            this.btnPersonelNoDoldur = new System.Windows.Forms.Button();
            this.lblPersonelSoyad = new System.Windows.Forms.Label();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.lblPersonelTCNo = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.tbPersonelSoyad = new System.Windows.Forms.TextBox();
            this.tbPersonelAd = new System.Windows.Forms.TextBox();
            this.tbPersonelNo = new System.Windows.Forms.TextBox();
            this.gbiletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.tbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblPersonelAdres = new System.Windows.Forms.Label();
            this.lblPersonelEPosta = new System.Windows.Forms.Label();
            this.lblPersonelTelNo = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbEPosta = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gbDemografikBilgiler.SuspendLayout();
            this.gbiletisimBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDemografikBilgiler
            // 
            this.gbDemografikBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDemografikBilgiler.Controls.Add(this.tbTcNo);
            this.gbDemografikBilgiler.Controls.Add(this.label2);
            this.gbDemografikBilgiler.Controls.Add(this.tbKullaniciAdi);
            this.gbDemografikBilgiler.Controls.Add(this.label1);
            this.gbDemografikBilgiler.Controls.Add(this.btnTCNoDoldur);
            this.gbDemografikBilgiler.Controls.Add(this.btnPersonelNoDoldur);
            this.gbDemografikBilgiler.Controls.Add(this.tbParola);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelSoyad);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelAd);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelTCNo);
            this.gbDemografikBilgiler.Controls.Add(this.lblPersonelNo);
            this.gbDemografikBilgiler.Controls.Add(this.tbPersonelSoyad);
            this.gbDemografikBilgiler.Controls.Add(this.tbPersonelAd);
            this.gbDemografikBilgiler.Controls.Add(this.tbPersonelNo);
            this.gbDemografikBilgiler.Location = new System.Drawing.Point(12, 12);
            this.gbDemografikBilgiler.Name = "gbDemografikBilgiler";
            this.gbDemografikBilgiler.Size = new System.Drawing.Size(260, 176);
            this.gbDemografikBilgiler.TabIndex = 0;
            this.gbDemografikBilgiler.TabStop = false;
            this.gbDemografikBilgiler.Text = "Demografik Bilgiler";
            // 
            // tbTcNo
            // 
            this.tbTcNo.Location = new System.Drawing.Point(106, 49);
            this.tbTcNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTcNo.Mask = "00000000000";
            this.tbTcNo.Name = "tbTcNo";
            this.tbTcNo.Size = new System.Drawing.Size(117, 20);
            this.tbTcNo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.Location = new System.Drawing.Point(106, 125);
            this.tbKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(148, 20);
            this.tbKullaniciAdi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Parola";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(106, 149);
            this.tbParola.Margin = new System.Windows.Forms.Padding(2);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(148, 20);
            this.tbParola.TabIndex = 11;
            // 
            // btnTCNoDoldur
            // 
            this.btnTCNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTCNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCNoDoldur.Location = new System.Drawing.Point(228, 48);
            this.btnTCNoDoldur.Name = "btnTCNoDoldur";
            this.btnTCNoDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnTCNoDoldur.TabIndex = 3;
            this.btnTCNoDoldur.Tag = "";
            this.btnTCNoDoldur.Text = "...";
            this.btnTCNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTCNoDoldur.UseVisualStyleBackColor = true;
            this.btnTCNoDoldur.Click += new System.EventHandler(this.btnTCNoDoldur_Click);
            // 
            // btnPersonelNoDoldur
            // 
            this.btnPersonelNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPersonelNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelNoDoldur.Location = new System.Drawing.Point(228, 22);
            this.btnPersonelNoDoldur.Name = "btnPersonelNoDoldur";
            this.btnPersonelNoDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnPersonelNoDoldur.TabIndex = 1;
            this.btnPersonelNoDoldur.Tag = "";
            this.btnPersonelNoDoldur.Text = "...";
            this.btnPersonelNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelNoDoldur.UseVisualStyleBackColor = true;
            this.btnPersonelNoDoldur.Click += new System.EventHandler(this.btnPersonelNoDoldur_Click);
            // 
            // lblPersonelSoyad
            // 
            this.lblPersonelSoyad.AutoSize = true;
            this.lblPersonelSoyad.Location = new System.Drawing.Point(6, 106);
            this.lblPersonelSoyad.Name = "lblPersonelSoyad";
            this.lblPersonelSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblPersonelSoyad.TabIndex = 10;
            this.lblPersonelSoyad.Text = "Soyad";
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.Location = new System.Drawing.Point(6, 76);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(20, 13);
            this.lblPersonelAd.TabIndex = 9;
            this.lblPersonelAd.Text = "Ad";
            // 
            // lblPersonelTCNo
            // 
            this.lblPersonelTCNo.AutoSize = true;
            this.lblPersonelTCNo.Location = new System.Drawing.Point(6, 50);
            this.lblPersonelTCNo.Name = "lblPersonelTCNo";
            this.lblPersonelTCNo.Size = new System.Drawing.Size(98, 13);
            this.lblPersonelTCNo.TabIndex = 8;
            this.lblPersonelTCNo.Text = "TC Kimlik Numarası";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Location = new System.Drawing.Point(6, 24);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(95, 13);
            this.lblPersonelNo.TabIndex = 7;
            this.lblPersonelNo.Text = "Personel Numarası";
            // 
            // tbPersonelSoyad
            // 
            this.tbPersonelSoyad.Location = new System.Drawing.Point(106, 100);
            this.tbPersonelSoyad.Name = "tbPersonelSoyad";
            this.tbPersonelSoyad.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelSoyad.TabIndex = 5;
            // 
            // tbPersonelAd
            // 
            this.tbPersonelAd.Location = new System.Drawing.Point(106, 74);
            this.tbPersonelAd.Name = "tbPersonelAd";
            this.tbPersonelAd.Size = new System.Drawing.Size(148, 20);
            this.tbPersonelAd.TabIndex = 4;
            // 
            // tbPersonelNo
            // 
            this.tbPersonelNo.Location = new System.Drawing.Point(106, 22);
            this.tbPersonelNo.Name = "tbPersonelNo";
            this.tbPersonelNo.Size = new System.Drawing.Size(117, 20);
            this.tbPersonelNo.TabIndex = 0;
            // 
            // gbiletisimBilgileri
            // 
            this.gbiletisimBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbiletisimBilgileri.Controls.Add(this.tbTelNo);
            this.gbiletisimBilgileri.Controls.Add(this.lblPersonelAdres);
            this.gbiletisimBilgileri.Controls.Add(this.lblPersonelEPosta);
            this.gbiletisimBilgileri.Controls.Add(this.lblPersonelTelNo);
            this.gbiletisimBilgileri.Controls.Add(this.tbAdres);
            this.gbiletisimBilgileri.Controls.Add(this.tbEPosta);
            this.gbiletisimBilgileri.Location = new System.Drawing.Point(278, 12);
            this.gbiletisimBilgileri.Name = "gbiletisimBilgileri";
            this.gbiletisimBilgileri.Size = new System.Drawing.Size(260, 142);
            this.gbiletisimBilgileri.TabIndex = 1;
            this.gbiletisimBilgileri.TabStop = false;
            this.gbiletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // tbTelNo
            // 
            this.tbTelNo.Location = new System.Drawing.Point(106, 22);
            this.tbTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelNo.Mask = "+\\9\\0(999) 000 0000";
            this.tbTelNo.Name = "tbTelNo";
            this.tbTelNo.Size = new System.Drawing.Size(148, 20);
            this.tbTelNo.TabIndex = 11;
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
            this.tbAdres.Size = new System.Drawing.Size(148, 59);
            this.tbAdres.TabIndex = 8;
            // 
            // tbEPosta
            // 
            this.tbEPosta.Location = new System.Drawing.Point(106, 45);
            this.tbEPosta.Name = "tbEPosta";
            this.tbEPosta.Size = new System.Drawing.Size(148, 20);
            this.tbEPosta.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(444, 159);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle/Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 196);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gbiletisimBilgileri);
            this.Controls.Add(this.gbDemografikBilgiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
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
        private System.Windows.Forms.TextBox tbPersonelNo;
        private System.Windows.Forms.GroupBox gbiletisimBilgileri;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbEPosta;
        private System.Windows.Forms.Button btnTCNoDoldur;
        private System.Windows.Forms.Button btnPersonelNoDoldur;
        private System.Windows.Forms.Label lblPersonelAdres;
        private System.Windows.Forms.Label lblPersonelEPosta;
        private System.Windows.Forms.Label lblPersonelTelNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.MaskedTextBox tbTcNo;
        private System.Windows.Forms.MaskedTextBox tbTelNo;
    }
}