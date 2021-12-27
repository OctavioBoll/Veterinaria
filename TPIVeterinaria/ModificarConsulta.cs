using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPIVeterinaria.Entidades;
using TPIVeterinaria.Funcionalidades;

namespace TPIVeterinaria
{
    public partial class ModificarConsulta : Form
    {
        private Consulta consultaSeleccionada;
        public ModificarConsulta(Consulta con)
        {
            InitializeComponent();
            consultaSeleccionada = con;
        }

        private void ModificarConsulta_Load(object sender, EventArgs e)
        {
            CargarComboTipoMotivo();
            CargarComboTipoDocumento();
            CargarCampos();
        }

        private void CargarComboTipoMotivo()
        {
            cmbMotivo.DataSource = AD_CargarCombos.CargarComboGenerico("MOTIVO");
            cmbMotivo.DisplayMember = "nombre";
            cmbMotivo.ValueMember = "id_motivo";
            cmbMotivo.SelectedIndex = -1;
        }
        private void CargarComboTipoDocumento()
        {
            cmbTipoDoc.DataSource = AD_CargarCombos.CargarComboGenerico("TIPOS_DOCUMENTOS");
            cmbTipoDoc.DisplayMember = "nombre_tipo_documento";
            cmbTipoDoc.ValueMember = "id_tipo_documento";
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void CargarCampos()
        {
            txtNroConsulta.Text = consultaSeleccionada.NroConsulta.ToString();
            txtNroHistCLI.Text = consultaSeleccionada.NroHistClinicaConsulta.ToString();
            cmbTipoDoc.SelectedValue = consultaSeleccionada.TipoDocEmpleadoConsulta;
            mskNrodoc.Text = consultaSeleccionada.NroDocEmpleadoConsulta;
            dtpFecha.Value = consultaSeleccionada.FechaConsulta.Date;
            mskHora.Text = consultaSeleccionada.HoraConsulta.ToString();
            cmbMotivo.SelectedValue = consultaSeleccionada.IdMotivoConsulta;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            consultaSeleccionada.NroHistClinicaConsulta = int.Parse(txtNroHistCLI.Text);
            consultaSeleccionada.TipoDocEmpleadoConsulta = (int)cmbTipoDoc.SelectedValue;
            consultaSeleccionada.NroDocEmpleadoConsulta = mskNrodoc.Text;
            consultaSeleccionada.FechaConsulta = dtpFecha.Value.Date;
            consultaSeleccionada.HoraConsulta = TimeSpan.Parse(mskHora.Text);
            consultaSeleccionada.IdMotivoConsulta = (int)cmbMotivo.SelectedValue;


            bool resultado = AD_ActualizarDatos.ActualizarConsulta(consultaSeleccionada);
            if (resultado)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error... no se pudo actualizar la Consulta");
            }
            this.Hide();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
