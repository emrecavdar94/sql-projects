namespace SQL_Project
{
    partial class frmYedek
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konum";
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(363, 54);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(33, 23);
            this.btnDosyaSec.TabIndex = 2;
            this.btnDosyaSec.Text = "...";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            // 
            // btnYedekle
            // 
            this.btnYedekle.Location = new System.Drawing.Point(30, 107);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(75, 44);
            this.btnYedekle.TabIndex = 3;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Location = new System.Drawing.Point(156, 107);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(117, 44);
            this.btnGeriYukle.TabIndex = 4;
            this.btnGeriYukle.Text = "Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = true;
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(321, 107);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(75, 44);
            this.btnCik.TabIndex = 5;
            this.btnCik.Text = "Çık";
            this.btnCik.UseVisualStyleBackColor = true;
            // 
            // frmYedek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmYedek";
            this.Text = "frmYedek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnGeriYukle;
        private System.Windows.Forms.Button btnCik;
    }
}