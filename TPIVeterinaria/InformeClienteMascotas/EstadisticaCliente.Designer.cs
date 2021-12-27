namespace TPIVeterinaria.InformeClienteMascotas
{
    partial class EstadisticaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.rptEstadisticaCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadistica Clientes";
            // 
            // rptEstadisticaCliente
            // 
            this.rptEstadisticaCliente.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeClienteMascotas.EstadisticasCliente.rdlc";
            this.rptEstadisticaCliente.Location = new System.Drawing.Point(12, 61);
            this.rptEstadisticaCliente.Name = "rptEstadisticaCliente";
            this.rptEstadisticaCliente.ServerReport.BearerToken = null;
            this.rptEstadisticaCliente.Size = new System.Drawing.Size(776, 311);
            this.rptEstadisticaCliente.TabIndex = 1;
            this.rptEstadisticaCliente.Load += new System.EventHandler(this.rptEstadisticaCliente_Load);
            // 
            // EstadisticaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.rptEstadisticaCliente);
            this.Controls.Add(this.label1);
            this.Name = "EstadisticaCliente";
            this.Text = "EstadisticaCliente";
            this.Load += new System.EventHandler(this.EstadisticaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rptEstadisticaCliente;
    }
}