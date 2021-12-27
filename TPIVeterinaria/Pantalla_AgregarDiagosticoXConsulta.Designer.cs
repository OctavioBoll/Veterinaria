namespace TPIVeterinaria
{
    partial class Pantalla_AgregarDiagosticoXConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_AgregarDiagosticoXConsulta));
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDiag = new System.Windows.Forms.TextBox();
            this.txtNombreDiag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarDoag = new System.Windows.Forms.Button();
            this.grillaDiagnostico = new System.Windows.Forms.DataGridView();
            this.IdDiag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarDig = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Location = new System.Drawing.Point(278, 80);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(118, 23);
            this.btnBuscarCod.TabIndex = 0;
            this.btnBuscarCod.Text = "Buscar por id";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Diagnostico:";
            // 
            // txtIdDiag
            // 
            this.txtIdDiag.Location = new System.Drawing.Point(140, 80);
            this.txtIdDiag.Name = "txtIdDiag";
            this.txtIdDiag.Size = new System.Drawing.Size(100, 20);
            this.txtIdDiag.TabIndex = 2;
            // 
            // txtNombreDiag
            // 
            this.txtNombreDiag.Enabled = false;
            this.txtNombreDiag.Location = new System.Drawing.Point(140, 117);
            this.txtNombreDiag.Name = "txtNombreDiag";
            this.txtNombreDiag.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDiag.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // btnAgregarDoag
            // 
            this.btnAgregarDoag.Location = new System.Drawing.Point(278, 117);
            this.btnAgregarDoag.Name = "btnAgregarDoag";
            this.btnAgregarDoag.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarDoag.TabIndex = 5;
            this.btnAgregarDoag.Text = "Agregar Diagnostico";
            this.btnAgregarDoag.UseVisualStyleBackColor = true;
            this.btnAgregarDoag.Click += new System.EventHandler(this.btnAgregarDoag_Click);
            // 
            // grillaDiagnostico
            // 
            this.grillaDiagnostico.AllowUserToAddRows = false;
            this.grillaDiagnostico.AllowUserToDeleteRows = false;
            this.grillaDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDiag,
            this.Nombre});
            this.grillaDiagnostico.Location = new System.Drawing.Point(59, 183);
            this.grillaDiagnostico.Name = "grillaDiagnostico";
            this.grillaDiagnostico.ReadOnly = true;
            this.grillaDiagnostico.Size = new System.Drawing.Size(337, 150);
            this.grillaDiagnostico.TabIndex = 6;
            // 
            // IdDiag
            // 
            this.IdDiag.HeaderText = "Id";
            this.IdDiag.Name = "IdDiag";
            this.IdDiag.ReadOnly = true;
            this.IdDiag.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // btnGuardarDig
            // 
            this.btnGuardarDig.Location = new System.Drawing.Point(251, 386);
            this.btnGuardarDig.Name = "btnGuardarDig";
            this.btnGuardarDig.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDig.TabIndex = 7;
            this.btnGuardarDig.Text = "Guardar";
            this.btnGuardarDig.UseVisualStyleBackColor = true;
            this.btnGuardarDig.Click += new System.EventHandler(this.btnGuardarDig_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(129, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Agregar Diagnosticos";
            // 
            // Pantalla_AgregarDiagosticoXConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarDig);
            this.Controls.Add(this.grillaDiagnostico);
            this.Controls.Add(this.btnAgregarDoag);
            this.Controls.Add(this.txtNombreDiag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdDiag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarCod);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_AgregarDiagosticoXConsulta";
            this.Text = "Agregar Diagostico por Consulta";
            this.Load += new System.EventHandler(this.Pantalla_AgregarDiagosticoXConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDiag;
        private System.Windows.Forms.TextBox txtNombreDiag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarDoag;
        private System.Windows.Forms.DataGridView grillaDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnGuardarDig;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
    }
}