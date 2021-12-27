namespace TPIVeterinaria
{
    partial class AgregarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientes));
            this.btnAñadirCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.nupPeso = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.grGrillaCliente = new System.Windows.Forms.DataGridView();
            this.grMascotas = new System.Windows.Forms.DataGridView();
            this.NroHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoAprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimientoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAñadirMascota = new System.Windows.Forms.Button();
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.gbDatosMascotas = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNroHisto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.btnActualizarMascota = new System.Windows.Forms.Button();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpMensaje = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGrillaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMascotas)).BeginInit();
            this.gbDatosMascotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAñadirCliente
            // 
            this.btnAñadirCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirCliente.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAñadirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadirCliente.FlatAppearance.BorderSize = 0;
            this.btnAñadirCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAñadirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirCliente.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCliente.Location = new System.Drawing.Point(740, 88);
            this.btnAñadirCliente.Name = "btnAñadirCliente";
            this.btnAñadirCliente.Size = new System.Drawing.Size(60, 38);
            this.btnAñadirCliente.TabIndex = 0;
            this.btnAñadirCliente.UseVisualStyleBackColor = false;
            this.btnAñadirCliente.Click += new System.EventHandler(this.btnAñadirCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_search_2427697;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(674, 88);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(60, 38);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero de Documento:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(83, 28);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(178, 20);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(357, 28);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(178, 20);
            this.txtApellidoCliente.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(627, 28);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(178, 20);
            this.txtMail.TabIndex = 10;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(462, 59);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(178, 20);
            this.txtNroDocumento.TabIndex = 11;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(148, 60);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDocumento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SeaShell;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Raza:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SeaShell;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Especie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SeaShell;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SeaShell;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Peso Aprox:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SeaShell;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(691, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Sexo:";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(80, 51);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(116, 21);
            this.txtNombreMascota.TabIndex = 19;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(424, 51);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(99, 24);
            this.cmbEspecie.TabIndex = 20;
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(249, 50);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(99, 24);
            this.cmbRaza.TabIndex = 21;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(737, 50);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(65, 24);
            this.cmbSexo.TabIndex = 22;
            // 
            // nupPeso
            // 
            this.nupPeso.Location = new System.Drawing.Point(624, 50);
            this.nupPeso.Name = "nupPeso";
            this.nupPeso.Size = new System.Drawing.Size(43, 21);
            this.nupPeso.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Datos Cliente";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(154, 91);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(85, 21);
            this.txtFechaNac.TabIndex = 26;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // grGrillaCliente
            // 
            this.grGrillaCliente.AllowUserToAddRows = false;
            this.grGrillaCliente.AllowUserToDeleteRows = false;
            this.grGrillaCliente.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grGrillaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grGrillaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grGrillaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.TipoDocumento,
            this.NumeroDoc,
            this.Mail});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grGrillaCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.grGrillaCliente.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.grGrillaCliente.Location = new System.Drawing.Point(12, 132);
            this.grGrillaCliente.Name = "grGrillaCliente";
            this.grGrillaCliente.ReadOnly = true;
            this.grGrillaCliente.Size = new System.Drawing.Size(809, 140);
            this.grGrillaCliente.TabIndex = 27;
            this.grGrillaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grGrillaCliente_CellClick);
            // 
            // grMascotas
            // 
            this.grMascotas.AllowUserToAddRows = false;
            this.grMascotas.AllowUserToDeleteRows = false;
            this.grMascotas.BackgroundColor = System.Drawing.Color.SeaShell;
            this.grMascotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroHistorial,
            this.NombreMascota,
            this.Raza,
            this.Especie,
            this.PesoAprox,
            this.FechaNacimientoMascota,
            this.Sexo,
            this.FechaIngreso});
            this.grMascotas.Location = new System.Drawing.Point(9, 127);
            this.grMascotas.Name = "grMascotas";
            this.grMascotas.ReadOnly = true;
            this.grMascotas.Size = new System.Drawing.Size(793, 150);
            this.grMascotas.TabIndex = 28;
            this.grMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grMascotas_CellClick);
            // 
            // NroHistorial
            // 
            this.NroHistorial.DataPropertyName = "nro_hist_clinica";
            this.NroHistorial.HeaderText = "Nro Historial";
            this.NroHistorial.Name = "NroHistorial";
            this.NroHistorial.ReadOnly = true;
            this.NroHistorial.Width = 50;
            // 
            // NombreMascota
            // 
            this.NombreMascota.DataPropertyName = "nombre";
            this.NombreMascota.HeaderText = "Nombre Mascota";
            this.NombreMascota.Name = "NombreMascota";
            this.NombreMascota.ReadOnly = true;
            this.NombreMascota.Width = 150;
            // 
            // Raza
            // 
            this.Raza.DataPropertyName = "id_raza";
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.DataPropertyName = "id_especie";
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // PesoAprox
            // 
            this.PesoAprox.DataPropertyName = "peso_aprox_ingreso";
            this.PesoAprox.HeaderText = "Peso Kg";
            this.PesoAprox.Name = "PesoAprox";
            this.PesoAprox.ReadOnly = true;
            // 
            // FechaNacimientoMascota
            // 
            this.FechaNacimientoMascota.DataPropertyName = "fecha_nacimiento";
            this.FechaNacimientoMascota.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimientoMascota.Name = "FechaNacimientoMascota";
            this.FechaNacimientoMascota.ReadOnly = true;
            this.FechaNacimientoMascota.Width = 150;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "id_sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "fecha_ingreso_vet";
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // btnAñadirMascota
            // 
            this.btnAñadirMascota.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAñadirMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadirMascota.FlatAppearance.BorderSize = 0;
            this.btnAñadirMascota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAñadirMascota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAñadirMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirMascota.Location = new System.Drawing.Point(737, 83);
            this.btnAñadirMascota.Name = "btnAñadirMascota";
            this.btnAñadirMascota.Size = new System.Drawing.Size(60, 38);
            this.btnAñadirMascota.TabIndex = 29;
            this.btnAñadirMascota.UseVisualStyleBackColor = true;
            this.btnAñadirMascota.Click += new System.EventHandler(this.btnAñadirMascota_Click);
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_search_2427697;
            this.btnBuscarMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarMascota.FlatAppearance.BorderSize = 0;
            this.btnBuscarMascota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBuscarMascota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMascota.Location = new System.Drawing.Point(671, 83);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(60, 38);
            this.btnBuscarMascota.TabIndex = 30;
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_delete_2460293;
            this.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(542, 88);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(60, 38);
            this.btnEliminarCliente.TabIndex = 31;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_delete_2460293;
            this.btnEliminarMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarMascota.FlatAppearance.BorderSize = 0;
            this.btnEliminarMascota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEliminarMascota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEliminarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMascota.Location = new System.Drawing.Point(539, 83);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(60, 38);
            this.btnEliminarMascota.TabIndex = 32;
            this.btnEliminarMascota.UseVisualStyleBackColor = true;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SeaShell;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Nombre:";
            // 
            // gbDatosMascotas
            // 
            this.gbDatosMascotas.BackColor = System.Drawing.Color.Transparent;
            this.gbDatosMascotas.Controls.Add(this.label14);
            this.gbDatosMascotas.Controls.Add(this.txtNroHisto);
            this.gbDatosMascotas.Controls.Add(this.label1);
            this.gbDatosMascotas.Controls.Add(this.txtFechaIngreso);
            this.gbDatosMascotas.Controls.Add(this.btnActualizarMascota);
            this.gbDatosMascotas.Controls.Add(this.label6);
            this.gbDatosMascotas.Controls.Add(this.label7);
            this.gbDatosMascotas.Controls.Add(this.label8);
            this.gbDatosMascotas.Controls.Add(this.label9);
            this.gbDatosMascotas.Controls.Add(this.label10);
            this.gbDatosMascotas.Controls.Add(this.btnEliminarMascota);
            this.gbDatosMascotas.Controls.Add(this.label11);
            this.gbDatosMascotas.Controls.Add(this.txtNombreMascota);
            this.gbDatosMascotas.Controls.Add(this.btnBuscarMascota);
            this.gbDatosMascotas.Controls.Add(this.cmbEspecie);
            this.gbDatosMascotas.Controls.Add(this.btnAñadirMascota);
            this.gbDatosMascotas.Controls.Add(this.cmbRaza);
            this.gbDatosMascotas.Controls.Add(this.grMascotas);
            this.gbDatosMascotas.Controls.Add(this.cmbSexo);
            this.gbDatosMascotas.Controls.Add(this.nupPeso);
            this.gbDatosMascotas.Controls.Add(this.txtFechaNac);
            this.gbDatosMascotas.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMascotas.Location = new System.Drawing.Point(3, 278);
            this.gbDatosMascotas.Name = "gbDatosMascotas";
            this.gbDatosMascotas.Size = new System.Drawing.Size(818, 283);
            this.gbDatosMascotas.TabIndex = 34;
            this.gbDatosMascotas.TabStop = false;
            this.gbDatosMascotas.Text = "Datos Mascotas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Nº Historial:";
            // 
            // txtNroHisto
            // 
            this.txtNroHisto.Enabled = false;
            this.txtNroHisto.Location = new System.Drawing.Point(104, 19);
            this.txtNroHisto.Name = "txtNroHisto";
            this.txtNroHisto.Size = new System.Drawing.Size(53, 21);
            this.txtNroHisto.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha de Ingreso:";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(374, 91);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(85, 21);
            this.txtFechaIngreso.TabIndex = 38;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // btnActualizarMascota
            // 
            this.btnActualizarMascota.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_renew_41685711;
            this.btnActualizarMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizarMascota.FlatAppearance.BorderSize = 0;
            this.btnActualizarMascota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnActualizarMascota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnActualizarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMascota.Location = new System.Drawing.Point(605, 83);
            this.btnActualizarMascota.Name = "btnActualizarMascota";
            this.btnActualizarMascota.Size = new System.Drawing.Size(60, 38);
            this.btnActualizarMascota.TabIndex = 36;
            this.btnActualizarMascota.UseVisualStyleBackColor = true;
            this.btnActualizarMascota.Click += new System.EventHandler(this.btnActualizarMascota_Click);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_renew_41685711;
            this.btnActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCliente.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.Location = new System.Drawing.Point(608, 88);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(60, 38);
            this.btnActualizarCliente.TabIndex = 35;
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "tipo_doc_dueño";
            this.TipoDocumento.HeaderText = "Tipo de Doc";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDoc
            // 
            this.NumeroDoc.DataPropertyName = "nro_doc_dueño";
            this.NumeroDoc.HeaderText = "Numero de Documento";
            this.NumeroDoc.Name = "NumeroDoc";
            this.NumeroDoc.ReadOnly = true;
            this.NumeroDoc.Width = 150;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "mail";
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 215;
            // 
            // tpMensaje
            // 
            this.tpMensaje.AutomaticDelay = 800;
            // 
            // AgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(833, 598);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.gbDatosMascotas);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.grGrillaCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.btnAñadirCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtApellidoCliente);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarClientes";
            this.Load += new System.EventHandler(this.AgregarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGrillaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMascotas)).EndInit();
            this.gbDatosMascotas.ResumeLayout(false);
            this.gbDatosMascotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.NumericUpDown nupPeso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.DataGridView grGrillaCliente;
        private System.Windows.Forms.DataGridView grMascotas;
        private System.Windows.Forms.Button btnAñadirMascota;
        private System.Windows.Forms.Button btnBuscarMascota;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbDatosMascotas;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.Button btnActualizarMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNroHisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoAprox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimientoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.ToolTip tpMensaje;
    }
}