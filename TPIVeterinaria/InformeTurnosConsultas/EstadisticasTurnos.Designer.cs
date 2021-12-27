namespace TPIVeterinaria.InformeTurnosConsultas
{
    partial class EstadisticasTurnos
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
            this.rptEstadisticasTurnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptEstadisticasTurnos
            // 
            this.rptEstadisticasTurnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptEstadisticasTurnos.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeTurnosConsultas.EstadisticasTurnos.rdlc";
            this.rptEstadisticasTurnos.Location = new System.Drawing.Point(0, 0);
            this.rptEstadisticasTurnos.Name = "rptEstadisticasTurnos";
            this.rptEstadisticasTurnos.ServerReport.BearerToken = null;
            this.rptEstadisticasTurnos.Size = new System.Drawing.Size(800, 450);
            this.rptEstadisticasTurnos.TabIndex = 0;
            this.rptEstadisticasTurnos.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EstadisticasTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptEstadisticasTurnos);
            this.Name = "EstadisticasTurnos";
            this.Text = "Estadisticas de Turnos";
            this.Load += new System.EventHandler(this.EstadisticasTurnos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptEstadisticasTurnos;
    }
}