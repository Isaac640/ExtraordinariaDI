namespace ProyectoUnicineIsaac
{
    partial class VisorInforme
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
            this.rpvInforme = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvInforme
            // 
            this.rpvInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvInforme.LocalReport.ReportEmbeddedResource = "ProyectoUnicineIsaac.Reports.rptPeliculas.rdlc";
            this.rpvInforme.Location = new System.Drawing.Point(0, 0);
            this.rpvInforme.Name = "rpvInforme";
            this.rpvInforme.ServerReport.BearerToken = null;
            this.rpvInforme.Size = new System.Drawing.Size(639, 403);
            this.rpvInforme.TabIndex = 0;
            // 
            // VisorInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 403);
            this.Controls.Add(this.rpvInforme);
            this.Name = "VisorInforme";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.VisorInforme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvInforme;
    }
}