namespace TPIVeterinaria.InformeClienteMascotas
{
    partial class InformeMascotas
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
            this.rptMascotas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechainicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblinformar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rptMascotas
            // 
            this.rptMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptMascotas.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeClienteMascotas.ReportMascotas.rdlc";
            this.rptMascotas.Location = new System.Drawing.Point(12, 104);
            this.rptMascotas.Name = "rptMascotas";
            this.rptMascotas.ServerReport.BearerToken = null;
            this.rptMascotas.Size = new System.Drawing.Size(776, 358);
            this.rptMascotas.TabIndex = 0;
            this.rptMascotas.Load += new System.EventHandler(this.rptMascotas_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = " Fecha Inicial:";
            // 
            // txtFechainicio
            // 
            this.txtFechainicio.Location = new System.Drawing.Point(109, 71);
            this.txtFechainicio.Mask = "00/00/0000";
            this.txtFechainicio.Name = "txtFechainicio";
            this.txtFechainicio.Size = new System.Drawing.Size(75, 20);
            this.txtFechainicio.TabIndex = 2;
            this.txtFechainicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(316, 71);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(75, 20);
            this.txtFechaFin.TabIndex = 4;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = " Fecha Final:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(419, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de Mascotas";
            // 
            // lblinformar
            // 
            this.lblinformar.AutoSize = true;
            this.lblinformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblinformar.Location = new System.Drawing.Point(500, 74);
            this.lblinformar.Name = "lblinformar";
            this.lblinformar.Size = new System.Drawing.Size(227, 13);
            this.lblinformar.TabIndex = 7;
            this.lblinformar.Text = "*Presionar Actualizar para ver el nuevo informe";
            // 
            // InformeMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.lblinformar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechainicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptMascotas);
            this.Name = "InformeMascotas";
            this.Text = "InformeMascotas";
            this.Load += new System.EventHandler(this.InformeMascotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptMascotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFechainicio;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblinformar;
    }
}