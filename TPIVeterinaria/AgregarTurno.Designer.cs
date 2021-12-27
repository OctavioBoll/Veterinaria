namespace TPIVeterinaria
{
    partial class AgregarTurno
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.nroTurnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroHistorialClinico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbTipoServicio = new System.Windows.Forms.CheckBox();
            this.chbFecha = new System.Windows.Forms.CheckBox();
            this.chbNroTruno = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.txtNroTurno = new System.Windows.Forms.TextBox();
            this.lblNroTurno = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.ttpBtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAltaConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Para Modificar o Eliminar algun Turno debe seleccionarlo*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Lista de Turnos";
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;
            this.dgvTurnos.AllowUserToResizeColumns = false;
            this.dgvTurnos.AllowUserToResizeRows = false;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroTurnos,
            this.Fecha,
            this.Hora,
            this.IdServicio,
            this.NroHistorialClinico});
            this.dgvTurnos.Location = new System.Drawing.Point(64, 198);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.RowHeadersVisible = false;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(469, 241);
            this.dgvTurnos.TabIndex = 25;
            this.dgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellClick);
            // 
            // nroTurnos
            // 
            this.nroTurnos.DataPropertyName = "nro_turno";
            this.nroTurnos.HeaderText = "Nro Turno";
            this.nroTurnos.Name = "nroTurnos";
            this.nroTurnos.ReadOnly = true;
            this.nroTurnos.Width = 60;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // IdServicio
            // 
            this.IdServicio.DataPropertyName = "id_servicio";
            this.IdServicio.HeaderText = "Tipo de Servicio";
            this.IdServicio.Name = "IdServicio";
            this.IdServicio.ReadOnly = true;
            // 
            // NroHistorialClinico
            // 
            this.NroHistorialClinico.DataPropertyName = "nro_hist_clinica";
            this.NroHistorialClinico.HeaderText = "Nro de Historia Clin.";
            this.NroHistorialClinico.Name = "NroHistorialClinico";
            this.NroHistorialClinico.ReadOnly = true;
            this.NroHistorialClinico.Width = 90;
            // 
            // chbTipoServicio
            // 
            this.chbTipoServicio.AutoSize = true;
            this.chbTipoServicio.BackColor = System.Drawing.Color.Transparent;
            this.chbTipoServicio.Location = new System.Drawing.Point(329, 132);
            this.chbTipoServicio.Name = "chbTipoServicio";
            this.chbTipoServicio.Size = new System.Drawing.Size(64, 17);
            this.chbTipoServicio.TabIndex = 24;
            this.chbTipoServicio.Text = "Habilitar";
            this.chbTipoServicio.UseVisualStyleBackColor = false;
            this.chbTipoServicio.CheckedChanged += new System.EventHandler(this.chbTipoServicio_CheckedChanged);
            // 
            // chbFecha
            // 
            this.chbFecha.AutoSize = true;
            this.chbFecha.BackColor = System.Drawing.Color.Transparent;
            this.chbFecha.Location = new System.Drawing.Point(329, 106);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(64, 17);
            this.chbFecha.TabIndex = 28;
            this.chbFecha.Text = "Habilitar";
            this.chbFecha.UseVisualStyleBackColor = false;
            this.chbFecha.CheckedChanged += new System.EventHandler(this.chbFecha_CheckedChanged);
            // 
            // chbNroTruno
            // 
            this.chbNroTruno.AutoSize = true;
            this.chbNroTruno.BackColor = System.Drawing.Color.Transparent;
            this.chbNroTruno.Location = new System.Drawing.Point(329, 79);
            this.chbNroTruno.Name = "chbNroTruno";
            this.chbNroTruno.Size = new System.Drawing.Size(64, 17);
            this.chbNroTruno.TabIndex = 23;
            this.chbNroTruno.Text = "Habilitar";
            this.chbNroTruno.UseVisualStyleBackColor = false;
            this.chbNroTruno.CheckedChanged += new System.EventHandler(this.chbNroTruno_CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(145, 101);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(178, 20);
            this.dtpFecha.TabIndex = 21;
            this.dtpFecha.Value = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(84, 104);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 15);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(145, 127);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(178, 21);
            this.cmbTipoServicio.TabIndex = 22;
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnos.Location = new System.Drawing.Point(225, 18);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(130, 17);
            this.lblTurnos.TabIndex = 17;
            this.lblTurnos.Text = "Turno asignados";
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.Location = new System.Drawing.Point(145, 77);
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(178, 20);
            this.txtNroTurno.TabIndex = 20;
            // 
            // lblNroTurno
            // 
            this.lblNroTurno.AutoSize = true;
            this.lblNroTurno.BackColor = System.Drawing.Color.Transparent;
            this.lblNroTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroTurno.Location = new System.Drawing.Point(39, 78);
            this.lblNroTurno.Name = "lblNroTurno";
            this.lblNroTurno.Size = new System.Drawing.Size(95, 15);
            this.lblNroTurno.TabIndex = 16;
            this.lblNroTurno.Text = "Nro de Turno:";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(22, 128);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(112, 15);
            this.lblTipoServicio.TabIndex = 19;
            this.lblTipoServicio.Text = "Tipo de servicio:";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(10, 50);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(139, 15);
            this.lblFiltros.TabIndex = 15;
            this.lblFiltros.Text = "Filtros de Busqueda:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_delete_2460293;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(352, 452);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 38);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_renew_41685711;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(427, 452);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(60, 38);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_search_2427697;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(418, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 38);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAltaConsulta
            // 
            this.btnAltaConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnAltaConsulta.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAltaConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltaConsulta.FlatAppearance.BorderSize = 0;
            this.btnAltaConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAltaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaConsulta.Location = new System.Drawing.Point(504, 452);
            this.btnAltaConsulta.Name = "btnAltaConsulta";
            this.btnAltaConsulta.Size = new System.Drawing.Size(60, 38);
            this.btnAltaConsulta.TabIndex = 45;
            this.btnAltaConsulta.UseVisualStyleBackColor = false;
            this.btnAltaConsulta.Click += new System.EventHandler(this.btnAltaConsulta_Click);
            // 
            // AgregarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 502);
            this.Controls.Add(this.btnAltaConsulta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.chbTipoServicio);
            this.Controls.Add(this.chbFecha);
            this.Controls.Add(this.chbNroTruno);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.txtNroTurno);
            this.Controls.Add(this.lblNroTurno);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblFiltros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgregarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Turno";
            this.Load += new System.EventHandler(this.AgregarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroHistorialClinico;
        private System.Windows.Forms.CheckBox chbTipoServicio;
        private System.Windows.Forms.CheckBox chbFecha;
        private System.Windows.Forms.CheckBox chbNroTruno;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.TextBox txtNroTurno;
        private System.Windows.Forms.Label lblNroTurno;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.ToolTip ttpBtn;
        private System.Windows.Forms.Button btnAltaConsulta;
    }
}