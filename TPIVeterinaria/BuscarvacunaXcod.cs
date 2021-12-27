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
    public partial class BuscarvacunaXcod : Form
    {
        public BuscarvacunaXcod()
        {
            InitializeComponent();
        }

        private void BuscarvacunaXcod_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtCodVac.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaVacunas.DataSource = AD_CargarGrillas.CargarGrillaVacunas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de vacunas");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int codVac = int.Parse(txtCodVac.Text.ToString());
            
                dgrGrillaVacunas.DataSource = AD_ObtenerDatos.ObtenerVacuna(codVac);
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
