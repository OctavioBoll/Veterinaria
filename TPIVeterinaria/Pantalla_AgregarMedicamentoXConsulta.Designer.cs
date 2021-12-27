namespace TPIVeterinaria
{
    partial class Pantalla_AgregarMedicamentoXConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_AgregarMedicamentoXConsulta));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.grillamedicamento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarMed = new System.Windows.Forms.Button();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroProv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillamedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(131, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.Location = new System.Drawing.Point(253, 392);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMed.TabIndex = 16;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.UseVisualStyleBackColor = true;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // grillamedicamento
            // 
            this.grillamedicamento.AllowUserToAddRows = false;
            this.grillamedicamento.AllowUserToDeleteRows = false;
            this.grillamedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillamedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Precio,
            this.Nombre,
            this.NroProveedor,
            this.Cantidad});
            this.grillamedicamento.Location = new System.Drawing.Point(64, 208);
            this.grillamedicamento.Name = "grillamedicamento";
            this.grillamedicamento.ReadOnly = true;
            this.grillamedicamento.Size = new System.Drawing.Size(350, 150);
            this.grillamedicamento.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NroProveedor
            // 
            this.NroProveedor.HeaderText = "Nro Proveedor";
            this.NroProveedor.Name = "NroProveedor";
            this.NroProveedor.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnAgregarMed
            // 
            this.btnAgregarMed.Location = new System.Drawing.Point(271, 168);
            this.btnAgregarMed.Name = "btnAgregarMed";
            this.btnAgregarMed.Size = new System.Drawing.Size(147, 23);
            this.btnAgregarMed.TabIndex = 14;
            this.btnAgregarMed.Text = "Agregar Medicamento";
            this.btnAgregarMed.UseVisualStyleBackColor = true;
            this.btnAgregarMed.Click += new System.EventHandler(this.btnAgregarMed_Click);
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.Location = new System.Drawing.Point(118, 84);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMed.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // txtCodMed
            // 
            this.txtCodMed.Enabled = false;
            this.txtCodMed.Location = new System.Drawing.Point(118, 47);
            this.txtCodMed.Name = "txtCodMed";
            this.txtCodMed.Size = new System.Drawing.Size(100, 20);
            this.txtCodMed.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo:";
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Location = new System.Drawing.Point(118, 168);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(109, 23);
            this.btnBuscarCod.TabIndex = 9;
            this.btnBuscarCod.Text = "Buscar por Nombre";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(314, 84);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Precio:";
            // 
            // txtNroProv
            // 
            this.txtNroProv.Enabled = false;
            this.txtNroProv.Location = new System.Drawing.Point(314, 47);
            this.txtNroProv.Name = "txtNroProv";
            this.txtNroProv.Size = new System.Drawing.Size(100, 20);
            this.txtNroProv.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nro Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Agregar Medicamento";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(314, 128);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cantidad:";
            // 
            // Pantalla_AgregarMedicamentoXConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.grillamedicamento);
            this.Controls.Add(this.btnAgregarMed);
            this.Controls.Add(this.txtNombreMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodMed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarCod);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_AgregarMedicamentoXConsulta";
            this.Text = "Agregar Medicamento por Consulta";
            this.Load += new System.EventHandler(this.Pantalla_AgregarMedicamentoXConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillamedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarMed;
        private System.Windows.Forms.DataGridView grillamedicamento;
        private System.Windows.Forms.Button btnAgregarMed;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}