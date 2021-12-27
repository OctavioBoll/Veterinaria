namespace TPIVeterinaria
{
    partial class AgregarConsultas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarConsultas));
            this.ttpBtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregarMed = new System.Windows.Forms.Button();
            this.dgrVacunas = new System.Windows.Forms.DataGridView();
            this.CodigoVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaMedicamento = new System.Windows.Forms.DataGridView();
            this.CodigoMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaDiagnostico = new System.Windows.Forms.DataGridView();
            this.IdDiag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDiag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarVac = new System.Windows.Forms.Button();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.btnAgregarDiagnostico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNroConsulta = new System.Windows.Forms.Label();
            this.btnValidarNroHist = new System.Windows.Forms.Button();
            this.lblValidarHistClinico = new System.Windows.Forms.Label();
            this.mskNroHistClinica = new System.Windows.Forms.MaskedTextBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValidarEmpleado = new System.Windows.Forms.Label();
            this.btnValidarEmpleado = new System.Windows.Forms.Button();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.lblNobreEmpleado = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroHist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDiagnostico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarMed
            // 
            this.btnAgregarMed.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMed.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAgregarMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarMed.FlatAppearance.BorderSize = 0;
            this.btnAgregarMed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgregarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMed.Location = new System.Drawing.Point(534, 245);
            this.btnAgregarMed.Name = "btnAgregarMed";
            this.btnAgregarMed.Size = new System.Drawing.Size(60, 38);
            this.btnAgregarMed.TabIndex = 44;
            this.btnAgregarMed.UseVisualStyleBackColor = false;
            this.btnAgregarMed.Click += new System.EventHandler(this.btnAltaConsulta_Click);
            // 
            // dgrVacunas
            // 
            this.dgrVacunas.AllowUserToAddRows = false;
            this.dgrVacunas.AllowUserToDeleteRows = false;
            this.dgrVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoVac,
            this.DescripcionVac,
            this.PrecioVac});
            this.dgrVacunas.Location = new System.Drawing.Point(600, 30);
            this.dgrVacunas.Name = "dgrVacunas";
            this.dgrVacunas.ReadOnly = true;
            this.dgrVacunas.Size = new System.Drawing.Size(345, 150);
            this.dgrVacunas.TabIndex = 45;
            // 
            // CodigoVac
            // 
            this.CodigoVac.HeaderText = "Codigo";
            this.CodigoVac.Name = "CodigoVac";
            this.CodigoVac.ReadOnly = true;
            // 
            // DescripcionVac
            // 
            this.DescripcionVac.HeaderText = "Descripcion";
            this.DescripcionVac.Name = "DescripcionVac";
            this.DescripcionVac.ReadOnly = true;
            // 
            // PrecioVac
            // 
            this.PrecioVac.HeaderText = "Precio";
            this.PrecioVac.Name = "PrecioVac";
            this.PrecioVac.ReadOnly = true;
            // 
            // grillaMedicamento
            // 
            this.grillaMedicamento.AllowUserToAddRows = false;
            this.grillaMedicamento.AllowUserToDeleteRows = false;
            this.grillaMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMed,
            this.DescripcionMed,
            this.PrecioMed,
            this.ProveedorMed});
            this.grillaMedicamento.Location = new System.Drawing.Point(600, 235);
            this.grillaMedicamento.Name = "grillaMedicamento";
            this.grillaMedicamento.ReadOnly = true;
            this.grillaMedicamento.Size = new System.Drawing.Size(345, 150);
            this.grillaMedicamento.TabIndex = 46;
            // 
            // CodigoMed
            // 
            this.CodigoMed.HeaderText = "Codigo";
            this.CodigoMed.Name = "CodigoMed";
            this.CodigoMed.ReadOnly = true;
            // 
            // DescripcionMed
            // 
            this.DescripcionMed.HeaderText = "Descripcion";
            this.DescripcionMed.Name = "DescripcionMed";
            this.DescripcionMed.ReadOnly = true;
            // 
            // PrecioMed
            // 
            this.PrecioMed.HeaderText = "Precio";
            this.PrecioMed.Name = "PrecioMed";
            this.PrecioMed.ReadOnly = true;
            // 
            // ProveedorMed
            // 
            this.ProveedorMed.HeaderText = "Codigo Proveedor";
            this.ProveedorMed.Name = "ProveedorMed";
            this.ProveedorMed.ReadOnly = true;
            // 
            // grillaDiagnostico
            // 
            this.grillaDiagnostico.AllowUserToAddRows = false;
            this.grillaDiagnostico.AllowUserToDeleteRows = false;
            this.grillaDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDiag,
            this.NombreDiag});
            this.grillaDiagnostico.Location = new System.Drawing.Point(600, 455);
            this.grillaDiagnostico.Name = "grillaDiagnostico";
            this.grillaDiagnostico.ReadOnly = true;
            this.grillaDiagnostico.Size = new System.Drawing.Size(345, 150);
            this.grillaDiagnostico.TabIndex = 47;
            // 
            // IdDiag
            // 
            this.IdDiag.HeaderText = "Id";
            this.IdDiag.Name = "IdDiag";
            this.IdDiag.ReadOnly = true;
            this.IdDiag.Width = 130;
            // 
            // NombreDiag
            // 
            this.NombreDiag.FillWeight = 200F;
            this.NombreDiag.HeaderText = "Nombre";
            this.NombreDiag.Name = "NombreDiag";
            this.NombreDiag.ReadOnly = true;
            this.NombreDiag.Width = 150;
            // 
            // btnAgregarVac
            // 
            this.btnAgregarVac.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarVac.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAgregarVac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarVac.FlatAppearance.BorderSize = 0;
            this.btnAgregarVac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgregarVac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVac.Location = new System.Drawing.Point(534, 30);
            this.btnAgregarVac.Name = "btnAgregarVac";
            this.btnAgregarVac.Size = new System.Drawing.Size(60, 38);
            this.btnAgregarVac.TabIndex = 48;
            this.btnAgregarVac.UseVisualStyleBackColor = false;
            this.btnAgregarVac.Click += new System.EventHandler(this.btnAgregarVac_Click);
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMedicamento.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAgregarMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarMedicamento.FlatAppearance.BorderSize = 0;
            this.btnAgregarMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgregarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(467, 251);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(60, 38);
            this.btnAgregarMedicamento.TabIndex = 49;
            this.btnAgregarMedicamento.UseVisualStyleBackColor = false;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // btnAgregarDiagnostico
            // 
            this.btnAgregarDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDiagnostico.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAgregarDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDiagnostico.FlatAppearance.BorderSize = 0;
            this.btnAgregarDiagnostico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgregarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDiagnostico.Location = new System.Drawing.Point(534, 439);
            this.btnAgregarDiagnostico.Name = "btnAgregarDiagnostico";
            this.btnAgregarDiagnostico.Size = new System.Drawing.Size(60, 38);
            this.btnAgregarDiagnostico.TabIndex = 50;
            this.btnAgregarDiagnostico.UseVisualStyleBackColor = false;
            this.btnAgregarDiagnostico.Click += new System.EventHandler(this.btnAgregarDiagnostico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Vacunas Agregadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Medicamentos Agregados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(709, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Diagnosticos Agregados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(348, 575);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 30);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 575);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 30);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Consulta Nro:";
            // 
            // lblNroConsulta
            // 
            this.lblNroConsulta.AutoSize = true;
            this.lblNroConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblNroConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroConsulta.Location = new System.Drawing.Point(136, 147);
            this.lblNroConsulta.Name = "lblNroConsulta";
            this.lblNroConsulta.Size = new System.Drawing.Size(65, 16);
            this.lblNroConsulta.TabIndex = 59;
            this.lblNroConsulta.Text = "nroCons";
            // 
            // btnValidarNroHist
            // 
            this.btnValidarNroHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarNroHist.Location = new System.Drawing.Point(256, 181);
            this.btnValidarNroHist.Name = "btnValidarNroHist";
            this.btnValidarNroHist.Size = new System.Drawing.Size(90, 27);
            this.btnValidarNroHist.TabIndex = 66;
            this.btnValidarNroHist.Text = "Validar";
            this.btnValidarNroHist.UseVisualStyleBackColor = true;
            this.btnValidarNroHist.Click += new System.EventHandler(this.btnValidarNroHist_Click_1);
            // 
            // lblValidarHistClinico
            // 
            this.lblValidarHistClinico.AutoSize = true;
            this.lblValidarHistClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarHistClinico.Location = new System.Drawing.Point(374, 189);
            this.lblValidarHistClinico.Name = "lblValidarHistClinico";
            this.lblValidarHistClinico.Size = new System.Drawing.Size(0, 13);
            this.lblValidarHistClinico.TabIndex = 70;
            // 
            // mskNroHistClinica
            // 
            this.mskNroHistClinica.Location = new System.Drawing.Point(156, 187);
            this.mskNroHistClinica.Mask = "99999999";
            this.mskNroHistClinica.Name = "mskNroHistClinica";
            this.mskNroHistClinica.Size = new System.Drawing.Size(84, 20);
            this.mskNroHistClinica.TabIndex = 63;
            this.mskNroHistClinica.ValidatingType = typeof(int);
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(156, 402);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(146, 21);
            this.cmbMotivo.TabIndex = 69;
            // 
            // mskHora
            // 
            this.mskHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskHora.Location = new System.Drawing.Point(156, 363);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(46, 21);
            this.mskHora.TabIndex = 68;
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(156, 322);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(96, 20);
            this.dtpFecha.TabIndex = 67;
            this.dtpFecha.Value = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblEmpleado);
            this.groupBox1.Controls.Add(this.lblValidarEmpleado);
            this.groupBox1.Controls.Add(this.btnValidarEmpleado);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.lblNobreEmpleado);
            this.groupBox1.Controls.Add(this.cmbTipoDoc);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 102);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
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
            // btnValidarEmpleado
            // 
            this.btnValidarEmpleado.Location = new System.Drawing.Point(341, 21);
            this.btnValidarEmpleado.Name = "btnValidarEmpleado";
            this.btnValidarEmpleado.Size = new System.Drawing.Size(90, 27);
            this.btnValidarEmpleado.TabIndex = 8;
            this.btnValidarEmpleado.Text = "Validar";
            this.btnValidarEmpleado.UseVisualStyleBackColor = true;
            this.btnValidarEmpleado.Click += new System.EventHandler(this.btnValidarEmpleado_Click_1);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(164, 51);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(124, 21);
            this.txtNroDoc.TabIndex = 7;
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
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(164, 21);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(146, 23);
            this.cmbTipoDoc.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "Motivo de :\r\nconsulta";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(108, 363);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 15);
            this.lblHora.TabIndex = 62;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(100, 322);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 15);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNroHist
            // 
            this.lblNroHist.AutoSize = true;
            this.lblNroHist.BackColor = System.Drawing.Color.Transparent;
            this.lblNroHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroHist.Location = new System.Drawing.Point(31, 189);
            this.lblNroHist.Name = "lblNroHist";
            this.lblNroHist.Size = new System.Drawing.Size(119, 15);
            this.lblNroHist.TabIndex = 60;
            this.lblNroHist.Text = "Nro Hist. Clinica :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "Agregar Nueva Consulta:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(338, 74);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(0, 16);
            this.lblEmpleado.TabIndex = 72;
            // 
            // AgregarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidarNroHist);
            this.Controls.Add(this.lblValidarHistClinico);
            this.Controls.Add(this.mskNroHistClinica);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNroHist);
            this.Controls.Add(this.lblNroConsulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarDiagnostico);
            this.Controls.Add(this.btnAgregarMedicamento);
            this.Controls.Add(this.btnAgregarVac);
            this.Controls.Add(this.grillaDiagnostico);
            this.Controls.Add(this.grillaMedicamento);
            this.Controls.Add(this.dgrVacunas);
            this.Controls.Add(this.btnAgregarMed);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AgregarConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDiagnostico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttpBtn;
        private System.Windows.Forms.Button btnAgregarMed;
        private System.Windows.Forms.Button btnAgregarVac;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.Button btnAgregarDiagnostico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorMed;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNroConsulta;
        public System.Windows.Forms.DataGridView dgrVacunas;
        public System.Windows.Forms.DataGridView grillaDiagnostico;
        public System.Windows.Forms.DataGridView grillaMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiag;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDiag;
        private System.Windows.Forms.Button btnValidarNroHist;
        private System.Windows.Forms.Label lblValidarHistClinico;
        private System.Windows.Forms.MaskedTextBox mskNroHistClinica;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValidarEmpleado;
        private System.Windows.Forms.Button btnValidarEmpleado;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label lblNobreEmpleado;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroHist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpleado;
    }
}