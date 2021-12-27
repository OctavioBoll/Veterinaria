namespace TPIVeterinaria
{
    partial class ActualizarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarTurno));
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.txtNroHistorial = new System.Windows.Forms.TextBox();
            this.txtNroTurno = new System.Windows.Forms.Label();
            this.lblNroHistorialClinico = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCancelar
            // 
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(86, 247);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(97, 36);
            this.bntCancelar.TabIndex = 18;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(213, 247);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 36);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // mskHora
            // 
            this.mskHora.Location = new System.Drawing.Point(164, 98);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(100, 20);
            this.mskHora.TabIndex = 10;
            this.mskHora.Text = "0000";
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(164, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.Value = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(164, 139);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoServicio.TabIndex = 12;
            // 
            // txtNroHistorial
            // 
            this.txtNroHistorial.Location = new System.Drawing.Point(164, 182);
            this.txtNroHistorial.Name = "txtNroHistorial";
            this.txtNroHistorial.Size = new System.Drawing.Size(117, 20);
            this.txtNroHistorial.TabIndex = 14;
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.AutoSize = true;
            this.txtNroTurno.Location = new System.Drawing.Point(161, 21);
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(22, 13);
            this.txtNroTurno.TabIndex = 17;
            this.txtNroTurno.Text = "nro";
            // 
            // lblNroHistorialClinico
            // 
            this.lblNroHistorialClinico.AutoSize = true;
            this.lblNroHistorialClinico.BackColor = System.Drawing.Color.Transparent;
            this.lblNroHistorialClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroHistorialClinico.Location = new System.Drawing.Point(19, 183);
            this.lblNroHistorialClinico.Name = "lblNroHistorialClinico";
            this.lblNroHistorialClinico.Size = new System.Drawing.Size(135, 15);
            this.lblNroHistorialClinico.TabIndex = 15;
            this.lblNroHistorialClinico.Text = "Nro de Hist. Clinico:";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(40, 140);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(114, 15);
            this.lblTipoServicio.TabIndex = 13;
            this.lblTipoServicio.Text = "Tipo de Servicio:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(112, 99);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 15);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(104, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 15);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNroTurno
            // 
            this.lblNroTurno.AutoSize = true;
            this.lblNroTurno.BackColor = System.Drawing.Color.Transparent;
            this.lblNroTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroTurno.Location = new System.Drawing.Point(59, 21);
            this.lblNroTurno.Name = "lblNroTurno";
            this.lblNroTurno.Size = new System.Drawing.Size(95, 15);
            this.lblNroTurno.TabIndex = 7;
            this.lblNroTurno.Text = "Nro de Turno:";
            // 
            // ActualizarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::TPIVeterinaria.Properties.Resources.pngwing2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 295);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.txtNroHistorial);
            this.Controls.Add(this.txtNroTurno);
            this.Controls.Add(this.lblNroHistorialClinico);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNroTurno);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActualizarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarTurno";
            this.Load += new System.EventHandler(this.ActualizarTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.TextBox txtNroHistorial;
        private System.Windows.Forms.Label txtNroTurno;
        private System.Windows.Forms.Label lblNroHistorialClinico;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroTurno;
    }
}