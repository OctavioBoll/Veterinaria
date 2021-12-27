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
    public partial class AgregarMotivo : Form
    {
        private int IdSelecionada;
        private Motivo motivoSeleccionado = new Motivo();
        public AgregarMotivo()
        {
            InitializeComponent();
        }

        private void AgregarMotivo_Load(object sender, EventArgs e)
        {
            CargarDgvMotivos();
            txtIdMotivo.Enabled = false;
            txtNombreMotivo.Enabled = false;
            ttpBtn.ShowAlways = true;
            ttpBtn.InitialDelay = 0;
            ttpBtn.ReshowDelay = 0;
            ttpBtn.AutoPopDelay = 1000;
        }


        private void CargarDgvMotivos()
        {
            dgvMotivos.DataSource = AD_CargarGrillas.CargarGrillaMotivos();
        }


        private void dgvMotivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvMotivos.Rows[indice];
                IdSelecionada = (int)filaSeleccionada.Cells["id_motivo"].Value;
                motivoSeleccionado.IdMotivo = IdSelecionada;
                motivoSeleccionado.NombreMotivo = (string)filaSeleccionada.Cells["nombre"].Value;
                if ("System.DBNull" == (filaSeleccionada.Cells["descripcion"].Value).GetType().ToString())
                {
                    motivoSeleccionado.DescripcionMotivo = "";
                }
                else
                {
                    motivoSeleccionado.DescripcionMotivo = (string)filaSeleccionada.Cells["descripcion"].Value;
                }
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaMotivos = AD_CargarGrillas.CargarGrillaMotivos();

                if (txtIdMotivo.Enabled)
                {
                    if (txtIdMotivo.Text.Equals(""))
                    {
                        MessageBox.Show("Llene los campos habilitados o deshabilitelos");
                        return;
                    }
                    else
                    {
                        DataTable tablaAux = tablaMotivos.Clone();
                        foreach (DataRow dr in tablaMotivos.Rows)
                        {
                            if ((string)dr["id_motivo"] == txtIdMotivo.Text)
                            {
                                tablaAux.ImportRow(dr);
                            }
                        }
                        tablaMotivos = tablaAux;
                    }
                }
                if (txtNombreMotivo.Enabled)
                {
                    if (txtNombreMotivo.Text.Equals(""))
                    {
                        MessageBox.Show("Llene los campos habilitados o deshabilitelos");
                        return;
                    }
                    else
                    {
                        DataTable tablaAux = tablaMotivos.Clone();
                        foreach (DataRow dr in tablaMotivos.Rows)
                        {
                            if ((string)dr["nombre"] == txtNombreMotivo.Text)
                            {
                                tablaAux.ImportRow(dr);
                            }
                        }

                        tablaMotivos = tablaAux;
                    }
                }
                dgvMotivos.DataSource = tablaMotivos;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR el la Busqueda intente mas tarde");
            }


        }

        private void chbId_CheckedChanged(object sender, EventArgs e)
        {
            if (chbId.Checked)
            {
                txtIdMotivo.Enabled = true;
            }
            else
            {
                txtIdMotivo.Enabled = false;
            }
        }

        private void chbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNombre.Checked)
            {
                txtNombreMotivo.Enabled = true;
            }
            else
            {
                txtNombreMotivo.Enabled = false;
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdSelecionada != 0)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el Motivo de Consulta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    bool res = AD_EliminarDatos.EliminarMotivo(IdSelecionada);
                    if (res)
                    {
                        MessageBox.Show("Se elimino con exito");
                    }
                    else
                    {
                        MessageBox.Show("ERROR... No se pudo eliminar");
                    }
                }
                CargarDgvMotivos();
            }
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            ttpBtn.Show("Eliminar", btnEliminar);
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            ttpBtn.Show("Buscar", btnBuscar);
        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            ttpBtn.Show("Actualizar", btnActualizar);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdSelecionada != 0)
            {
                ModificarMotivo ventana = new ModificarMotivo(motivoSeleccionado);
                ventana.ShowDialog();
                ventana.Dispose();
                CargarDgvMotivos();
            }
        }

        private void btnAltaConsulta_Click(object sender, EventArgs e)
        {
            AgregarNuevoMotivo ventana = new AgregarNuevoMotivo();
            ventana.ShowDialog();
            ventana.Dispose();
            CargarDgvMotivos();
        }
    }
}
