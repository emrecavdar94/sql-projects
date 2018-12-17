namespace SQL_Project
{
    partial class frmServis
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
            this.label6 = new System.Windows.Forms.Label();
            this.tbRenk = new System.Windows.Forms.TextBox();
            this.btnSasiNoDoldur = new System.Windows.Forms.Button();
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
            this.gbKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.tbMusteriTCNo = new System.Windows.Forms.MaskedTextBox();
            this.tbTelNo = new System.Windows.Forms.MaskedTextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFaturaHesapla = new System.Windows.Forms.Button();
            this.dgParcalar = new System.Windows.Forms.DataGridView();
            this.btnParcaCikar = new System.Windows.Forms.Button();
            this.btnParcaEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFaturaTutari = new System.Windows.Forms.TextBox();
            this.dtCikis = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbYapilanIslemler = new System.Windows.Forms.TextBox();
            this.dtGiris = new System.Windows.Forms.DateTimePicker();
            this.btnIsEmriDoldur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArackm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGirisTalimat = new System.Windows.Forms.TextBox();
            this.tbIsEmriNo = new System.Windows.Forms.TextBox();
            this.btnIsEmriAc = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.gbAracBilgileri.SuspendLayout();
            this.gbKisiselBilgiler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParcalar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAracBilgileri.Controls.Add(this.label6);
            this.gbAracBilgileri.Controls.Add(this.tbRenk);
            this.gbAracBilgileri.Controls.Add(this.btnSasiNoDoldur);
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
            this.gbAracBilgileri.Location = new System.Drawing.Point(278, 11);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Size = new System.Drawing.Size(260, 236);
            this.gbAracBilgileri.TabIndex = 4;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Araç Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Renk";
            // 
            // tbRenk
            // 
            this.tbRenk.Location = new System.Drawing.Point(106, 147);
            this.tbRenk.Name = "tbRenk";
            this.tbRenk.Size = new System.Drawing.Size(148, 20);
            this.tbRenk.TabIndex = 16;
            // 
            // btnSasiNoDoldur
            // 
            this.btnSasiNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSasiNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSasiNoDoldur.Location = new System.Drawing.Point(230, 18);
            this.btnSasiNoDoldur.Name = "btnSasiNoDoldur";
            this.btnSasiNoDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnSasiNoDoldur.TabIndex = 15;
            this.btnSasiNoDoldur.Tag = "";
            this.btnSasiNoDoldur.Text = "...";
            this.btnSasiNoDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSasiNoDoldur.UseVisualStyleBackColor = true;
            this.btnSasiNoDoldur.Click += new System.EventHandler(this.btnSasiNoDoldur_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 126);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(106, 123);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(148, 20);
            this.tbModel.TabIndex = 8;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(12, 100);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(106, 97);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(148, 20);
            this.tbMarka.TabIndex = 6;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(12, 74);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 5;
            this.lblPlaka.Text = "Plaka";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(106, 71);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(148, 20);
            this.tbPlaka.TabIndex = 4;
            // 
            // lblMotorNo
            // 
            this.lblMotorNo.AutoSize = true;
            this.lblMotorNo.Location = new System.Drawing.Point(12, 48);
            this.lblMotorNo.Name = "lblMotorNo";
            this.lblMotorNo.Size = new System.Drawing.Size(51, 13);
            this.lblMotorNo.TabIndex = 3;
            this.lblMotorNo.Text = "Motor No";
            // 
            // tbMotorNo
            // 
            this.tbMotorNo.Location = new System.Drawing.Point(106, 45);
            this.tbMotorNo.Name = "tbMotorNo";
            this.tbMotorNo.Size = new System.Drawing.Size(148, 20);
            this.tbMotorNo.TabIndex = 2;
            // 
            // lblSasiNo
            // 
            this.lblSasiNo.AutoSize = true;
            this.lblSasiNo.Location = new System.Drawing.Point(12, 22);
            this.lblSasiNo.Name = "lblSasiNo";
            this.lblSasiNo.Size = new System.Drawing.Size(44, 13);
            this.lblSasiNo.TabIndex = 1;
            this.lblSasiNo.Text = "Şasi No";
            // 
            // tbSasiNo
            // 
            this.tbSasiNo.Location = new System.Drawing.Point(106, 19);
            this.tbSasiNo.Name = "tbSasiNo";
            this.tbSasiNo.Size = new System.Drawing.Size(119, 20);
            this.tbSasiNo.TabIndex = 0;
            // 
            // gbKisiselBilgiler
            // 
            this.gbKisiselBilgiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiselBilgiler.Controls.Add(this.tbMusteriTCNo);
            this.gbKisiselBilgiler.Controls.Add(this.tbTelNo);
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
            this.gbKisiselBilgiler.Location = new System.Drawing.Point(11, 11);
            this.gbKisiselBilgiler.Name = "gbKisiselBilgiler";
            this.gbKisiselBilgiler.Size = new System.Drawing.Size(260, 236);
            this.gbKisiselBilgiler.TabIndex = 3;
            this.gbKisiselBilgiler.TabStop = false;
            this.gbKisiselBilgiler.Text = "Müşteri";
            // 
            // tbMusteriTCNo
            // 
            this.tbMusteriTCNo.Location = new System.Drawing.Point(105, 19);
            this.tbMusteriTCNo.Mask = "00000000000";
            this.tbMusteriTCNo.Name = "tbMusteriTCNo";
            this.tbMusteriTCNo.Size = new System.Drawing.Size(120, 20);
            this.tbMusteriTCNo.TabIndex = 17;
            // 
            // tbTelNo
            // 
            this.tbTelNo.Location = new System.Drawing.Point(106, 98);
            this.tbTelNo.Mask = "+\\9\\0(000) 000 0000";
            this.tbTelNo.Name = "tbTelNo";
            this.tbTelNo.Size = new System.Drawing.Size(150, 20);
            this.tbTelNo.TabIndex = 18;
            // 
            // btnTCNoDoldur
            // 
            this.btnTCNoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTCNoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCNoDoldur.Location = new System.Drawing.Point(228, 19);
            this.btnTCNoDoldur.Name = "btnTCNoDoldur";
            this.btnTCNoDoldur.Size = new System.Drawing.Size(25, 20);
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
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adı";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(106, 71);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(148, 20);
            this.tbSoyad.TabIndex = 12;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(106, 45);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(148, 20);
            this.tbAd.TabIndex = 11;
            // 
            // lblMusteriAdres
            // 
            this.lblMusteriAdres.AutoSize = true;
            this.lblMusteriAdres.Location = new System.Drawing.Point(6, 152);
            this.lblMusteriAdres.Name = "lblMusteriAdres";
            this.lblMusteriAdres.Size = new System.Drawing.Size(71, 13);
            this.lblMusteriAdres.TabIndex = 10;
            this.lblMusteriAdres.Text = "Müşteri Adres";
            // 
            // lblMusteriEPosta
            // 
            this.lblMusteriEPosta.AutoSize = true;
            this.lblMusteriEPosta.Location = new System.Drawing.Point(6, 126);
            this.lblMusteriEPosta.Name = "lblMusteriEPosta";
            this.lblMusteriEPosta.Size = new System.Drawing.Size(87, 13);
            this.lblMusteriEPosta.TabIndex = 9;
            this.lblMusteriEPosta.Text = "Müşteri E - Posta";
            // 
            // lblMusteriTelNo
            // 
            this.lblMusteriTelNo.AutoSize = true;
            this.lblMusteriTelNo.Location = new System.Drawing.Point(6, 100);
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
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(106, 149);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(148, 72);
            this.tbAdres.TabIndex = 6;
            // 
            // tbEPosta
            // 
            this.tbEPosta.Location = new System.Drawing.Point(106, 123);
            this.tbEPosta.Name = "tbEPosta";
            this.tbEPosta.Size = new System.Drawing.Size(148, 20);
            this.tbEPosta.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnFaturaHesapla);
            this.groupBox1.Controls.Add(this.dgParcalar);
            this.groupBox1.Controls.Add(this.btnParcaCikar);
            this.groupBox1.Controls.Add(this.btnParcaEkle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbFaturaTutari);
            this.groupBox1.Controls.Add(this.dtCikis);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbYapilanIslemler);
            this.groupBox1.Controls.Add(this.dtGiris);
            this.groupBox1.Controls.Add(this.btnIsEmriDoldur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbArackm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbGirisTalimat);
            this.groupBox1.Controls.Add(this.tbIsEmriNo);
            this.groupBox1.Location = new System.Drawing.Point(11, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 286);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri";
            // 
            // btnFaturaHesapla
            // 
            this.btnFaturaHesapla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFaturaHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaHesapla.Location = new System.Drawing.Point(495, 46);
            this.btnFaturaHesapla.Name = "btnFaturaHesapla";
            this.btnFaturaHesapla.Size = new System.Drawing.Size(25, 20);
            this.btnFaturaHesapla.TabIndex = 27;
            this.btnFaturaHesapla.Tag = "";
            this.btnFaturaHesapla.Text = "...";
            this.btnFaturaHesapla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFaturaHesapla.UseVisualStyleBackColor = true;
            this.btnFaturaHesapla.Click += new System.EventHandler(this.btnFaturaHesapla_Click);
            // 
            // dgParcalar
            // 
            this.dgParcalar.AllowUserToAddRows = false;
            this.dgParcalar.AllowUserToDeleteRows = false;
            this.dgParcalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParcalar.Location = new System.Drawing.Point(106, 176);
            this.dgParcalar.MultiSelect = false;
            this.dgParcalar.Name = "dgParcalar";
            this.dgParcalar.ReadOnly = true;
            this.dgParcalar.RowHeadersVisible = false;
            this.dgParcalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParcalar.Size = new System.Drawing.Size(335, 104);
            this.dgParcalar.TabIndex = 26;
            // 
            // btnParcaCikar
            // 
            this.btnParcaCikar.Location = new System.Drawing.Point(447, 222);
            this.btnParcaCikar.Name = "btnParcaCikar";
            this.btnParcaCikar.Size = new System.Drawing.Size(75, 23);
            this.btnParcaCikar.TabIndex = 25;
            this.btnParcaCikar.Text = "Parça Çıkar";
            this.btnParcaCikar.UseVisualStyleBackColor = true;
            this.btnParcaCikar.Click += new System.EventHandler(this.btnParcaCikar_Click);
            // 
            // btnParcaEkle
            // 
            this.btnParcaEkle.Location = new System.Drawing.Point(447, 193);
            this.btnParcaEkle.Name = "btnParcaEkle";
            this.btnParcaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnParcaEkle.TabIndex = 24;
            this.btnParcaEkle.Text = "Parça Ekle";
            this.btnParcaEkle.UseVisualStyleBackColor = true;
            this.btnParcaEkle.Click += new System.EventHandler(this.btnParcaEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Parça Durumu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fatura Tutarı";
            // 
            // tbFaturaTutari
            // 
            this.tbFaturaTutari.Location = new System.Drawing.Point(372, 46);
            this.tbFaturaTutari.Name = "tbFaturaTutari";
            this.tbFaturaTutari.Size = new System.Drawing.Size(120, 20);
            this.tbFaturaTutari.TabIndex = 20;
            // 
            // dtCikis
            // 
            this.dtCikis.Location = new System.Drawing.Point(372, 71);
            this.dtCikis.Margin = new System.Windows.Forms.Padding(2);
            this.dtCikis.Name = "dtCikis";
            this.dtCikis.Size = new System.Drawing.Size(148, 20);
            this.dtCikis.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Çıkış Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Yapılan İşlemler";
            // 
            // tbYapilanIslemler
            // 
            this.tbYapilanIslemler.Location = new System.Drawing.Point(372, 97);
            this.tbYapilanIslemler.Multiline = true;
            this.tbYapilanIslemler.Name = "tbYapilanIslemler";
            this.tbYapilanIslemler.Size = new System.Drawing.Size(148, 72);
            this.tbYapilanIslemler.TabIndex = 16;
            // 
            // dtGiris
            // 
            this.dtGiris.Location = new System.Drawing.Point(106, 73);
            this.dtGiris.Margin = new System.Windows.Forms.Padding(2);
            this.dtGiris.Name = "dtGiris";
            this.dtGiris.Size = new System.Drawing.Size(148, 20);
            this.dtGiris.TabIndex = 15;
            // 
            // btnIsEmriDoldur
            // 
            this.btnIsEmriDoldur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIsEmriDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsEmriDoldur.Location = new System.Drawing.Point(228, 19);
            this.btnIsEmriDoldur.Name = "btnIsEmriDoldur";
            this.btnIsEmriDoldur.Size = new System.Drawing.Size(25, 20);
            this.btnIsEmriDoldur.TabIndex = 4;
            this.btnIsEmriDoldur.Tag = "";
            this.btnIsEmriDoldur.Text = "...";
            this.btnIsEmriDoldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIsEmriDoldur.UseVisualStyleBackColor = true;
            this.btnIsEmriDoldur.Click += new System.EventHandler(this.btnIsEmriDoldur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Araç Km";
            // 
            // tbArackm
            // 
            this.tbArackm.Location = new System.Drawing.Point(106, 45);
            this.tbArackm.Name = "tbArackm";
            this.tbArackm.Size = new System.Drawing.Size(148, 20);
            this.tbArackm.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giriş Talimatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "İş Emri Numarası";
            // 
            // tbGirisTalimat
            // 
            this.tbGirisTalimat.Location = new System.Drawing.Point(106, 97);
            this.tbGirisTalimat.Multiline = true;
            this.tbGirisTalimat.Name = "tbGirisTalimat";
            this.tbGirisTalimat.Size = new System.Drawing.Size(148, 72);
            this.tbGirisTalimat.TabIndex = 6;
            // 
            // tbIsEmriNo
            // 
            this.tbIsEmriNo.Location = new System.Drawing.Point(106, 19);
            this.tbIsEmriNo.Name = "tbIsEmriNo";
            this.tbIsEmriNo.Size = new System.Drawing.Size(117, 20);
            this.tbIsEmriNo.TabIndex = 3;
            // 
            // btnIsEmriAc
            // 
            this.btnIsEmriAc.Location = new System.Drawing.Point(11, 544);
            this.btnIsEmriAc.Margin = new System.Windows.Forms.Padding(2);
            this.btnIsEmriAc.Name = "btnIsEmriAc";
            this.btnIsEmriAc.Size = new System.Drawing.Size(82, 28);
            this.btnIsEmriAc.TabIndex = 16;
            this.btnIsEmriAc.Text = "İş Emri Oluştur";
            this.btnIsEmriAc.UseVisualStyleBackColor = true;
            this.btnIsEmriAc.Click += new System.EventHandler(this.btnIsEmriAc_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(117, 544);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 28);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "İş Emri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(239, 544);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(102, 28);
            this.btnRapor.TabIndex = 18;
            this.btnRapor.Text = "İş Emri Raporu";
            this.btnRapor.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(401, 544);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(66, 28);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(472, 544);
            this.btnCik.Margin = new System.Windows.Forms.Padding(2);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(66, 28);
            this.btnCik.TabIndex = 20;
            this.btnCik.Text = "Çık";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // frmServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 583);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnIsEmriAc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAracBilgileri);
            this.Controls.Add(this.gbKisiselBilgiler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmServis";
            this.Text = "frmServis";
            this.gbAracBilgileri.ResumeLayout(false);
            this.gbAracBilgileri.PerformLayout();
            this.gbKisiselBilgiler.ResumeLayout(false);
            this.gbKisiselBilgiler.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParcalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.Button btnSasiNoDoldur;
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
        private System.Windows.Forms.GroupBox gbKisiselBilgiler;
        private System.Windows.Forms.Button btnTCNoDoldur;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFaturaTutari;
        private System.Windows.Forms.DateTimePicker dtCikis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbYapilanIslemler;
        private System.Windows.Forms.DateTimePicker dtGiris;
        private System.Windows.Forms.Button btnIsEmriDoldur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArackm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGirisTalimat;
        private System.Windows.Forms.TextBox tbIsEmriNo;
        private System.Windows.Forms.Button btnIsEmriAc;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRenk;
        private System.Windows.Forms.MaskedTextBox tbMusteriTCNo;
        private System.Windows.Forms.MaskedTextBox tbTelNo;
        private System.Windows.Forms.Button btnParcaCikar;
        private System.Windows.Forms.Button btnParcaEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgParcalar;
        private System.Windows.Forms.Button btnFaturaHesapla;
    }
}