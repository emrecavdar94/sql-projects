namespace SQL_Project
{
    partial class frmArac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArac));
            this.gbAracBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRenk = new System.Windows.Forms.TextBox();
            this.tbPlaka = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblMotorNo = new System.Windows.Forms.Label();
            this.tbMotorNo = new System.Windows.Forms.TextBox();
            this.lblSasiNo = new System.Windows.Forms.Label();
            this.tbSasiNo = new System.Windows.Forms.TextBox();
            this.dgArabalar = new System.Windows.Forms.DataGridView();
            this.btnSasiNoDoldur = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.gbAracBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArabalar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAracBilgileri.Controls.Add(this.btnSasiNoDoldur);
            this.gbAracBilgileri.Controls.Add(this.label1);
            this.gbAracBilgileri.Controls.Add(this.tbRenk);
            this.gbAracBilgileri.Controls.Add(this.tbPlaka);
            this.gbAracBilgileri.Controls.Add(this.lblModel);
            this.gbAracBilgileri.Controls.Add(this.tbModel);
            this.gbAracBilgileri.Controls.Add(this.lblMarka);
            this.gbAracBilgileri.Controls.Add(this.tbMarka);
            this.gbAracBilgileri.Controls.Add(this.lblPlaka);
            this.gbAracBilgileri.Controls.Add(this.lblMotorNo);
            this.gbAracBilgileri.Controls.Add(this.tbMotorNo);
            this.gbAracBilgileri.Controls.Add(this.lblSasiNo);
            this.gbAracBilgileri.Controls.Add(this.tbSasiNo);
            this.gbAracBilgileri.Location = new System.Drawing.Point(365, 12);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Size = new System.Drawing.Size(233, 183);
            this.gbAracBilgileri.TabIndex = 0;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Araç Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Renk";
            // 
            // tbRenk
            // 
            this.tbRenk.Location = new System.Drawing.Point(72, 147);
            this.tbRenk.Name = "tbRenk";
            this.tbRenk.Size = new System.Drawing.Size(148, 20);
            this.tbRenk.TabIndex = 11;
            // 
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(72, 73);
            this.tbPlaka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(148, 20);
            this.tbPlaka.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(493, 200);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 26);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle/Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            this.tbModel.Location = new System.Drawing.Point(72, 123);
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
            this.tbMarka.Location = new System.Drawing.Point(72, 97);
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
            this.tbMotorNo.Location = new System.Drawing.Point(72, 45);
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
            this.tbSasiNo.Location = new System.Drawing.Point(72, 19);
            this.tbSasiNo.Name = "tbSasiNo";
            this.tbSasiNo.Size = new System.Drawing.Size(117, 20);
            this.tbSasiNo.TabIndex = 0;
            // 
            // dgArabalar
            // 
            this.dgArabalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArabalar.Location = new System.Drawing.Point(13, 12);
            this.dgArabalar.MultiSelect = false;
            this.dgArabalar.Name = "dgArabalar";
            this.dgArabalar.ReadOnly = true;
            this.dgArabalar.RowHeadersVisible = false;
            this.dgArabalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArabalar.Size = new System.Drawing.Size(346, 214);
            this.dgArabalar.TabIndex = 2;
            this.dgArabalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArabalar_CellDoubleClick);
            // 
            // btnSasiNoDoldur
            // 
            this.btnSasiNoDoldur.Location = new System.Drawing.Point(195, 17);
            this.btnSasiNoDoldur.Name = "btnSasiNoDoldur";
            this.btnSasiNoDoldur.Size = new System.Drawing.Size(25, 23);
            this.btnSasiNoDoldur.TabIndex = 3;
            this.btnSasiNoDoldur.Text = "...";
            this.btnSasiNoDoldur.UseVisualStyleBackColor = true;
            this.btnSasiNoDoldur.Click += new System.EventHandler(this.btnSasiNoDoldur_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(366, 202);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 232);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgArabalar);
            this.Controls.Add(this.gbAracBilgileri);
            this.Controls.Add(this.btnEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç";
            this.Load += new System.EventHandler(this.frmArac_Load);
            this.gbAracBilgileri.ResumeLayout(false);
            this.gbAracBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArabalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.TextBox tbSasiNo;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblMotorNo;
        private System.Windows.Forms.TextBox tbMotorNo;
        private System.Windows.Forms.Label lblSasiNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox tbPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRenk;
        private System.Windows.Forms.Button btnSasiNoDoldur;
        private System.Windows.Forms.DataGridView dgArabalar;
        private System.Windows.Forms.Button btnSil;
    }
}