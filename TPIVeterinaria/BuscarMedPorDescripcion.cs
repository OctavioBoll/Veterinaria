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
    public partial class BuscarMedPorDescripcion : Form
    {
        public BuscarMedPorDescripcion()
        {
            InitializeComponent();
        }

        private void BuscarMedPorDescripcion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaMedicamentos.DataSource = AD_CargarGrillas.CargarGrillaMedicamentos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de medicamentos");
            }

        }


    private void BuscarPorDescripcionMedicamento_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtDesc.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string descripMed = txtDesc.Text.ToString();
            dgrGrillaMedicamentos.DataSource = AD_ObtenerDatos.ObtenerMedicamentoPorDescripcion(descripMed);
            LimpiarCampos();
        }
    }
}
