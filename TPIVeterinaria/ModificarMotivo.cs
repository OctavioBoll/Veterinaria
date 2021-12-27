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
    public partial class ModificarMotivo : Form
    {
        private Motivo motivo;
        public ModificarMotivo(Motivo mt)
        {
            InitializeComponent();
            motivo = mt;
        }

        private void ModificarMotivo_Load(object sender, EventArgs e)
        {
            CargarCampos();
        }

        private void CargarCampos()
        {
            txtId.Text = motivo.IdMotivo.ToString();
            txtNombre.Text = motivo.NombreMotivo;
            txtDescripcion.Text = motivo.DescripcionMotivo;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            motivo.NombreMotivo = txtNombre.Text;
            motivo.DescripcionMotivo = txtDescripcion.Text;
            bool resultado = AD_ActualizarDatos.ActualizarMotivo(motivo);

            if (resultado)
            {

                MessageBox.Show("El motivo fue Modificar con exito");

            }
            else
            {
                MessageBox.Show("Error no se pudo actializar el Motivo");

            }
            this.Hide();
        }
    }
}
