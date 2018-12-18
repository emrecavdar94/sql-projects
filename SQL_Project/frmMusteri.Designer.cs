namespace SQL_Project
{
    partial class frmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteri));
            this.gbKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.tbMusTelNo = new System.Windows.Forms.MaskedTextBox();
            this.tbTcNo = new System.Windows.Forms.MaskedTextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lblMusteriAdres = new System.Windows.Forms.Label();
            this.lblMusteriEPosta = new System.Windows.Forms.Label();
            this.lblMusteriTelNo = new System.Windows.Forms.Label();
            this.lblMusteriTCNo = new System.Windows.Forms.Label();
            this.tbMusteriAdres = new System.Windows.Forms.TextBox();
            this.tbMusteriEPosta = new System.Windows.Forms.TextBox();
            this.gbGenelBilgiler = new System.Windows.Forms.GroupBox();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.tbMusteriSoyad = new System.Windows.Forms.TextBox();
            this.tbMusteriAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbKisiselBilgiler.SuspendLayout();
            this.gbGenelBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKisiselBilgiler
            // 
            this.gbKisiselBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiselBilgiler.Controls.Add(this.tbMusTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbTcNo);
            this.gbKisiselBilgiler.Controls.Add(this.btnGetir);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriAdres);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriEPosta);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTCNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriAdres);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriEPosta);
            this.gbKisiselBilgiler.Location = new System.Drawing.Point(278, 12);
            this.gbKisiselBilgiler.Name = "gbKisiselBilgiler";
            this.gbKisiselBilgiler.Size = new System.Drawing.Size(260, 175);
            this.gbKisiselBilgiler.TabIndex = 0;
            this.gbKisiselBilgiler.TabStop = false;
            this.gbKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // tbMusTelNo
            // 
            this.tbMusTelNo.Location = new System.Drawing.Point(106, 47);
            this.tbMusTelNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMusTelNo.Mask = "+\\9\\0(999) 999 9999";
            this.tbMusTelNo.Name = "tbMusTelNo";
            this.tbMusTelNo.Size = new System.Drawing.Size(148, 20);
            this.tbMusTelNo.TabIndex = 13;
            // 
            // tbTcNo
            // 
            this.tbTcNo.Location = new System.Drawing.Point(106, 17);
            this.tbTcNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTcNo.Mask = "00000000000";
            this.tbTcNo.Name = "tbTcNo";
            this.tbTcNo.Size = new System.Drawing.Size(124, 20);
            this.tbTcNo.TabIndex = 12;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(224, 17);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(28, 20);
            this.btnGetir.TabIndex = 11;
            this.btnGetir.Text = "...";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lblMusteriAdres
            // 
            this.lblMusteriAdres.AutoSize = true;
            this.lblMusteriAdres.Location = new System.Drawing.Point(6, 100);
            this.lblMusteriAdres.Name = "lblMusteriAdres";
            this.lblMusteriAdres.Size = new System.Drawing.Size(71, 13);
            this.lblMusteriAdres.TabIndex = 10;
            this.lblMusteriAdres.Text = "Müşteri Adres";
            // 
            // lblMusteriEPosta
            // 
            this.lblMusteriEPosta.AutoSize = true;
            this.lblMusteriEPosta.Location = new System.Drawing.Point(6, 74);
            this.lblMusteriEPosta.Name = "lblMusteriEPosta";
            this.lblMusteriEPosta.Size = new System.Drawing.Size(87, 13);
            this.lblMusteriEPosta.TabIndex = 9;
            this.lblMusteriEPosta.Text = "Müşteri E - Posta";
            // 
            // lblMusteriTelNo
            // 
            this.lblMusteriTelNo.AutoSize = true;
            this.lblMusteriTelNo.Location = new System.Drawing.Point(6, 48);
            this.lblMusteriTelNo.Name = "lblMusteriTelNo";
            this.lblMusteriTelNo.Size = new System.Drawing.Size(76, 13);
            this.lblMusteriTelNo.TabIndex = 8;
            this.lblMusteriTelNo.Text = "Müşteri Tel No";
            // 
            // lblMusteriTCNo
            // 
            this.lblMusteriTCNo.AutoSize = true;
            this.lblMusteriTCNo.Location = new System.Drawing.Point(6, 22);
            this.lblMusteriTCNo.Name = "lblMusteriTCNo";
            this.lblMusteriTCNo.Size = new System.Drawing.Size(98, 13);
            this.lblMusteriTCNo.TabIndex = 7;
            this.lblMusteriTCNo.Text = "TC Kimlik Numarası";
            // 
            // tbMusteriAdres
            // 
            this.tbMusteriAdres.Location = new System.Drawing.Point(106, 97);
            this.tbMusteriAdres.Multiline = true;
            this.tbMusteriAdres.Name = "tbMusteriAdres";
            this.tbMusteriAdres.Size = new System.Drawing.Size(148, 72);
            this.tbMusteriAdres.TabIndex = 6;
            // 
            // tbMusteriEPosta
            // 
            this.tbMusteriEPosta.Location = new System.Drawing.Point(106, 71);
            this.tbMusteriEPosta.Name = "tbMusteriEPosta";
            this.tbMusteriEPosta.Size = new System.Drawing.Size(148, 20);
            this.tbMusteriEPosta.TabIndex = 5;
            // 
            // gbGenelBilgiler
            // 
            this.gbGenelBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbGenelBilgiler.Controls.Add(this.lblMusteriSoyad);
            this.gbGenelBilgiler.Controls.Add(this.lblMusteriAd);
            this.gbGenelBilgiler.Controls.Add(this.tbMusteriSoyad);
            this.gbGenelBilgiler.Controls.Add(this.tbMusteriAd);
            this.gbGenelBilgiler.Location = new System.Drawing.Point(12, 12);
            this.gbGenelBilgiler.Name = "gbGenelBilgiler";
            this.gbGenelBilgiler.Size = new System.Drawing.Size(260, 99);
            this.gbGenelBilgiler.TabIndex = 1;
            this.gbGenelBilgiler.TabStop = false;
            this.gbGenelBilgiler.Text = "Genel Bilgiler";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(6, 47);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(74, 13);
            this.lblMusteriSoyad.TabIndex = 5;
            this.lblMusteriSoyad.Text = "Müşteri Soyad";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(6, 21);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(57, 13);
            this.lblMusteriAd.TabIndex = 4;
            this.lblMusteriAd.Text = "Müşteri Ad";
            // 
            // tbMusteriSoyad
            // 
            this.tbMusteriSoyad.Location = new System.Drawing.Point(106, 44);
            this.tbMusteriSoyad.Name = "tbMusteriSoyad";
            this.tbMusteriSoyad.Size = new System.Drawing.Size(148, 20);
            this.tbMusteriSoyad.TabIndex = 2;
            // 
            // tbMusteriAd
            // 
            this.tbMusteriAd.Location = new System.Drawing.Point(106, 18);
            this.tbMusteriAd.Name = "tbMusteriAd";
            this.tbMusteriAd.Size = new System.Drawing.Size(148, 20);
            this.tbMusteriAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 161);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(71, 26);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(194, 161);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(78, 26);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 272);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gbGenelBilgiler);
            this.Controls.Add(this.gbKisiselBilgiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri";
            this.gbKisiselBilgiler.ResumeLayout(false);
            this.gbKisiselBilgiler.PerformLayout();
            this.gbGenelBilgiler.ResumeLayout(false);
            this.gbGenelBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKisiselBilgiler;
        private System.Windows.Forms.GroupBox gbGenelBilgiler;
        private System.Windows.Forms.TextBox tbMusteriSoyad;
        private System.Windows.Forms.TextBox tbMusteriAd;
        private System.Windows.Forms.TextBox tbMusteriAdres;
        private System.Windows.Forms.TextBox tbMusteriEPosta;
        private System.Windows.Forms.Label lblMusteriAdres;
        private System.Windows.Forms.Label lblMusteriEPosta;
        private System.Windows.Forms.Label lblMusteriTelNo;
        private System.Windows.Forms.Label lblMusteriTCNo;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.MaskedTextBox tbTcNo;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.MaskedTextBox tbMusTelNo;
    }
}