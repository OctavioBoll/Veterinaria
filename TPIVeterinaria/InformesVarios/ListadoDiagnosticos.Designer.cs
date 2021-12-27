namespace TPIVeterinaria.Informes_Estadisticas.InformeVarios
{
    partial class ListadoDiagnosticos
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
            this.rptDiagnosticos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblinformarActualizar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rptDiagnosticos
            // 
            this.rptDiagnosticos.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformesVarios.ListDiagnostico.rdlc";
            this.rptDiagnosticos.Location = new System.Drawing.Point(0, 73);
            this.rptDiagnosticos.Name = "rptDiagnosticos";
            this.rptDiagnosticos.ServerReport.BearerToken = null;
            this.rptDiagnosticos.Size = new System.Drawing.Size(800, 377);
            this.rptDiagnosticos.TabIndex = 0;
            this.rptDiagnosticos.Load += new System.EventHandler(this.rptDiagnosticos_Load);
            // 
            // lblinformarActualizar
            // 
            this.lblinformarActualizar.AutoSize = true;
            this.lblinformarActualizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblinformarActualizar.Location = new System.Drawing.Point(390, 54);
            this.lblinformarActualizar.Name = "lblinformarActualizar";
            this.lblinformarActualizar.Size = new System.Drawing.Size(215, 13);
            this.lblinformarActualizar.TabIndex = 10;
            this.lblinformarActualizar.Text = "*Cuando aprete Buscar Actualice el informe.";
            this.lblinformarActualizar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(286, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(322, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 20);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Listado de Diagnosticos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por nombre:";
            // 
            // ListadoDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblinformarActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptDiagnosticos);
            this.Name = "ListadoDiagnosticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listdado de Diagnosticos";
            this.Load += new System.EventHandler(this.Informe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptDiagnosticos;
        private System.Windows.Forms.Label lblinformarActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}