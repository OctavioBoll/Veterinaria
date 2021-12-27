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
    public partial class AgregarRaza : Form
    {
        private int IdRazaSeleccionada;
        private Raza razaSeleccionada = new Raza();
        public AgregarRaza()
        {
            InitializeComponent();
        }

        private void AgregarRaza_Load(object sender, EventArgs e)
        {
            cargarDgvListaRazas();
            ttpBtn.ShowAlways = true;
            ttpBtn.InitialDelay = 0;
            ttpBtn.ReshowDelay = 0;
            ttpBtn.AutoPopDelay = 1000;
        }

        private void cargarDgvListaRazas()
        {
            dgvListadoRazas.DataSource = AD_CargarGrillas.CargarGrillaRazas();
        }


        private void btnAltaRaza_Click(object sender, EventArgs e)
        {
            AgregarNuevaRaza ventana = new AgregarNuevaRaza();
            ventana.ShowDialog();
            cargarDgvListaRazas();
            ventana.Dispose();
        }



        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            ttpBtn.Show("Actualizar", btnActualizar);
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            ttpBtn.Show("Eliminar", btnEliminar);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdRazaSeleccionada != 0)
            {
                ActualizarRaza ventana = new ActualizarRaza(razaSeleccionada);
                ventana.ShowDialog();
                ventana.Dispose();
                cargarDgvListaRazas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdRazaSeleccionada != 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que quiere borrar la raza de Id: " + IdRazaSeleccionada, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    bool confirmacio = AD_EliminarDatos.EliminarRaza(IdRazaSeleccionada);
                    if (confirmacio)
                    {
                        MessageBox.Show("Raza eliminada");
                        cargarDgvListaRazas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eleiminar la Raza .Problemas al ejecutar la accion");
                    }
                }
            }
        }

        private void dgvListadoRazas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                ttpBtn.ShowAlways = false;
                DataGridViewRow filaSeleccionada = dgvListadoRazas.Rows[indice];
                IdRazaSeleccionada = (int)filaSeleccionada.Cells["IdRaza"].Value;
                razaSeleccionada.IdRaza = IdRazaSeleccionada;
                razaSeleccionada.NombreRaza = (string)filaSeleccionada.Cells["nombre"].Value;
                if ("System.DBNull" == (filaSeleccionada.Cells["descripcion"].Value).GetType().ToString())
                {
                    razaSeleccionada.DescripcionRaza = "";
                }

                else
                {
                    razaSeleccionada.DescripcionRaza = (string)filaSeleccionada.Cells["descripcion"].Value;
                }
            }
        }
    }
}
