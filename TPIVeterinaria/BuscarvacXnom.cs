using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPIVeterinaria.Funcionalidades;

namespace TPIVeterinaria
{
    public partial class BuscarvacXnom : Form
    {
        public BuscarvacXnom()
        {
            InitializeComponent();
        }

        private void BuscarvacXnom_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtnomVac.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaVacunas.DataSource = AD_CargarGrillas.CargarGrillaVacunas();
            }
            catch (Exception )
            {
                MessageBox.Show("Error al obtener el listado de vacunas");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                string nomVac = txtnomVac.Text.ToString();
                dgrGrillaVacunas.DataSource = AD_ObtenerDatos.ObtenerVacunaXnom(nomVac);
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese tipos de datos validos");
                LimpiarCampos();
            }
        }
    }
}
