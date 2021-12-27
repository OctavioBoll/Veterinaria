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
    public partial class BuscarProveedorCodigo : Form
    {
        public BuscarProveedorCodigo()
        {
            InitializeComponent();
        }

        private void BuscarProveedorCodigo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtCodProv.Text = "";
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int codProv = int.Parse(txtCodProv.Text.ToString());
                dgrGrillaProveedor.DataSource = AD_ObtenerDatos.ConsultarProveedorPorCodigoProv(codProv);
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
