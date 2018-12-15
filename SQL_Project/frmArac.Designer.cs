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
            this.tbSasiNo = new System.Windows.Forms.TextBox();
            this.lblSasiNo = new System.Windows.Forms.Label();
            this.tbMotorNo = new System.Windows.Forms.TextBox();
            this.lblMotorNo = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.gbAracBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAracBilgileri
            // 
            this.gbAracBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.gbAracBilgileri.Location = new System.Drawing.Point(0, 0);
            this.gbAracBilgileri.Name = "gbAracBilgileri";
            this.gbAracBilgileri.Size = new System.Drawing.Size(260, 153);
            this.gbAracBilgileri.TabIndex = 0;
            this.gbAracBilgileri.TabStop = false;
            this.gbAracBilgileri.Text = "Araç Bilgileri";
            // 
            // tbSasiNo
            // 
            this.tbSasiNo.Location = new System.Drawing.Point(106, 19);
            this.tbSasiNo.Name = "tbSasiNo";
            this.tbSasiNo.Size = new System.Drawing.Size(148, 20);
            this.tbSasiNo.TabIndex = 0;
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
            // tbMotorNo
            // 
            this.tbMotorNo.Location = new System.Drawing.Point(106, 45);
            this.tbMotorNo.Name = "tbMotorNo";
            this.tbMotorNo.Size = new System.Drawing.Size(148, 20);
            this.tbMotorNo.TabIndex = 2;
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
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(106, 71);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(148, 20);
            this.tbPlaka.TabIndex = 4;
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
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(106, 97);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(148, 20);
            this.tbMarka.TabIndex = 6;
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
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(106, 123);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(148, 20);
            this.tbModel.TabIndex = 8;
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
            // frmArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 256);
            this.Controls.Add(this.gbAracBilgileri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç";
            this.gbAracBilgileri.ResumeLayout(false);
            this.gbAracBilgileri.PerformLayout();
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
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.Label lblMotorNo;
        private System.Windows.Forms.TextBox tbMotorNo;
        private System.Windows.Forms.Label lblSasiNo;
    }
}