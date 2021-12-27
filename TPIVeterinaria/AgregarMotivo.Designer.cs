namespace TPIVeterinaria
{
    partial class AgregarMotivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMotivo));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiltrosBusqueda = new System.Windows.Forms.Label();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.chbId = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMotivo = new System.Windows.Forms.TextBox();
            this.txtIdMotivo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvMotivos = new System.Windows.Forms.DataGridView();
            this.id_motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListaMotivos = new System.Windows.Forms.Label();
            this.ttpBtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnAltaConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_delete_2460293;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(220, 332);
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
            this.btnActualizar.Location = new System.Drawing.Point(309, 332);
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
            this.btnBuscar.Location = new System.Drawing.Point(309, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 38);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Para Modificar o Eliminar \r\nalgun Motivo debe seleccionarlo*";
            // 
            // lblFiltrosBusqueda
            // 
            this.lblFiltrosBusqueda.AutoSize = true;
            this.lblFiltrosBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrosBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrosBusqueda.Location = new System.Drawing.Point(10, 14);
            this.lblFiltrosBusqueda.Name = "lblFiltrosBusqueda";
            this.lblFiltrosBusqueda.Size = new System.Drawing.Size(139, 15);
            this.lblFiltrosBusqueda.TabIndex = 27;
            this.lblFiltrosBusqueda.Text = "Filtros de Busqueda:";
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.BackColor = System.Drawing.Color.Transparent;
            this.chbNombre.Location = new System.Drawing.Point(216, 71);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(64, 17);
            this.chbNombre.TabIndex = 26;
            this.chbNombre.Text = "Habilitar";
            this.chbNombre.UseVisualStyleBackColor = false;
            this.chbNombre.CheckedChanged += new System.EventHandler(this.chbNombre_CheckedChanged);
            // 
            // chbId
            // 
            this.chbId.AutoSize = true;
            this.chbId.BackColor = System.Drawing.Color.Transparent;
            this.chbId.Location = new System.Drawing.Point(216, 43);
            this.chbId.Name = "chbId";
            this.chbId.Size = new System.Drawing.Size(64, 17);
            this.chbId.TabIndex = 24;
            this.chbId.Text = "Habilitar";
            this.chbId.UseVisualStyleBackColor = false;
            this.chbId.CheckedChanged += new System.EventHandler(this.chbId_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 23;
            // 
            // txtNombreMotivo
            // 
            this.txtNombreMotivo.Location = new System.Drawing.Point(65, 69);
            this.txtNombreMotivo.Name = "txtNombreMotivo";
            this.txtNombreMotivo.Size = new System.Drawing.Size(143, 20);
            this.txtNombreMotivo.TabIndex = 20;
            // 
            // txtIdMotivo
            // 
            this.txtIdMotivo.Location = new System.Drawing.Point(65, 44);
            this.txtIdMotivo.Name = "txtIdMotivo";
            this.txtIdMotivo.Size = new System.Drawing.Size(143, 20);
            this.txtIdMotivo.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(39, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "ID :";
            // 
            // dgvMotivos
            // 
            this.dgvMotivos.AllowUserToAddRows = false;
            this.dgvMotivos.AllowUserToDeleteRows = false;
            this.dgvMotivos.AllowUserToResizeColumns = false;
            this.dgvMotivos.AllowUserToResizeRows = false;
            this.dgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_motivo,
            this.nombre,
            this.descripcion});
            this.dgvMotivos.Location = new System.Drawing.Point(12, 135);
            this.dgvMotivos.Name = "dgvMotivos";
            this.dgvMotivos.ReadOnly = true;
            this.dgvMotivos.RowHeadersVisible = false;
            this.dgvMotivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMotivos.Size = new System.Drawing.Size(456, 182);
            this.dgvMotivos.TabIndex = 25;
            this.dgvMotivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotivos_CellClick);
            // 
            // id_motivo
            // 
            this.id_motivo.DataPropertyName = "id_motivo";
            this.id_motivo.HeaderText = "ID Motivo";
            this.id_motivo.Name = "id_motivo";
            this.id_motivo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 130;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // lblListaMotivos
            // 
            this.lblListaMotivos.AutoSize = true;
            this.lblListaMotivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaMotivos.Location = new System.Drawing.Point(150, 119);
            this.lblListaMotivos.Name = "lblListaMotivos";
            this.lblListaMotivos.Size = new System.Drawing.Size(100, 13);
            this.lblListaMotivos.TabIndex = 18;
            this.lblListaMotivos.Text = "Lista de Motivos";
            // 
            // btnAltaConsulta
            // 
            this.btnAltaConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnAltaConsulta.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAltaConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltaConsulta.FlatAppearance.BorderSize = 0;
            this.btnAltaConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAltaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaConsulta.Location = new System.Drawing.Point(408, 332);
            this.btnAltaConsulta.Name = "btnAltaConsulta";
            this.btnAltaConsulta.Size = new System.Drawing.Size(60, 38);
            this.btnAltaConsulta.TabIndex = 45;
            this.btnAltaConsulta.UseVisualStyleBackColor = false;
            this.btnAltaConsulta.Click += new System.EventHandler(this.btnAltaConsulta_Click);
            // 
            // AgregarMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 396);
            this.Controls.Add(this.btnAltaConsulta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFiltrosBusqueda);
            this.Controls.Add(this.chbNombre);
            this.Controls.Add(this.chbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreMotivo);
            this.Controls.Add(this.txtIdMotivo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvMotivos);
            this.Controls.Add(this.lblListaMotivos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarMotivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMotivo";
            this.Load += new System.EventHandler(this.AgregarMotivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiltrosBusqueda;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.CheckBox chbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMotivo;
        private System.Windows.Forms.TextBox txtIdMotivo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvMotivos;
        private System.Windows.Forms.Label lblListaMotivos;
        private System.Windows.Forms.ToolTip ttpBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnAltaConsulta;
    }
}