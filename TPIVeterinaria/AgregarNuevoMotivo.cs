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
    public partial class AgregarNuevoMotivo : Form
    {
        public AgregarNuevoMotivo()
        {
            InitializeComponent();
        }
        private bool ValidarCampos()
        {
            bool resultado = false;

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Llene el campo Nombre");
                txtNombre.Focus();
                return resultado;
            }
            if (txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Llene el campo Descripcion");
                txtDescripcion.Focus();
                return resultado;
            }
            resultado = true;
            return resultado;
        }

        private void btn_Click(object sender, EventArgs e)
        {

            bool resultado = ValidarCampos();
            if (resultado)
            {
                Motivo motivo = new Motivo();
                motivo.NombreMotivo = txtNombre.Text;
                motivo.DescripcionMotivo = txtDescripcion.Text;

                bool resulInsert = AD_AgregarDatosBD.AgregarMotivo(motivo);
                if (resulInsert)
                {
                    MessageBox.Show("El Motivo se agrego con exito");
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("No se pudo agregar el Motivo\nSi persisten los probles intente mas tarde");

                }                    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
