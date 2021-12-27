namespace TPIVeterinaria
{
    partial class AgregarRaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRaza));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListadoRazas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpBtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAltaRaza = new System.Windows.Forms.Button();
            this.IdRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRazas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "(*)Para Modificar o Eliminar alguna Raza debe seleccionarla";
            // 
            // dgvListadoRazas
            // 
            this.dgvListadoRazas.AllowUserToAddRows = false;
            this.dgvListadoRazas.AllowUserToDeleteRows = false;
            this.dgvListadoRazas.AllowUserToResizeColumns = false;
            this.dgvListadoRazas.AllowUserToResizeRows = false;
            this.dgvListadoRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoRazas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRaza,
            this.nombre,
            this.descripcion});
            this.dgvListadoRazas.Location = new System.Drawing.Point(89, 47);
            this.dgvListadoRazas.Name = "dgvListadoRazas";
            this.dgvListadoRazas.ReadOnly = true;
            this.dgvListadoRazas.RowHeadersVisible = false;
            this.dgvListadoRazas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoRazas.Size = new System.Drawing.Size(333, 228);
            this.dgvListadoRazas.TabIndex = 17;
            this.dgvListadoRazas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoRazas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lista de Razas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_renew_41685711;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(13, 102);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(60, 38);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_delete_2460293;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(13, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 38);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAltaRaza
            // 
            this.btnAltaRaza.BackColor = System.Drawing.Color.Transparent;
            this.btnAltaRaza.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAltaRaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltaRaza.FlatAppearance.BorderSize = 0;
            this.btnAltaRaza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAltaRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaRaza.Location = new System.Drawing.Point(13, 47);
            this.btnAltaRaza.Name = "btnAltaRaza";
            this.btnAltaRaza.Size = new System.Drawing.Size(60, 38);
            this.btnAltaRaza.TabIndex = 19;
            this.btnAltaRaza.UseVisualStyleBackColor = false;
            this.btnAltaRaza.Click += new System.EventHandler(this.btnAltaRaza_Click);
            // 
            // IdRaza
            // 
            this.IdRaza.DataPropertyName = "id_raza";
            this.IdRaza.HeaderText = "ID";
            this.IdRaza.Name = "IdRaza";
            this.IdRaza.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Raza";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // AgregarRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 334);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAltaRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListadoRazas);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarRaza";
            this.Text = "AgregarRaza";
            this.Load += new System.EventHandler(this.AgregarRaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRazas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAltaRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListadoRazas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttpBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}