namespace SQL_Project
{
    partial class frmSatis
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
            this.gbKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.btnTCNoDoldur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.lblMusteriAdres = new System.Windows.Forms.Label();
            this.lblMusteriEPosta = new System.Windows.Forms.Label();
            this.lblMusteriTelNo = new System.Windows.Forms.Label();
            this.lblMusteriTCNo = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbEPosta = new System.Windows.Forms.TextBox();
            this.tbTelNo = new System.Windows.Forms.TextBox();
            this.tbMusteriTCNo = new System.Windows.Forms.TextBox();
            this.gbAracBilgileri = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.lblMotorNo = new System.Windows.Forms.Label();
            this.tbMotorNo = new System.Windows.Forms.TextBox();
            this.lblSasiNo = new System.Windows.Forms.Label();
            this.tbSasiNo = new System.Windows.Forms.TextBox();
            this.btnSatisyap = new System.Windows.Forms.Button();
            this.gbKisiselBilgiler.SuspendLayout();
            this.gbAracBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKisiselBilgiler
            // 
            this.gbKisiselBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiselBilgiler.Controls.Add(this.btnTCNoDoldur);
            this.gbKisiselBilgiler.Controls.Add(this.label1);
            this.gbKisiselBilgiler.Controls.Add(this.label2);
            this.gbKisiselBilgiler.Controls.Add(this.tbSoyad);
            this.gbKisiselBilgiler.Controls.Add(this.tbAd);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriAdres);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriEPosta);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.lblMusteriTCNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbAdres);
            this.gbKisiselBilgiler.Controls.Add(this.tbEPosta);
            this.gbKisiselBilgiler.Controls.Add(this.tbTelNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriTCNo);
            this.gbKisiselBilgiler.Location = new System.Drawing.Point(13, 13);
            this.gbKisiselBilgiler.Margin = new System.Windows.Forms.Padding(4);
            this.gbKisiselBilgiler.Name = "gbKisiselBilgiler";
            this.gbKisiselBilgiler.Padding = new System.Windows.Forms.Padding(4);
            this.gbKisiselBilgiler.Size = new System.Drawing.Size(347, 290);
            this.gbKisiselBilgiler.TabIndex = 1;
            this.gbKisiselBilgiler.TabStop = false;
            this.gbKisiselBilgiler.Text = "Müşteri";
            this.gbKisiselBilgiler.Enter += new System.EventHandler(this.gbKisiselBilgiler_Enter);
            // 
            // btnTCNoDoldur
            // 
            this.btnTCNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTCNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCNoDoldur.Location = new System.Drawing.Point(304, 20);
            this.btnTCNoDoldur.Margin = new System.Windows.Forms.Padding(4);
            this.btnTCNoDoldur.Name = "btnTCNoDoldur";
            this.btnTCNoDoldur.Size = new System.Drawing.Size(33, 25);
            this.btnTCNoDoldur.TabIndex = 4;
            this.btnTCNoDoldur.Tag = "";
            this.btnTCNoDoldur.Text = "...";
            this.btnTCNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTCNoDoldur.UseVisualStyleBackColor = true;
            this.btnTCNoDoldur.Click += new System.EventHandler(this.btnTCNoDoldur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adı";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(141, 87);
            this.tbSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(196, 22);
            this.tbSoyad.TabIndex = 12;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(141, 55);
            this.tbAd.Margin = new System.Windows.Forms.Padding(4);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(196, 22);
            this.tbAd.TabIndex = 11;
            // 
            // lblMusteriAdres
            // 
            this.lblMusteriAdres.AutoSize = true;
            this.lblMusteriAdres.Location = new System.Drawing.Point(8, 187);
            this.lblMusteriAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriAdres.Name = "lblMusteriAdres";
            this.lblMusteriAdres.Size = new System.Drawing.Size(95, 17);
            this.lblMusteriAdres.TabIndex = 10;
            this.lblMusteriAdres.Text = "Müşteri Adres";
            // 
            // lblMusteriEPosta
            // 
            this.lblMusteriEPosta.AutoSize = true;
            this.lblMusteriEPosta.Location = new System.Drawing.Point(8, 155);
            this.lblMusteriEPosta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriEPosta.Name = "lblMusteriEPosta";
            this.lblMusteriEPosta.Size = new System.Drawing.Size(116, 17);
            this.lblMusteriEPosta.TabIndex = 9;
            this.lblMusteriEPosta.Text = "Müşteri E - Posta";
            // 
            // lblMusteriTelNo
            // 
            this.lblMusteriTelNo.AutoSize = true;
            this.lblMusteriTelNo.Location = new System.Drawing.Point(8, 123);
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
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(141, 183);
            this.tbAdres.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(196, 88);
            this.tbAdres.TabIndex = 6;
            // 
            // tbEPosta
            // 
            this.tbEPosta.Location = new System.Drawing.Point(141, 151);
            this.tbEPosta.Margin = new System.Windows.Forms.Padding(4);
            this.tbEPosta.Name = "tbEPosta";
            this.tbEPosta.Size = new System.Drawing.Size(196, 22);
            this.tbEPosta.TabIndex = 5;
            // 
            // tbTelNo
            // 
            this.tbTelNo.Location = new System.Drawing.Point(141, 119);
            this.tbTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelNo.Name = "tbTelNo";
            this.tbTelNo.Size = new System.Drawing.Size(196, 22);
            this.tbTelNo.TabIndex = 4;
            // 
            // tbMusteriTCNo
            // 
            this.tbMusteriTCNo.Location = new System.Drawing.Point(141, 23);
            this.tbMusteriTCNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbMusteriTCNo.Name = "tbMusteriTCNo";
            this.tbMusteriTCNo.Size = new System.Drawing.Size(155, 22);
            this.tbMusteriTCNo.TabIndex = 3;
            this.tbMusteriTCNo.TextChanged += new System.EventHandler(this.tbMusteriTCNo_TextChanged);
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAracBilgileri.Controls.Add(this.button1);
            this.gbAracBilgileri.Controls.Add(this.lblModel);
            this.gbAracBilgileri.Controls.Add(this.tbModel);
            this.gbAracBilgileri.Controls.Add(this.lblMarka);
            this.gbAracBilgileri.Controls.Add(this.tbMarka);
            this.gbAracBilgileri.Controls.Add(this.lblPlaka);
            this.gbAracBilgileri.Controls.Add(this.tbPlaka);
            this.gbAracBilgileri.Controls.Add(this.lblMotorNo);
            this.gbAracBilgileri.Controls.Add(this.tbMotorNo);
            this.gbAracBilgileri.Controls.Add(this.lblSasiNo);
            this.gbAracBilgileri.Controls.Add(this.tbSasiNo);
            this.gbAracBilgileri.Location = new System.Drawing.Point(368, 13);
            this.gbAracBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Padding = new System.Windows.Forms.Padding(4);
            this.gbAracBilgileri.Size = new System.Drawing.Size(347, 290);
            this.gbAracBilgileri.TabIndex = 2;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Araç Bilgileri";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(306, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 25);
            this.button1.TabIndex = 15;
            this.button1.Tag = "";
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(16, 155);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(141, 151);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(196, 22);
            this.tbModel.TabIndex = 8;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(16, 123);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(141, 119);
            this.tbMarka.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(196, 22);
            this.tbMarka.TabIndex = 6;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(16, 91);
            this.lblPlaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(43, 17);
            this.lblPlaka.TabIndex = 5;
            this.lblPlaka.Text = "Plaka";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(141, 87);
            this.tbPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(196, 22);
            this.tbPlaka.TabIndex = 4;
            // 
            // lblMotorNo
            // 
            this.lblMotorNo.AutoSize = true;
            this.lblMotorNo.Location = new System.Drawing.Point(16, 59);
            this.lblMotorNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotorNo.Name = "lblMotorNo";
            this.lblMotorNo.Size = new System.Drawing.Size(66, 17);
            this.lblMotorNo.TabIndex = 3;
            this.lblMotorNo.Text = "Motor No";
            // 
            // tbMotorNo
            // 
            this.tbMotorNo.Location = new System.Drawing.Point(141, 55);
            this.tbMotorNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbMotorNo.Name = "tbMotorNo";
            this.tbMotorNo.Size = new System.Drawing.Size(196, 22);
            this.tbMotorNo.TabIndex = 2;
            // 
            // lblSasiNo
            // 
            this.lblSasiNo.AutoSize = true;
            this.lblSasiNo.Location = new System.Drawing.Point(16, 27);
            this.lblSasiNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSasiNo.Name = "lblSasiNo";
            this.lblSasiNo.Size = new System.Drawing.Size(57, 17);
            this.lblSasiNo.TabIndex = 1;
            this.lblSasiNo.Text = "Şasi No";
            // 
            // tbSasiNo
            // 
            this.tbSasiNo.Location = new System.Drawing.Point(141, 23);
            this.tbSasiNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSasiNo.Name = "tbSasiNo";
            this.tbSasiNo.Size = new System.Drawing.Size(157, 22);
            this.tbSasiNo.TabIndex = 0;
            // 
            // btnSatisyap
            // 
            this.btnSatisyap.Location = new System.Drawing.Point(548, 311);
            this.btnSatisyap.Name = "btnSatisyap";
            this.btnSatisyap.Size = new System.Drawing.Size(103, 36);
            this.btnSatisyap.TabIndex = 3;
            this.btnSatisyap.Text = "Satış Yap";
            this.btnSatisyap.UseVisualStyleBackColor = true;
            this.btnSatisyap.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 359);
            this.Controls.Add(this.btnSatisyap);
            this.Controls.Add(this.gbAracBilgileri);
            this.Controls.Add(this.gbKisiselBilgiler);
            this.Name = "frmSatis";
            this.Text = "frmSatis";
            this.gbKisiselBilgiler.ResumeLayout(false);
            this.gbKisiselBilgiler.PerformLayout();
            this.gbAracBilgileri.ResumeLayout(false);
            this.gbAracBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKisiselBilgiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label lblMusteriAdres;
        private System.Windows.Forms.Label lblMusteriEPosta;
        private System.Windows.Forms.Label lblMusteriTelNo;
        private System.Windows.Forms.Label lblMusteriTCNo;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbEPosta;
        private System.Windows.Forms.TextBox tbTelNo;
        private System.Windows.Forms.TextBox tbMusteriTCNo;
        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.Label lblMotorNo;
        private System.Windows.Forms.TextBox tbMotorNo;
        private System.Windows.Forms.Label lblSasiNo;
        private System.Windows.Forms.TextBox tbSasiNo;
        private System.Windows.Forms.Button btnTCNoDoldur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSatisyap;
    }
}