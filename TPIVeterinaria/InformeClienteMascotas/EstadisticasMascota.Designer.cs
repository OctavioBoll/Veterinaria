namespace TPIVeterinaria.InformeClienteMascotas
{
    partial class EstadisticasMascota
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.GrupoBox = new System.Windows.Forms.GroupBox();
            this.btnBuscarRaza = new System.Windows.Forms.Button();
            this.btnBuscarEspecie = new System.Windows.Forms.Button();
            this.btnBuscarSexo = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.TablaMascotaRazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TablasEstadisticas = new TPIVeterinaria.InformeClienteMascotas.TablasEstadisticas();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GrupoBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMascotaRazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablasEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataMascotaRaza";
            reportDataSource1.Value = this.TablaMascotaRazaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeClienteMascotas.ReportMascotaXRaza.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(762, 302);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estadisticas Mascotas";
            // 
            // GrupoBox
            // 
            this.GrupoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoBox.Controls.Add(this.label2);
            this.GrupoBox.Controls.Add(this.btnBuscarSexo);
            this.GrupoBox.Controls.Add(this.btnBuscarEspecie);
            this.GrupoBox.Controls.Add(this.btnBuscarRaza);
            this.GrupoBox.Location = new System.Drawing.Point(12, 32);
            this.GrupoBox.Name = "GrupoBox";
            this.GrupoBox.Size = new System.Drawing.Size(772, 98);
            this.GrupoBox.TabIndex = 2;
            this.GrupoBox.TabStop = false;
            // 
            // btnBuscarRaza
            // 
            this.btnBuscarRaza.Location = new System.Drawing.Point(7, 19);
            this.btnBuscarRaza.Name = "btnBuscarRaza";
            this.btnBuscarRaza.Size = new System.Drawing.Size(213, 47);
            this.btnBuscarRaza.TabIndex = 0;
            this.btnBuscarRaza.Text = "Ver por Raza";
            this.btnBuscarRaza.UseVisualStyleBackColor = true;
            this.btnBuscarRaza.Click += new System.EventHandler(this.btnBuscarRaza_Click);
            // 
            // btnBuscarEspecie
            // 
            this.btnBuscarEspecie.Location = new System.Drawing.Point(267, 19);
            this.btnBuscarEspecie.Name = "btnBuscarEspecie";
            this.btnBuscarEspecie.Size = new System.Drawing.Size(213, 47);
            this.btnBuscarEspecie.TabIndex = 1;
            this.btnBuscarEspecie.Text = "Ver por Especie";
            this.btnBuscarEspecie.UseVisualStyleBackColor = true;
            this.btnBuscarEspecie.Click += new System.EventHandler(this.btnBuscarEspecie_Click);
            // 
            // btnBuscarSexo
            // 
            this.btnBuscarSexo.Location = new System.Drawing.Point(536, 19);
            this.btnBuscarSexo.Name = "btnBuscarSexo";
            this.btnBuscarSexo.Size = new System.Drawing.Size(213, 47);
            this.btnBuscarSexo.TabIndex = 2;
            this.btnBuscarSexo.Text = "Ver por Sexo";
            this.btnBuscarSexo.UseVisualStyleBackColor = true;
            this.btnBuscarSexo.Click += new System.EventHandler(this.btnBuscarSexo_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeClienteMascotas.ReportMascotasXEspecie.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(762, 302);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TPIVeterinaria.InformeClienteMascotas.ReportMascotasXSexo.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(762, 270);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Apretar Actualizar si no se Cargan las Estadistica";
            // 
            // TablaMascotaRazaBindingSource
            // 
            this.TablaMascotaRazaBindingSource.DataMember = "TablaMascotaRaza";
            this.TablaMascotaRazaBindingSource.DataSource = this.TablasEstadisticas;
            // 
            // TablasEstadisticas
            // 
            this.TablasEstadisticas.DataSetName = "TablasEstadisticas";
            this.TablasEstadisticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstadisticasMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrupoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "EstadisticasMascota";
            this.Text = "EstadisticasMascota";
            this.Load += new System.EventHandler(this.EstadisticasMascota_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.GrupoBox.ResumeLayout(false);
            this.GrupoBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaMascotaRazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablasEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrupoBox;
        private System.Windows.Forms.Button btnBuscarSexo;
        private System.Windows.Forms.Button btnBuscarEspecie;
        private System.Windows.Forms.Button btnBuscarRaza;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource TablaMascotaRazaBindingSource;
        private TablasEstadisticas TablasEstadisticas;
        private System.Windows.Forms.Label label2;
    }
}