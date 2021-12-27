namespace TPIVeterinaria
{
    partial class ModificarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarConsulta));
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNroHistCLI = new System.Windows.Forms.TextBox();
            this.txtNroConsulta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskNrodoc = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroHistClinica = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCancelar
            // 
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(176, 326);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(97, 36);
            this.bntCancelar.TabIndex = 21;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(290, 326);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 36);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(176, 268);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(135, 21);
            this.cmbMotivo.TabIndex = 17;
            // 
            // mskHora
            // 
            this.mskHora.Location = new System.Drawing.Point(176, 235);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(100, 20);
            this.mskHora.TabIndex = 15;
            this.mskHora.Text = "0000";
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(176, 203);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 13;
            this.dtpFecha.Value = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            // 
            // txtNroHistCLI
            // 
            this.txtNroHistCLI.Location = new System.Drawing.Point(176, 65);
            this.txtNroHistCLI.Name = "txtNroHistCLI";
            this.txtNroHistCLI.Size = new System.Drawing.Size(147, 20);
            this.txtNroHistCLI.TabIndex = 11;
            // 
            // txtNroConsulta
            // 
            this.txtNroConsulta.AutoSize = true;
            this.txtNroConsulta.Enabled = false;
            this.txtNroConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroConsulta.Location = new System.Drawing.Point(173, 29);
            this.txtNroConsulta.Name = "txtNroConsulta";
            this.txtNroConsulta.Size = new System.Drawing.Size(75, 15);
            this.txtNroConsulta.TabIndex = 23;
            this.txtNroConsulta.Text = "NroConsulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Empleado :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mskNrodoc);
            this.panel1.Controls.Add(this.cmbTipoDoc);
            this.panel1.Controls.Add(this.lblTipoDocumento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(81, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 69);
            this.panel1.TabIndex = 20;
            // 
            // mskNrodoc
            // 
            this.mskNrodoc.Location = new System.Drawing.Point(145, 36);
            this.mskNrodoc.Mask = "99999999";
            this.mskNrodoc.Name = "mskNrodoc";
            this.mskNrodoc.Size = new System.Drawing.Size(84, 20);
            this.mskNrodoc.TabIndex = 3;
            this.mskNrodoc.ValidatingType = typeof(int);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(146, 10);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(135, 21);
            this.cmbTipoDoc.TabIndex = 2;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(3, 10);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(136, 15);
            this.lblTipoDocumento.TabIndex = 2;
            this.lblTipoDocumento.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro Documento :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Motivo de :\r\nConsulta";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(118, 236);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(46, 15);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = "Hora :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(110, 207);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 15);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha :";
            // 
            // lblNroHistClinica
            // 
            this.lblNroHistClinica.AutoSize = true;
            this.lblNroHistClinica.BackColor = System.Drawing.Color.Transparent;
            this.lblNroHistClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroHistClinica.Location = new System.Drawing.Point(45, 66);
            this.lblNroHistClinica.Name = "lblNroHistClinica";
            this.lblNroHistClinica.Size = new System.Drawing.Size(119, 15);
            this.lblNroHistClinica.TabIndex = 12;
            this.lblNroHistClinica.Text = "Nro Hist. Clinica :\r\n";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.BackColor = System.Drawing.Color.Transparent;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(126, 29);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(38, 15);
            this.lblNro.TabIndex = 10;
            this.lblNro.Text = "Nro :";
            // 
            // ModificarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 375);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNroHistCLI);
            this.Controls.Add(this.txtNroConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNroHistClinica);
            this.Controls.Add(this.lblNro);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarConsulta";
            this.Text = "ModificarConsulta";
            this.Load += new System.EventHandler(this.ModificarConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNroHistCLI;
        private System.Windows.Forms.Label txtNroConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mskNrodoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroHistClinica;
        private System.Windows.Forms.Label lblNro;
    }
}