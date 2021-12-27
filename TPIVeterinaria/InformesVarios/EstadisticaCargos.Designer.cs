namespace TPIVeterinaria.InformesVarios
{
    partial class EstadisticaCargos
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
            this.rptCargosEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rptCargosEmpleados
            // 
            this.rptCargosEmpleados.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformesVarios.EstadisticaCargosDeEmpleados.rdlc";
            this.rptCargosEmpleados.Location = new System.Drawing.Point(1, 50);
            this.rptCargosEmpleados.Name = "rptCargosEmpleados";
            this.rptCargosEmpleados.ServerReport.BearerToken = null;
            this.rptCargosEmpleados.Size = new System.Drawing.Size(800, 403);
            this.rptCargosEmpleados.TabIndex = 0;
            this.rptCargosEmpleados.Load += new System.EventHandler(this.rptCargosEmpleados_Load);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(274, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Estadistica de cargos de empleados";
            // 
            // EstadisticaCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rptCargosEmpleados);
            this.Name = "EstadisticaCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica cargos de empleados";
            this.Load += new System.EventHandler(this.EstadisticaCargos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCargosEmpleados;
        private System.Windows.Forms.Label lblTitulo;
    }
}