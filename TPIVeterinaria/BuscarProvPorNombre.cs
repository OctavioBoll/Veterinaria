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
    public partial class BuscarProvPorNombre : Form
    {
        public BuscarProvPorNombre()
        {
            InitializeComponent();
        }

        private void BuscarProvPorNombre_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaProveedor.DataSource = AD_CargarGrillas.CargarGrillaProveedores();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de proveedores");
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nomProv = txtNombre.Text.ToString();
                dgrGrillaProveedor.DataSource = AD_ObtenerDatos.ConsultarProveedorPorNombreProv(nomProv);
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
