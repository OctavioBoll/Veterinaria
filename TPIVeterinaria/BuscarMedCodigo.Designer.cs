namespace TPIVeterinaria
{
    partial class BuscarMedCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarMedCodigo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoMed = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgrGrillaMedicamento = new System.Windows.Forms.DataGridView();
            this.CodMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrillaMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Medicamento:";
            // 
            // txtCodigoMed
            // 
            this.txtCodigoMed.Location = new System.Drawing.Point(184, 88);
            this.txtCodigoMed.Name = "txtCodigoMed";
            this.txtCodigoMed.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMed.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_search_2427697;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Location = new System.Drawing.Point(290, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgrGrillaMedicamento
            // 
            this.dgrGrillaMedicamento.AllowUserToAddRows = false;
            this.dgrGrillaMedicamento.AllowUserToDeleteRows = false;
            this.dgrGrillaMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrGrillaMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMed,
            this.Precio,
            this.Descripcion,
            this.CodigoProveedor});
            this.dgrGrillaMedicamento.Location = new System.Drawing.Point(12, 133);
            this.dgrGrillaMedicamento.Name = "dgrGrillaMedicamento";
            this.dgrGrillaMedicamento.ReadOnly = true;
            this.dgrGrillaMedicamento.Size = new System.Drawing.Size(511, 218);
            this.dgrGrillaMedicamento.TabIndex = 4;
            // 
            // CodMed
            // 
            this.CodMed.DataPropertyName = "cod_medicamento";
            this.CodMed.HeaderText = "Codigo Medicamento";
            this.CodMed.Name = "CodMed";
            this.CodMed.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // CodigoProveedor
            // 
            this.CodigoProveedor.DataPropertyName = "mat_lab_prov";
            this.CodigoProveedor.HeaderText = "Codigo del Proveedor";
            this.CodigoProveedor.Name = "CodigoProveedor";
            this.CodigoProveedor.ReadOnly = true;
            // 
            // BuscarMedCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 385);
            this.Controls.Add(this.dgrGrillaMedicamento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarMedCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarMedCodigo";
            this.Load += new System.EventHandler(this.BuscarMedCodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrillaMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoMed;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgrGrillaMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProveedor;
    }
}