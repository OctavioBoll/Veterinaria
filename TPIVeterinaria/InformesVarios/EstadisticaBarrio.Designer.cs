namespace TPIVeterinaria.InformesVarios
{
    partial class EstadisticaBarrio
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
            this.rptEstadisticaEmpXBarrio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rptEstadisticaEmpXBarrio
            // 
            this.rptEstadisticaEmpXBarrio.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformesVarios.EstadisticaClienesXBarrio.rdlc";
            this.rptEstadisticaEmpXBarrio.Location = new System.Drawing.Point(-1, 47);
            this.rptEstadisticaEmpXBarrio.Name = "rptEstadisticaEmpXBarrio";
            this.rptEstadisticaEmpXBarrio.ServerReport.BearerToken = null;
            this.rptEstadisticaEmpXBarrio.Size = new System.Drawing.Size(804, 404);
            this.rptEstadisticaEmpXBarrio.TabIndex = 0;
            this.rptEstadisticaEmpXBarrio.Load += new System.EventHandler(this.rptEstadisticaClientXBarrio_Load);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(320, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Estadistica de barrios de empleados";
            // 
            // EstadisticaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rptEstadisticaEmpXBarrio);
            this.Name = "EstadisticaBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica de cantidad de empleados por Barrio";
            this.Load += new System.EventHandler(this.EstadisticaBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptEstadisticaEmpXBarrio;
        private System.Windows.Forms.Label lblTitulo;
    }
}