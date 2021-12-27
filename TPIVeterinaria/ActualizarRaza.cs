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
    public partial class ActualizarRaza : Form
    {
        private Raza raza;
        public ActualizarRaza(Raza razaSeleccionada)
        {
            InitializeComponent();
            raza = razaSeleccionada;
        }

        private void ActualizarRaza_Load(object sender, EventArgs e)
        {
            cargarCampos();
        }


        private void cargarCampos()
        {
            txtId.Text = raza.IdRaza.ToString();
            txtNombreRaza.Text = raza.NombreRaza;
            txtDescripcion.Text = raza.DescripcionRaza;

        }

        private void btnModificarRaza_Click(object sender, EventArgs e)
        {
            raza.NombreRaza = txtNombreRaza.Text;
            raza.DescripcionRaza = txtDescripcion.Text;
            bool resultado = AD_ActualizarDatos.ActualizarRaza(raza);
            if (resultado)
            {
                MessageBox.Show("La Raza fue actualizada");
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR... No se pudo actualizar la raza");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
