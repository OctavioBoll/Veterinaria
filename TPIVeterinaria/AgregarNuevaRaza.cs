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
    public partial class AgregarNuevaRaza : Form
    {
        public AgregarNuevaRaza()
        {
            InitializeComponent();
        }

        private void AgregarNuevaRaza_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarRaza_Click(object sender, EventArgs e)
        {
            if (txtNombreRaza.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos");
                txtNombreRaza.Focus();
            }
            else
            {
                Raza ra = new Raza();
                ra.NombreRaza = txtNombreRaza.Text;
                ra.DescripcionRaza = txtDescripcion.Text;
                bool resultado = AD_AgregarDatosBD.AgregarRaza(ra);
                if (resultado)
                {
                    MessageBox.Show("Raza Agregada con Exito");
                    limpiarCampos();
                    txtNombreRaza.Focus();
                }
                else
                {
                    MessageBox.Show("Error al Ingresar la Raza a la Base de Datos");
                }
                this.Dispose();
            }
        }
        private void limpiarCampos()
        {
            txtNombreRaza.Text = "";
            txtDescripcion.Text = "";

        }
    }
}
