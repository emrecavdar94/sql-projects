namespace SQL_Project
{
    partial class frmYedekleGeriYukle
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
            this.btnYedekle = new System.Windows.Forms.Button();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKonum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYedekle
            // 
            this.btnYedekle.Location = new System.Drawing.Point(55, 47);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(96, 43);
            this.btnYedekle.TabIndex = 0;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Location = new System.Drawing.Point(178, 47);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(92, 43);
            this.btnGeriYukle.TabIndex = 1;
            this.btnGeriYukle.Text = "Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = true;
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(276, 19);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaSec.TabIndex = 2;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yedek Konumu";
            // 
            // tbKonum
            // 
            this.tbKonum.Location = new System.Drawing.Point(9, 21);
            this.tbKonum.Name = "tbKonum";
            this.tbKonum.Size = new System.Drawing.Size(261, 20);
            this.tbKonum.TabIndex = 4;
            // 
            // frmYedekleGeriYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 99);
            this.Controls.Add(this.tbKonum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.btnYedekle);
            this.Name = "frmYedekleGeriYukle";
            this.Text = "frmYedekleGeriYukle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnGeriYukle;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKonum;
    }
}