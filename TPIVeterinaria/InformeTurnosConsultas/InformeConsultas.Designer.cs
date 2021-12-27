namespace TPIVeterinaria.InformeTurnosConsultas
{
    partial class InformeConsultas
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
            this.rptListadoConsultas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptListadoConsultas
            // 
            this.rptListadoConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptListadoConsultas.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeTurnosConsultas.InformeConsultas.rdlc";
            this.rptListadoConsultas.Location = new System.Drawing.Point(0, 0);
            this.rptListadoConsultas.Name = "rptListadoConsultas";
            this.rptListadoConsultas.ServerReport.BearerToken = null;
            this.rptListadoConsultas.Size = new System.Drawing.Size(800, 450);
            this.rptListadoConsultas.TabIndex = 0;
            this.rptListadoConsultas.Load += new System.EventHandler(this.rptListadoConsultas_Load);
            // 
            // InformeConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptListadoConsultas);
            this.Name = "InformeConsultas";
            this.Text = "InformeConsultas";
            this.Load += new System.EventHandler(this.InformeConsultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptListadoConsultas;
    }
}