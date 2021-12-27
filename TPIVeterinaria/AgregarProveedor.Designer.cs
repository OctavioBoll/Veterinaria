namespace TPIVeterinaria
{
    partial class AgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModifProveedores = new System.Windows.Forms.Button();
            this.btnBajaProveedores = new System.Windows.Forms.Button();
            this.dgrProveedor = new System.Windows.Forms.DataGridView();
            this.CodigoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProveedor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedor.Location = new System.Drawing.Point(214, 74);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProveedor.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(214, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_add_fill_3017948;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(269, 168);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(60, 38);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnModifProveedores
            // 
            this.btnModifProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnModifProveedores.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_renew_41685711;
            this.btnModifProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifProveedores.FlatAppearance.BorderSize = 0;
            this.btnModifProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnModifProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifProveedores.Location = new System.Drawing.Point(203, 168);
            this.btnModifProveedores.Name = "btnModifProveedores";
            this.btnModifProveedores.Size = new System.Drawing.Size(60, 38);
            this.btnModifProveedores.TabIndex = 6;
            this.btnModifProveedores.UseVisualStyleBackColor = false;
            this.btnModifProveedores.Click += new System.EventHandler(this.btnModifProveedores_Click_1);
            // 
            // btnBajaProveedores
            // 
            this.btnBajaProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnBajaProveedores.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_delete_2460293;
            this.btnBajaProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBajaProveedores.FlatAppearance.BorderSize = 0;
            this.btnBajaProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBajaProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaProveedores.Location = new System.Drawing.Point(137, 168);
            this.btnBajaProveedores.Name = "btnBajaProveedores";
            this.btnBajaProveedores.Size = new System.Drawing.Size(60, 38);
            this.btnBajaProveedores.TabIndex = 7;
            this.btnBajaProveedores.UseVisualStyleBackColor = false;
            this.btnBajaProveedores.Click += new System.EventHandler(this.btnBajaProveedores_Click_1);
            // 
            // dgrProveedor
            // 
            this.dgrProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProveedor,
            this.Nombre});
            this.dgrProveedor.Location = new System.Drawing.Point(65, 212);
            this.dgrProveedor.Name = "dgrProveedor";
            this.dgrProveedor.Size = new System.Drawing.Size(270, 150);
            this.dgrProveedor.TabIndex = 8;
            this.dgrProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProveedor_CellClick);
            // 
            // CodigoProveedor
            // 
            this.CodigoProveedor.DataPropertyName = "mat_lab_prov";
            this.CodigoProveedor.HeaderText = "Codigo Proveedor";
            this.CodigoProveedor.Name = "CodigoProveedor";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.buscadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // buscadorToolStripMenuItem
            // 
            this.buscadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorCodigoToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem});
            this.buscadorToolStripMenuItem.Name = "buscadorToolStripMenuItem";
            this.buscadorToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.buscadorToolStripMenuItem.Text = "Buscador";
            // 
            // buscarPorCodigoToolStripMenuItem
            // 
            this.buscarPorCodigoToolStripMenuItem.Name = "buscarPorCodigoToolStripMenuItem";
            this.buscarPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.buscarPorCodigoToolStripMenuItem.Text = "Buscar por Codigo";
            this.buscarPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.buscarPorCodigoToolStripMenuItem_Click);
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            this.buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            this.buscarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.buscarPorNombreToolStripMenuItem.Text = "Buscar por Nombre";
            this.buscarPorNombreToolStripMenuItem.Click += new System.EventHandler(this.buscarPorNombreToolStripMenuItem_Click);
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 389);
            this.Controls.Add(this.dgrProveedor);
            this.Controls.Add(this.btnBajaProveedores);
            this.Controls.Add(this.btnModifProveedores);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AgregarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProveedor";
            this.Load += new System.EventHandler(this.AgregarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProveedor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnModifProveedores;
        private System.Windows.Forms.Button btnBajaProveedores;
        private System.Windows.Forms.DataGridView dgrProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem;
    }
}