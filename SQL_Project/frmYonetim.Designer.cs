namespace SQL_Project
{
    partial class frmYonetim
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.gbAracBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAracBilgileri.Controls.Add(this.button5);
            this.gbAracBilgileri.Controls.Add(this.button4);
            this.gbAracBilgileri.Controls.Add(this.button3);
            this.gbAracBilgileri.Controls.Add(this.button2);
            this.gbAracBilgileri.Controls.Add(this.btnPersoneller);
            this.gbAracBilgileri.Location = new System.Drawing.Point(17, 11);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Size = new System.Drawing.Size(422, 286);
            this.gbAracBilgileri.TabIndex = 3;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Yönetim Paneli";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(286, 120);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sistem Sabitleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 120);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Yedek/Geri Yükle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Müşteriler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Araçlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(22, 28);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(92, 50);
            this.btnPersoneller.TabIndex = 0;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // frmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbAracBilgileri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmYonetim";
            this.Text = "frmYonetim";
            this.gbAracBilgileri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracBilgileri;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPersoneller;
    }
}