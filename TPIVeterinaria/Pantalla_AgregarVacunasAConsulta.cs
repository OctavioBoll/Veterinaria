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
    public partial class Pantalla_AgregarVacunasAConsulta : Form
    {
        List<Vacunas> Lvac = new List<Vacunas>();
        public Pantalla_AgregarVacunasAConsulta(List<Vacunas> L)
        {
            InitializeComponent();
            Lvac = L;
        }

        private void Pantalla_AgregarVacunasAConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultadoVac = AD_ObtenerDatos.ObtenerVacuna(int.Parse(txtCodVac.Text));
                if (tablaResultadoVac.Rows.Count > 0)
                {
                    txtCodVac.Text = tablaResultadoVac.Rows[0][0].ToString();
                    txtDescVac.Text = tablaResultadoVac.Rows[0][2].ToString();
                    txtPrecioVac.Text = tablaResultadoVac.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Vacuna inexistente");
                    txtCodVac.Focus();
                    txtDescVac.Text = " ";
                    txtPrecioVac.Text = " ";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener vacuna");
            }

        }

        private void btnAgregarVacuna_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Vacunas v = new Vacunas();
                v.CodigoVacuna = int.Parse(txtCodVac.Text);
                v.NombreVacuna = txtDescVac.Text;
                v.PrecioVacuna = float.Parse(txtPrecioVac.Text);


                Lvac.Add(v);

                grillaVacunas.Rows.Add(txtCodVac.Text, txtDescVac.Text, txtPrecioVac.Text);
            }
            else
            {
                MessageBox.Show("Hay campos vacios, no es posible agregar vacuna");
            }

        }

        private bool validarCampos()
        {
            bool resultado = true;
            if(txtCodVac.Text == "" || txtDescVac.Text == "" || txtPrecioVac.Text == "")
            {
                resultado = false;
            }
            return resultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}