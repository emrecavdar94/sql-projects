namespace SQL_Project
{
    partial class frmRaporRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporRapor));
            this.disariaktar = new SQL_Project.disariaktar();
            this.crDisariAktar = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crDisariAktar1 = new SQL_Project.crDisariAktar();
            this.SuspendLayout();
            // 
            // crDisariAktar
            // 
            this.crDisariAktar.ActiveViewIndex = 0;
            this.crDisariAktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crDisariAktar.Cursor = System.Windows.Forms.Cursors.Default;
            this.crDisariAktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crDisariAktar.Location = new System.Drawing.Point(0, 0);
            this.crDisariAktar.Name = "crDisariAktar";
            this.crDisariAktar.ReportSource = this.crDisariAktar1;
            this.crDisariAktar.Size = new System.Drawing.Size(624, 462);
            this.crDisariAktar.TabIndex = 0;
            // 
            // frmRaporRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 462);
            this.Controls.Add(this.crDisariAktar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRaporRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIŞA AKTAR";
            this.ResumeLayout(false);

        }

        #endregion
        private disariaktar disariaktar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crDisariAktar;
        private crDisariAktar crDisariAktar1;
    }
}