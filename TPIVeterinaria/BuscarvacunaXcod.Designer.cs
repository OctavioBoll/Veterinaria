namespace TPIVeterinaria
{
    partial class BuscarvacunaXcod
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
            this.dgrGrillaVacunas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodVac = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.CodigoVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrillaVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrGrillaVacunas
            // 
            this.dgrGrillaVacunas.AllowUserToAddRows = false;
            this.dgrGrillaVacunas.AllowUserToDeleteRows = false;
            this.dgrGrillaVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrGrillaVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoVac,
            this.Precio,
            this.Nombre});
            this.dgrGrillaVacunas.Location = new System.Drawing.Point(28, 127);
            this.dgrGrillaVacunas.Name = "dgrGrillaVacunas";
            this.dgrGrillaVacunas.ReadOnly = true;
            this.dgrGrillaVacunas.Size = new System.Drawing.Size(353, 270);
            this.dgrGrillaVacunas.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar Vacuna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo de Vacuna:";
            // 
            // txtCodVac
            // 
            this.txtCodVac.Location = new System.Drawing.Point(169, 78);
            this.txtCodVac.Name = "txtCodVac";
            this.txtCodVac.Size = new System.Drawing.Size(100, 20);
            this.txtCodVac.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::TPIVeterinaria.Properties.Resources.iconfinder_search_2427697;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(275, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CodigoVac
            // 
            this.CodigoVac.DataPropertyName = "cod_vacuna";
            this.CodigoVac.HeaderText = "Codigo Vacuna";
            this.CodigoVac.Name = "CodigoVac";
            this.CodigoVac.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "descripcion";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // BuscarvacunaXcod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.dgrGrillaVacunas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodVac);
            this.DoubleBuffered = true;
            this.Name = "BuscarvacunaXcod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarvacunaXcod";
            this.Load += new System.EventHandler(this.BuscarvacunaXcod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrillaVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrGrillaVacunas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}