namespace TPIVeterinaria
{
    partial class Pantalla_AgregarVacunasAConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_AgregarVacunasAConsulta));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodVac = new System.Windows.Forms.TextBox();
            this.txtDescVac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioVac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarVacuna = new System.Windows.Forms.Button();
            this.grillaVacunas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(282, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar por Codigo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Vacuna:";
            // 
            // txtCodVac
            // 
            this.txtCodVac.Location = new System.Drawing.Point(133, 49);
            this.txtCodVac.Name = "txtCodVac";
            this.txtCodVac.Size = new System.Drawing.Size(100, 20);
            this.txtCodVac.TabIndex = 2;
            // 
            // txtDescVac
            // 
            this.txtDescVac.Enabled = false;
            this.txtDescVac.Location = new System.Drawing.Point(133, 83);
            this.txtDescVac.Name = "txtDescVac";
            this.txtDescVac.Size = new System.Drawing.Size(100, 20);
            this.txtDescVac.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // txtPrecioVac
            // 
            this.txtPrecioVac.Enabled = false;
            this.txtPrecioVac.Location = new System.Drawing.Point(133, 118);
            this.txtPrecioVac.Name = "txtPrecioVac";
            this.txtPrecioVac.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVac.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // btnAgregarVacuna
            // 
            this.btnAgregarVacuna.Location = new System.Drawing.Point(282, 86);
            this.btnAgregarVacuna.Name = "btnAgregarVacuna";
            this.btnAgregarVacuna.Size = new System.Drawing.Size(110, 48);
            this.btnAgregarVacuna.TabIndex = 7;
            this.btnAgregarVacuna.Text = "Agregar Vacuna a Consulta";
            this.btnAgregarVacuna.UseVisualStyleBackColor = true;
            this.btnAgregarVacuna.Click += new System.EventHandler(this.btnAgregarVacuna_Click);
            // 
            // grillaVacunas
            // 
            this.grillaVacunas.AllowUserToAddRows = false;
            this.grillaVacunas.AllowUserToDeleteRows = false;
            this.grillaVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio});
            this.grillaVacunas.Location = new System.Drawing.Point(47, 181);
            this.grillaVacunas.Name = "grillaVacunas";
            this.grillaVacunas.ReadOnly = true;
            this.grillaVacunas.Size = new System.Drawing.Size(345, 150);
            this.grillaVacunas.TabIndex = 8;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(252, 378);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(114, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Agregar Vacuna";
            // 
            // Pantalla_AgregarVacunasAConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grillaVacunas);
            this.Controls.Add(this.btnAgregarVacuna);
            this.Controls.Add(this.txtPrecioVac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescVac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodVac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_AgregarVacunasAConsulta";
            this.Text = "Agregar Vacunas a Consulta";
            this.Load += new System.EventHandler(this.Pantalla_AgregarVacunasAConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodVac;
        private System.Windows.Forms.TextBox txtDescVac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioVac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarVacuna;
        private System.Windows.Forms.DataGridView grillaVacunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
    }
}