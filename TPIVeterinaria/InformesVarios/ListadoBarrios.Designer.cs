namespace TPIVeterinaria.InformesVarios
{
    partial class ListadoBarrios
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
            this.rpvBarrios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblinformarActualizar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rpvBarrios
            // 
            this.rpvBarrios.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformesVarios.ListBarrios.rdlc";
            this.rpvBarrios.Location = new System.Drawing.Point(-2, 87);
            this.rpvBarrios.Name = "rpvBarrios";
            this.rpvBarrios.ServerReport.BearerToken = null;
            this.rpvBarrios.Size = new System.Drawing.Size(802, 365);
            this.rpvBarrios.TabIndex = 0;
            this.rpvBarrios.Load += new System.EventHandler(this.rpvBarrios_Load);
            // 
            // lblinformarActualizar
            // 
            this.lblinformarActualizar.AutoSize = true;
            this.lblinformarActualizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblinformarActualizar.Location = new System.Drawing.Point(408, 60);
            this.lblinformarActualizar.Name = "lblinformarActualizar";
            this.lblinformarActualizar.Size = new System.Drawing.Size(215, 13);
            this.lblinformarActualizar.TabIndex = 15;
            this.lblinformarActualizar.Text = "*Cuando aprete Buscar Actualice el informe.";
            this.lblinformarActualizar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(304, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(340, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 20);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Listado de Diagnosticos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por nombre:";
            // 
            // ListadoBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblinformarActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvBarrios);
            this.Name = "ListadoBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Barrios";
            this.Load += new System.EventHandler(this.ListadoBarrios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBarrios;
        private System.Windows.Forms.Label lblinformarActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}