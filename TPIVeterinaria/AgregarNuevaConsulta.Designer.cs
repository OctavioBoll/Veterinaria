namespace TPIVeterinaria
{
    partial class AgregarNuevaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarNuevaConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNroHist = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.mskNroHistClinica = new System.Windows.Forms.MaskedTextBox();
            this.btnAgrenar = new System.Windows.Forms.Button();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.lblNobreEmpleado = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.btnValidarEmpleado = new System.Windows.Forms.Button();
            this.lblValidarHistClinico = new System.Windows.Forms.Label();
            this.btnValidarNroHist = new System.Windows.Forms.Button();
            this.lblValidarEmpleado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agreagar Nueva Consulta";
            // 
            // lblNroHist
            // 
            this.lblNroHist.AutoSize = true;
            this.lblNroHist.BackColor = System.Drawing.Color.Transparent;
            this.lblNroHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroHist.Location = new System.Drawing.Point(35, 60);
            this.lblNroHist.Name = "lblNroHist";
            this.lblNroHist.Size = new System.Drawing.Size(119, 15);
            this.lblNroHist.TabIndex = 1;
            this.lblNroHist.Text = "Nro Hist. Clinica :";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(24, 24);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(134, 15);
            this.lblTipoDoc.TabIndex = 2;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro de documento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(104, 230);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(112, 271);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 15);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Motivo de :\r\nconsulta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblValidarEmpleado);
            this.groupBox1.Controls.Add(this.btnValidarEmpleado);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.lblNobreEmpleado);
            this.groupBox1.Controls.Add(this.cmbTipoDoc);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(164, 21);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(146, 23);
            this.cmbTipoDoc.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(160, 230);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(96, 20);
            this.dtpFecha.TabIndex = 22;
            this.dtpFecha.Value = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            // 
            // mskHora
            // 
            this.mskHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskHora.Location = new System.Drawing.Point(160, 271);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(46, 21);
            this.mskHora.TabIndex = 23;
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(160, 307);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(146, 21);
            this.cmbMotivo.TabIndex = 24;
            // 
            // mskNroHistClinica
            // 
            this.mskNroHistClinica.Location = new System.Drawing.Point(160, 58);
            this.mskNroHistClinica.Mask = "99999999";
            this.mskNroHistClinica.Name = "mskNroHistClinica";
            this.mskNroHistClinica.Size = new System.Drawing.Size(84, 20);
            this.mskNroHistClinica.TabIndex = 6;
            this.mskNroHistClinica.ValidatingType = typeof(int);
            // 
            // btnAgrenar
            // 
            this.btnAgrenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrenar.Location = new System.Drawing.Point(412, 374);
            this.btnAgrenar.Name = "btnAgrenar";
            this.btnAgrenar.Size = new System.Drawing.Size(108, 32);
            this.btnAgrenar.TabIndex = 25;
            this.btnAgrenar.Text = "Agregar";
            this.btnAgrenar.UseVisualStyleBackColor = true;
            this.btnAgrenar.Click += new System.EventHandler(this.btnAgrenar_Click);
            // 
            // btmCancelar
            // 
            this.btmCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCancelar.Location = new System.Drawing.Point(256, 374);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(108, 32);
            this.btmCancelar.TabIndex = 26;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            this.btmCancelar.Click += new System.EventHandler(this.btmCancelar_Click);
            // 
            // lblNobreEmpleado
            // 
            this.lblNobreEmpleado.AutoSize = true;
            this.lblNobreEmpleado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNobreEmpleado.Location = new System.Drawing.Point(161, 99);
            this.lblNobreEmpleado.Name = "lblNobreEmpleado";
            this.lblNobreEmpleado.Size = new System.Drawing.Size(0, 15);
            this.lblNobreEmpleado.TabIndex = 6;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(164, 54);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(124, 21);
            this.txtNroDoc.TabIndex = 7;
            // 
            // btnValidarEmpleado
            // 
            this.btnValidarEmpleado.Location = new System.Drawing.Point(341, 21);
            this.btnValidarEmpleado.Name = "btnValidarEmpleado";
            this.btnValidarEmpleado.Size = new System.Drawing.Size(90, 27);
            this.btnValidarEmpleado.TabIndex = 8;
            this.btnValidarEmpleado.Text = "Validar";
            this.btnValidarEmpleado.UseVisualStyleBackColor = true;
            this.btnValidarEmpleado.Click += new System.EventHandler(this.btnValidarEmpleado_Click);
            // 
            // lblValidarHistClinico
            // 
            this.lblValidarHistClinico.AutoSize = true;
            this.lblValidarHistClinico.Location = new System.Drawing.Point(378, 60);
            this.lblValidarHistClinico.Name = "lblValidarHistClinico";
            this.lblValidarHistClinico.Size = new System.Drawing.Size(0, 13);
            this.lblValidarHistClinico.TabIndex = 28;
            // 
            // btnValidarNroHist
            // 
            this.btnValidarNroHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarNroHist.Location = new System.Drawing.Point(260, 52);
            this.btnValidarNroHist.Name = "btnValidarNroHist";
            this.btnValidarNroHist.Size = new System.Drawing.Size(90, 27);
            this.btnValidarNroHist.TabIndex = 9;
            this.btnValidarNroHist.Text = "Validar";
            this.btnValidarNroHist.UseVisualStyleBackColor = true;
            this.btnValidarNroHist.Click += new System.EventHandler(this.btnValidarNroHist_Click);
            // 
            // lblValidarEmpleado
            // 
            this.lblValidarEmpleado.AutoSize = true;
            this.lblValidarEmpleado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblValidarEmpleado.Location = new System.Drawing.Point(391, 59);
            this.lblValidarEmpleado.Name = "lblValidarEmpleado";
            this.lblValidarEmpleado.Size = new System.Drawing.Size(0, 15);
            this.lblValidarEmpleado.TabIndex = 9;
            // 
            // AgregarNuevaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 422);
            this.Controls.Add(this.btnValidarNroHist);
            this.Controls.Add(this.lblValidarHistClinico);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.btnAgrenar);
            this.Controls.Add(this.mskNroHistClinica);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNroHist);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarNuevaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Consulta";
            this.Load += new System.EventHandler(this.AgregarNuevaConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNroHist;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.MaskedTextBox mskNroHistClinica;
        private System.Windows.Forms.Label lblNobreEmpleado;
        private System.Windows.Forms.Button btnAgrenar;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.Button btnValidarEmpleado;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label lblValidarHistClinico;
        private System.Windows.Forms.Button btnValidarNroHist;
        private System.Windows.Forms.Label lblValidarEmpleado;
    }
}