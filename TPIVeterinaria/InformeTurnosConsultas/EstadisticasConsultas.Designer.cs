namespace TPIVeterinaria.InformeTurnosConsultas
{
    partial class EstadisticasConsultas
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
            this.rptEstadisticasConsultas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptEstadisticasConsultas
            // 
            this.rptEstadisticasConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptEstadisticasConsultas.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeTurnosConsultas.EstadisticasConsultas.rdlc";
            this.rptEstadisticasConsultas.Location = new System.Drawing.Point(0, 0);
            this.rptEstadisticasConsultas.Name = "rptEstadisticasConsultas";
            this.rptEstadisticasConsultas.ServerReport.BearerToken = null;
            this.rptEstadisticasConsultas.Size = new System.Drawing.Size(800, 450);
            this.rptEstadisticasConsultas.TabIndex = 0;
            this.rptEstadisticasConsultas.Load += new System.EventHandler(this.rptEstadisticasConsultas_Load);
            // 
            // EstadisticasConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptEstadisticasConsultas);
            this.Name = "EstadisticasConsultas";
            this.Text = "Estadisticas de Consultas";
            this.Load += new System.EventHandler(this.EstadisticasConsultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptEstadisticasConsultas;
    }
}