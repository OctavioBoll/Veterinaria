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
    public partial class BuscarMedCodigo : Form
    {
        public BuscarMedCodigo()
        {
            InitializeComponent();
        }

        private void BuscarMedCodigo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaMedicamento.DataSource = AD_CargarGrillas.CargarGrillaMedicamentos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de medicamentos");
            }

        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int codMed = int.Parse(txtCodigoMed.Text.ToString());
                dgrGrillaMedicamento.DataSource = AD_ObtenerDatos.ObtenerMedicamentoPorCodigo(codMed);
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese tipos de datos validos");
                LimpiarCampos();
            }
        }


        private void LimpiarCampos()
        {
            txtCodigoMed.Text = "";
        }


    }
}

