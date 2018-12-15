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
            this.lblMusteriAdres = new System.Windows.Forms.Label();
            this.lblMusteriEPosta = new System.Windows.Forms.Label();
            this.lblMusteriTelNo = new System.Windows.Forms.Label();
            this.lblMusteriTCNo = new System.Windows.Forms.Label();
            this.tbMusteriAdres = new System.Windows.Forms.TextBox();
            this.tbMusteriEPosta = new System.Windows.Forms.TextBox();
            this.tbMusteriTelNo = new System.Windows.Forms.TextBox();
            this.tbMusteriTCNo = new System.Windows.Forms.TextBox();
            this.gbGenelBilgiler = new System.Windows.Forms.GroupBox();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.tbMusteriSoyad = new System.Windows.Forms.TextBox();
            this.tbMusteriAd = new System.Windows.Forms.TextBox();
            this.tbMusteriNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbKisiselBilgiler.SuspendLayout();
            this.gbGenelBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKisiselBilgiler
            // 
            this.gbKisiselBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriAdres);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriEPosta);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTCNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriAdres);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriEPosta);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriTCNo);
            this.gbKisiselBilgiler.Location = new System.Drawing.Point(371, 15);
            this.gbKisiselBilgiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKisiselBilgiler.Name = "gbKisiselBilgiler";
            this.gbKisiselBilgiler.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKisiselBilgiler.Size = new System.Drawing.Size(347, 215);
            this.gbKisiselBilgiler.TabIndex = 0;
            this.gbKisiselBilgiler.TabStop = false;
            this.gbKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // lblMusteriAdres
            // 
            this.lblMusteriAdres.AutoSize = true;
            this.lblMusteriAdres.Location = new System.Drawing.Point(8, 123);
            this.lblMusteriAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriAdres.Name = "lblMusteriAdres";
            this.lblMusteriAdres.Size = new System.Drawing.Size(95, 17);
            this.lblMusteriAdres.TabIndex = 10;
            this.lblMusteriAdres.Text = "Müşteri Adres";
            // 
            // lblMusteriEPosta
            // 
            this.lblMusteriEPosta.AutoSize = true;
            this.lblMusteriEPosta.Location = new System.Drawing.Point(8, 91);
            this.lblMusteriEPosta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriEPosta.Name = "lblMusteriEPosta";
            this.lblMusteriEPosta.Size = new System.Drawing.Size(116, 17);
            this.lblMusteriEPosta.TabIndex = 9;
            this.lblMusteriEPosta.Text = "Müşteri E - Posta";
            // 
            // lblMusteriTelNo
            // 
            this.lblMusteriTelNo.AutoSize = true;
            this.lblMusteriTelNo.Location = new System.Drawing.Point(8, 59);
            this.lblMusteriTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriTelNo.Name = "lblMusteriTelNo";
            this.lblMusteriTelNo.Size = new System.Drawing.Size(100, 17);
            this.lblMusteriTelNo.TabIndex = 8;
            this.lblMusteriTelNo.Text = "Müşteri Tel No";
            // 
            // lblMusteriTCNo
            // 
            this.lblMusteriTCNo.AutoSize = true;
            this.lblMusteriTCNo.Location = new System.Drawing.Point(8, 27);
            this.lblMusteriTCNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriTCNo.Name = "lblMusteriTCNo";
            this.lblMusteriTCNo.Size = new System.Drawing.Size(130, 17);
            this.lblMusteriTCNo.TabIndex = 7;
            this.lblMusteriTCNo.Text = "TC Kimlik Numarası";
            // 
            // tbMusteriAdres
            // 
            this.tbMusteriAdres.Location = new System.Drawing.Point(141, 119);
            this.tbMusteriAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteriAdres.Multiline = true;
            this.tbMusteriAdres.Name = "tbMusteriAdres";
            this.tbMusteriAdres.Size = new System.Drawing.Size(196, 88);
            this.tbMusteriAdres.TabIndex = 6;
            // 
            // tbMusteriEPosta
            // 
            this.tbMusteriEPosta.Location = new System.Drawing.Point(141, 87);
            this.tbMusteriEPosta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteriEPosta.Name = "tbMusteriEPosta";
            this.tbMusteriEPosta.Size = new System.Drawing.Size(196, 22);
            this.tbMusteriEPosta.TabIndex = 5;
            // 
            // tbMusteriTelNo
            // 
            this.tbMusteriTelNo.Location = new System.Drawing.Point(141, 55);
            this.tbMusteriTelNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteriTelNo.Name = "tbMusteriTelNo";
            this.tbMusteriTelNo.Size = new System.Drawing.Size(196, 22);
            this.tbMusteriTelNo.TabIndex = 4;
            // 
            // tbMusteriTCNo
            // 
            this.tbMusteriTCNo.Location = new System.Drawing.Point(141, 23);
            this.tbMusteriTCNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteriTCNo.Name = "tbMusteriTCNo";
            this.tbMusteriTCNo.Size = new System.Drawing.Size(196, 22);
            this.tbMusteriTCNo.TabIndex = 3;
            // 
            // gbGenelBilgiler
            // 
            this.gbGenelBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbGenelBilgiler.Controls.Add(this.lblMusteriSoyad);
            this.gbGenelBilgiler.Controls.Add(this.lblMusteriAd);
            this.gbGenelBilgiler.Controls.Add(this.lblMusteriNo);
            this.gbGenelBilgiler.Controls.Add(this.tbMusteriSoyad);
            this.gbGenelBilgiler.Controls.Add(this.tbMusteriAd);
            this.gbGenelBilgiler.Controls.Add(this.tbMusteriNo);
            this.gbGenelBilgiler.Location = new System.Drawing.Point(16, 15);
            this.gbGenelBilgiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGenelBilgiler.Name = "gbGenelBilgiler";
            this.gbGenelBilgiler.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGenelBilgiler.Size = new System.Drawing.Size(347, 122);
            this.gbGenelBilgiler.TabIndex = 1;
            this.gbGenelBilgiler.TabStop = false;
            this.gbGenelBilgiler.Text = "Genel Bilgiler";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(8, 91);
            this.lblMusteriSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(98, 17);
            this.lblMusteriSoyad.TabIndex = 5;
            this.lblMusteriSoyad.Text = "Müşteri Soyad";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(8, 59);
            this.lblMusteriAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(75, 17);
            this.lblMusteriAd.TabIndex = 4;
            this.lblMusteriAd.Text = "Müşteri Ad";
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(8, 27);
            this.lblMusteriNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(118, 17);
            this.lblMusteriNo.TabIndex = 3;
            this.lblMusteriNo.Text = "Müşteri Numarası";
            // 
            // tbMusteriSoyad
            // 
            this.tbMusteriSoyad.Location = new System.Drawing.Point(141, 87);
            this.tbMusteriSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteriSoyad.Name = "tbMusteriSoyad";
            this.tbMusteriSoyad.Size = new System.Drawing.Size(196, 22);
            this.tbMusteriSoyad.TabIndex = 2;
            // 
            // tbMusteriAd
            // 
            this.tbMusteriAd.Location = new System.Drawing.Point(141, 55);
            this.tbMusteriAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteriAd.Name = "tbMusteriAd";
            this.tbMusteriAd.Size = new System.Drawing.Size(196, 22);
            this.tbMusteriAd.TabIndex = 1;
            // 
            // tbMusteriNo
            // 
            this.tbMusteriNo.Location = new System.Drawing.Point(141, 23);
            this.tbMusteriNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteriNo.Name = "tbMusteriNo";
            this.tbMusteriNo.Size = new System.Drawing.Size(196, 22);
            this.tbMusteriNo.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(16, 198);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 32);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(259, 198);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 32);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 335);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gbGenelBilgiler);
            this.Controls.Add(this.gbKisiselBilgiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox tbMusteriNo;
        private System.Windows.Forms.TextBox tbMusteriTCNo;
        private System.Windows.Forms.TextBox tbMusteriSoyad;
        private System.Windows.Forms.TextBox tbMusteriAd;
        private System.Windows.Forms.TextBox tbMusteriAdres;
        private System.Windows.Forms.TextBox tbMusteriEPosta;
        private System.Windows.Forms.TextBox tbMusteriTelNo;
        private System.Windows.Forms.Label lblMusteriAdres;
        private System.Windows.Forms.Label lblMusteriEPosta;
        private System.Windows.Forms.Label lblMusteriTelNo;
        private System.Windows.Forms.Label lblMusteriTCNo;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
    }
}