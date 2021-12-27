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
    public partial class AgregarNuevoTurno : Form
    {
        public AgregarNuevoTurno()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado = ValidarCampos();
            if (resultado)
            {
                Turno turno = new Turno();
                try
                {
                    turno.HoraTurno = TimeSpan.Parse(mskHora.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese correctamente la hora, complete con ceros si es necesario");
                    return;
                }
                turno.FechaTurno = dtpFecha.Value.Date;
                turno.IdServicioTurno = (int)cmbTipoServicio.SelectedValue;
                turno.NroHistorialClinicoTurno = int.Parse(mskNroHist.Text.Trim());

                bool resulInsert = AD_AgregarDatosBD.AgregarTurno(turno);
                if (resulInsert)
                {
                    MessageBox.Show("Se agrego el Turno con exito");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el turno \nIngrese correctamente los datos y valide los necesarios");
                }
            }
            
        }

        private bool ValidarCampos()
        {
            bool resultado = false;
            if (mskHora.Text.Trim().Equals(":"))
            {
                MessageBox.Show("Llene el campo Hora");
                return resultado;
            }
            if (cmbTipoServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Llene el campo de Servicio");
                return resultado;
            }
            if (mskNroHist.Text.Trim().Equals(""))
            {
                MessageBox.Show("Llene el campo de Nro de Hist. Clinica");
                return resultado;
            }
            resultado = true;
            return resultado;
        }

        private void AgregarNuevoTurno_Load(object sender, EventArgs e)
        {
            CargarComboTipoServicio();
        }
        private void CargarComboTipoServicio()
        {
            cmbTipoServicio.DataSource = AD_CargarCombos.CargarComboGenerico("SERVICIOS");
            cmbTipoServicio.DisplayMember = "nombre";
            cmbTipoServicio.ValueMember = "id_servicio";
            cmbTipoServicio.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnValidarNroHist_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            if (mskNroHist.Text.Trim().Equals(""))
            {
                lblValidarNroHist.Text = "Llene el campo";

                return;
            }
            try
            {
                resultado = AD_ObtenerDatos.ValidarNorHistClinica(int.Parse(mskNroHist.Text));
            }
            catch (Exception)
            {
                resultado = false;
            }

            if (resultado)
            {
                lblValidarNroHist.Text = "Correcto";
            }
            else
            {
                lblValidarNroHist.Text = "No existente";
            }
        }
    
    }
}
