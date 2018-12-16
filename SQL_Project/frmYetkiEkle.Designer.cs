namespace SQL_Project
{
    partial class frmYetkiEkle
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
            this.gbRaporMusteriler = new System.Windows.Forms.GroupBox();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.lblMusteriTCNo = new System.Windows.Forms.Label();
            this.cbYetki = new System.Windows.Forms.ComboBox();
            this.gbRaporMusteriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRaporMusteriler
            // 
            this.gbRaporMusteriler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbRaporMusteriler.Controls.Add(this.cbYetki);
            this.gbRaporMusteriler.Controls.Add(this.btnMusteriGetir);
            this.gbRaporMusteriler.Controls.Add(this.lblMusteriTCNo);
            this.gbRaporMusteriler.Location = new System.Drawing.Point(13, 13);
            this.gbRaporMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.gbRaporMusteriler.Name = "gbRaporMusteriler";
            this.gbRaporMusteriler.Padding = new System.Windows.Forms.Padding(4);
            this.gbRaporMusteriler.Size = new System.Drawing.Size(347, 290);
            this.gbRaporMusteriler.TabIndex = 4;
            this.gbRaporMusteriler.TabStop = false;
            this.gbRaporMusteriler.Text = "Müşteri";
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(131, 202);
            this.btnMusteriGetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(85, 57);
            this.btnMusteriGetir.TabIndex = 15;
            this.btnMusteriGetir.Text = "Yetki Ekle";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // lblMusteriTCNo
            // 
            this.lblMusteriTCNo.AutoSize = true;
            this.lblMusteriTCNo.Location = new System.Drawing.Point(63, 76);
            this.lblMusteriTCNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriTCNo.Name = "lblMusteriTCNo";
            this.lblMusteriTCNo.Size = new System.Drawing.Size(39, 17);
            this.lblMusteriTCNo.TabIndex = 7;
            this.lblMusteriTCNo.Text = "Yetki";
            // 
            // cbYetki
            // 
            this.cbYetki.FormattingEnabled = true;
            this.cbYetki.Location = new System.Drawing.Point(131, 73);
            this.cbYetki.Name = "cbYetki";
            this.cbYetki.Size = new System.Drawing.Size(121, 24);
            this.cbYetki.TabIndex = 16;
            // 
            // frmYetkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 328);
            this.Controls.Add(this.gbRaporMusteriler);
            this.Name = "frmYetkiEkle";
            this.Text = "frmYetkiEkle";
            this.Load += new System.EventHandler(this.frmYetkiEkle_Load);
            this.gbRaporMusteriler.ResumeLayout(false);
            this.gbRaporMusteriler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRaporMusteriler;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.Label lblMusteriTCNo;
        private System.Windows.Forms.ComboBox cbYetki;
    }
}