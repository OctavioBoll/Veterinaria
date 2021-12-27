namespace TPIVeterinaria.InformeClienteMascotas
{
    partial class InformeTurnos
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
            this.rptListadoTurnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptListadoTurnos
            // 
            this.rptListadoTurnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptListadoTurnos.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeTurnosConsultas.InformeTurnos.rdlc";
            this.rptListadoTurnos.Location = new System.Drawing.Point(0, 0);
            this.rptListadoTurnos.Name = "rptListadoTurnos";
            this.rptListadoTurnos.ServerReport.BearerToken = null;
            this.rptListadoTurnos.Size = new System.Drawing.Size(800, 450);
            this.rptListadoTurnos.TabIndex = 0;
            this.rptListadoTurnos.Load += new System.EventHandler(this.rptTurnos_Load);
            // 
            // InformeTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptListadoTurnos);
            this.Name = "InformeTurnos";
            this.Text = "Informe de Turnos";
            this.Load += new System.EventHandler(this.InformeTurnos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptListadoTurnos;
    }
}