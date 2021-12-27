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
    public partial class AgregarTurno : Form
    {
        private Turno TurnoSeleciocnado = new Turno();
        private int NroTurnoSeleccionado;
        public AgregarTurno()
        {
            InitializeComponent();
        }

        private void AgregarTurno_Load(object sender, EventArgs e)
        {
            txtNroTurno.Enabled = false;
            dtpFecha.Enabled = false;
            cmbTipoServicio.Enabled = false;
            CargardgvTurnos();
            CargarComboTipoServicio();
            ttpBtn.ShowAlways = true;
            ttpBtn.InitialDelay = 0;
            ttpBtn.ReshowDelay = 0;
            ttpBtn.AutoPopDelay = 1000;
        }


        private void chbNroTruno_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNroTruno.Checked)
            {
                txtNroTurno.Enabled = true;
            }
            else
            {
                txtNroTurno.Enabled = false;
            }
        }

        private void CargarComboTipoServicio()
        {
            cmbTipoServicio.DataSource = AD_CargarCombos.CargarComboGenerico("SERVICIOS");
            cmbTipoServicio.DisplayMember = "nombre";
            cmbTipoServicio.ValueMember = "id_servicio";
            cmbTipoServicio.SelectedIndex = -1;
        }

        private void chbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFecha.Checked)
            {
                dtpFecha.Enabled = true;
            }
            else
            {
                dtpFecha.Enabled = false;
            }
        }

        private void chbTipoServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTipoServicio.Checked)
            {
                cmbTipoServicio.Enabled = true;
            }
            else
            {
                cmbTipoServicio.Enabled = false;
            }
        }


        private void CargardgvTurnos()
        {
            dgvTurnos.DataSource = AD_CargarGrillas.CargarGrillaTurnos();

        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            if (indice >= 0)
            {

                DataGridViewRow filaSeleccionada = dgvTurnos.Rows[indice];
                NroTurnoSeleccionado = (int)filaSeleccionada.Cells["nroTurnos"].Value;
                TurnoSeleciocnado.NroTurno = NroTurnoSeleccionado;
                //MessageBox.Show(NroTurnoSeleccionado.ToString);
                TurnoSeleciocnado.FechaTurno = (DateTime)filaSeleccionada.Cells["Fecha"].Value;
                TurnoSeleciocnado.HoraTurno = (TimeSpan)filaSeleccionada.Cells["Hora"].Value;
                TurnoSeleciocnado.IdServicioTurno = (int)filaSeleccionada.Cells["IdServicio"].Value;
                TurnoSeleciocnado.NroHistorialClinicoTurno = (int)filaSeleccionada.Cells["NroHistorialClinico"].Value;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (NroTurnoSeleccionado != 0)
            {
                DialogResult resultDialogo = MessageBox.Show("Esta seguro que quiere borrar el turno", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultDialogo == DialogResult.Yes)
                {
                    bool resultado = AD_EliminarDatos.EliminarTurno(NroTurnoSeleccionado);
                    if (resultado)
                    {
                        CargardgvTurnos();
                        MessageBox.Show("El Turno fue elminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar");
                    }
                }
            }
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            ttpBtn.Show("Buscar", btnBuscar);
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
            if (NroTurnoSeleccionado != 0)
            {
                ActualizarTurno ventana = new ActualizarTurno(TurnoSeleciocnado);
                ventana.ShowDialog();
                ventana.Dispose();
                CargardgvTurnos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaTurno = AD_CargarGrillas.CargarGrillaTurnos();


                if (txtNroTurno.Enabled)
                {
                    if (txtNroTurno.Text.Equals(""))
                    {
                        MessageBox.Show("LLene el campo Nro Turno o deshabilitelo");
                        return;
                    }
                    else
                    {
                        DataTable tableAux = tablaTurno.Clone();
                        foreach (DataRow dr in tablaTurno.Rows)
                        {
                            if (dr["nro_turno"].ToString() == txtNroTurno.Text.Trim())
                            {
                                tableAux.ImportRow(dr);
                            }
                        }
                        tablaTurno = tableAux;
                    }
                }
                if (dtpFecha.Enabled)
                {
                    DataTable tableAux = tablaTurno.Clone();
                    foreach (DataRow dr in tablaTurno.Rows)
                    {
                        if (((DateTime)dr["fecha"]).Date == dtpFecha.Value.Date)
                        {
                            tableAux.ImportRow(dr);
                        }
                    }
                    tablaTurno = tableAux;
                }
                if (cmbTipoServicio.Enabled)
                {
                    if (cmbTipoServicio.SelectedIndex == -1)
                    {
                        MessageBox.Show("LLene el campo Nro Turno o deshabilitelo");
                        return;
                    }
                    else
                    {
                        DataTable tableAux = tablaTurno.Clone();
                        foreach (DataRow dr in tablaTurno.Rows)
                        {
                            if ((int)dr["id_servicio"] == (int)cmbTipoServicio.SelectedValue)
                            {
                                tableAux.ImportRow(dr);
                            }
                        }
                        tablaTurno = tableAux;
                    }
                }

                dgvTurnos.DataSource = tablaTurno;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR no se pudo realizar la Busqueda");
            }
        }

        private void btnAltaConsulta_Click(object sender, EventArgs e)
        {
            AgregarNuevoTurno ventana = new AgregarNuevoTurno();
            ventana.ShowDialog();
            ventana.Dispose();
            CargardgvTurnos();
        }
    }
}
