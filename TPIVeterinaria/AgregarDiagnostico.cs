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
    public partial class AgregarDiagnostico : Form
    {
        public AgregarDiagnostico()
        {
            InitializeComponent();
        }
        private void AgregarDiagnostico_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }


        private void LimpiarCampos()
        {
            txtIdDiagno.Text = "";
            txtNombre.Text = "";
        }

        private void CargarCampos(Diagnostico v)
        {
            txtIdDiagno.Text = v.IdDiagnostico.ToString();
            txtNombre.Text = v.Nombrediagnostico;
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaDiagnostico.DataSource = AD_CargarGrillas.CargarGrillaDiagnostico();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de vacunas");
            }

        }

        private Diagnostico ObtenerDatosDiagnostico()
        {
            Diagnostico diag = new Diagnostico();

            try
            {
                diag.IdDiagnostico = int.Parse(txtIdDiagno.Text);
                diag.Nombrediagnostico = txtNombre.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar tipos de datos correctos");
            }
            return diag;
        }

        private void AgregarDiagnosticoAGrilla(Diagnostico diag)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaIdDiagno = new DataGridViewTextBoxCell();
            celdaIdDiagno.Value = diag.IdDiagnostico;
            fila.Cells.Add(celdaIdDiagno);

            DataGridViewTextBoxCell celdanombre = new DataGridViewTextBoxCell();
            celdanombre.Value = diag.Nombrediagnostico;
            fila.Cells.Add(celdanombre);
        }

        private bool ExisteEnGrillaDiagnostico(int iddiag)
        {
            bool resultado = false;

            for (int i = 0; i < dgrGrillaDiagnostico.Rows.Count; i++)
            {
                if (dgrGrillaDiagnostico.Rows[i].Cells["IdDiagno"].Value.Equals(iddiag))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            txtIdDiagno.Enabled = true;
            bool tieneCodigo = false;
            bool tieneNombre = false;
            bool existeEnGrilla = false;

            if (txtIdDiagno.Text.Equals(""))
            {
                MessageBox.Show("Ingrese ID del Diagnostico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdDiagno.Focus();
            }
            else
            {
                tieneCodigo = true;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el Diagnostico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();

            }
            else
            {
                tieneNombre = true;
            }

            try
            {
                existeEnGrilla = ExisteEnGrillaDiagnostico(int.Parse(txtIdDiagno.Text));
            }
            catch (Exception)
            {
                txtIdDiagno.Focus();
            }



            if (existeEnGrilla == true)
            {
                MessageBox.Show("El Diagnostico que quiere registrar ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tieneCodigo && tieneNombre && existeEnGrilla == false)
            {
                Diagnostico diag = ObtenerDatosDiagnostico();
                bool resultado = AD_AgregarDatosBD.AgregarDiagnosticoABD(diag);

                if (resultado)
                {
                    MessageBox.Show("Diagnostico agregada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AgregarDiagnosticoAGrilla(diag);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Diagnostico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdDiagno.Enabled = true;
            int iddiag = int.Parse(txtIdDiagno.Text);
            bool resultado = ExisteEnGrillaDiagnostico(iddiag);
            if (resultado)
            {
                LimpiarCampos();
                Diagnostico d = AD_ObtenerDatos.ObtenerDiagnostico(iddiag);
                CargarCampos(d);
            }
            else
            {
                
                MessageBox.Show("no se encontro el Diagnostico");
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtIdDiagno.Enabled = true;
            Diagnostico d = ObtenerDatosDiagnostico();
            if (d == null)
            {

            }
            else if (ExisteEnGrillaDiagnostico(d.IdDiagnostico))
            {
                DialogResult resultPregunta = MessageBox.Show("Está por modificar datos ¿Desea actualizar los datos modificados?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                bool resultado;
                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_ActualizarDatos.ActualizarDiagnosticoABD(d);

                    if (resultado)
                    {
                        MessageBox.Show("Diagnostico actualizado con exito");
                        LimpiarCampos();
                        CargarGrilla();


                    }

                    else
                    {
                        MessageBox.Show("NO SE MODIFICO EL DIAGNOSTICO");
                    }

                }
                else
                {
                    MessageBox.Show("Error al actualizar el Diagnostico");
                }
            }
            else
            {
                MessageBox.Show("Diagnostico no encontrado");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdDiagno.Text.Equals("") || !ExisteEnGrillaDiagnostico(int.Parse(txtIdDiagno.Text)))
            {
                MessageBox.Show("NO SE ELIMINO EL DIAGNOSTICO - no encontrado");
            }
            else
            {
                txtIdDiagno.Enabled = true;
                Diagnostico d = ObtenerDatosDiagnostico();
                bool resultado;
                DialogResult resultPregunta = MessageBox.Show("Está por eliminar un diagnostico ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_EliminarDatos.EliminarDiagnosticoBD(d);
                    if (resultado)
                    {
                        MessageBox.Show("Diagnostico eliminado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("NO SE ELIMINO EL DIAGNOSTICO");
                    }
                }
            }
        }

        private void dgrGrillaDiagnostico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDiagno.Enabled = false;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaDiagnostico.Rows[indice];
            int iddiag = int.Parse(filaSeleccionada.Cells["IdDiagno"].Value.ToString());

            Diagnostico d = AD_ObtenerDatos.ObtenerDiagnostico(iddiag);

            LimpiarCampos();
            CargarCampos(d);
        }
    }
}
