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
    public partial class ActualizarTurno : Form
    {
        private Turno turnoSelecionado;
        public ActualizarTurno(Turno turno)
        {
            InitializeComponent();
            turnoSelecionado = turno;
        }

        private void ActualizarTurno_Load(object sender, EventArgs e)
        {
            CargarComboTipoServicio();
            txtNroTurno.Text = turnoSelecionado.NroTurno.ToString();
            dtpFecha.Value = turnoSelecionado.FechaTurno.Date;
            //MessageBox.Show(dtpFecha.Value.ToString() + "\n" + turnoSelecionado.FechaTurno.ToString());
            mskHora.Text = turnoSelecionado.HoraTurno.ToString();
            //MessageBox.Show(mskHora.Text + "\n" + turnoSelecionado.HoraTurno.ToString());
            cmbTipoServicio.SelectedValue = turnoSelecionado.IdServicioTurno;
            txtNroHistorial.Text = turnoSelecionado.NroHistorialClinicoTurno.ToString();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool resultado;
            turnoSelecionado.FechaTurno = dtpFecha.Value;
            turnoSelecionado.HoraTurno = TimeSpan.Parse(mskHora.Text);
            turnoSelecionado.IdServicioTurno = (int)cmbTipoServicio.SelectedValue;
            turnoSelecionado.NroHistorialClinicoTurno = int.Parse(txtNroHistorial.Text);
            resultado = AD_ActualizarDatos.ActualizarTurno(turnoSelecionado);
            if (resultado)
            {
                MessageBox.Show("El turno fue modificado con exito");
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el Turno a la base de datos");
            }

        }
        private void CargarComboTipoServicio()
        {
            cmbTipoServicio.DataSource = AD_CargarCombos.CargarComboGenerico("SERVICIOS");
            cmbTipoServicio.DisplayMember = "nombre";
            cmbTipoServicio.ValueMember = "id_servicio";
            cmbTipoServicio.SelectedIndex = -1;
        }
    }
}
