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
    public partial class AgregarCargo : Form
    {
        public AgregarCargo()
        {
            InitializeComponent();
            txtIdCargo.Enabled = false;
        }


        private void LimpiarCampos()
        {
            txtIdCargo.Text = "";
            txtNombre.Text = "";
        }

        private void CargarCampos(Cargo c)
        {
            txtIdCargo.Text = c.IdCargo.ToString();
            txtNombre.Text = c.NombreCargo;
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaCargo.DataSource = AD_CargarGrillas.CargarGrillaCargo();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de Cargos");
            }

        }

        private Cargo ObtenerDatosCargo()
        {
            Cargo c = new Cargo();

            try
            {
                if (txtIdCargo.Text.Equals(""))
                {
                    txtIdCargo.Text = "0";
                }
                c.IdCargo = int.Parse(txtIdCargo.Text);
                c.NombreCargo = txtNombre.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar tipos de datos correctos");
            }
            return c;
        }

        private void AgregarCargoAGrilla(Cargo c)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaIdCargo = new DataGridViewTextBoxCell();
            celdaIdCargo.Value = c.IdCargo;
            fila.Cells.Add(celdaIdCargo);

            DataGridViewTextBoxCell celdaNombreCargo = new DataGridViewTextBoxCell();
            celdaNombreCargo.Value = c.NombreCargo;
            fila.Cells.Add(celdaNombreCargo);

        }

        private bool ExisteEnGrillaCargo(int idcargo)
        {
            bool resultado = false;

            for (int i = 0; i < dgrGrillaCargo.Rows.Count; i++)
            {
                if (dgrGrillaCargo.Rows[i].Cells["IdCargo"].Value.Equals(idcargo))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }



        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool tieneNombre = false;
            bool existeEnGrilla = false;

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Nombre del Cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();

            }
            else
            {
                tieneNombre = true;
            }

            try
            {
                existeEnGrilla = ExisteEnGrillaCargo(int.Parse(txtIdCargo.Text));
            }
            catch (Exception)
            {
                txtIdCargo.Focus();
            }



            if (existeEnGrilla == true)
            {
                MessageBox.Show("El Cargo que quiere registrar ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (tieneNombre && existeEnGrilla == false)
                {
                    Cargo c = ObtenerDatosCargo();
                    bool resultado = AD_AgregarDatosBD.AgregarCargoABD(c);

                    if (resultado)
                    {
                        MessageBox.Show("Cargo agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        AgregarCargoAGrilla(c);
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el Cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdCargo.Enabled = true;
            int idcar = int.Parse(txtIdCargo.Text);
            bool resultado = ExisteEnGrillaCargo(idcar);
            if (resultado)
            {
                LimpiarCampos();
                Cargo c = AD_ObtenerDatos.ObtenerCargo(idcar);
                CargarCampos(c);
            }
            else
            {

                MessageBox.Show("no se encontro el Cargo");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtIdCargo.Enabled = true;
            Cargo c = ObtenerDatosCargo();
            if (c == null)
            {

            }
            else if (ExisteEnGrillaCargo(c.IdCargo))
            {
                DialogResult resultPregunta = MessageBox.Show("Está por modificar datos ¿Desea actualizar los datos modificados?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                bool resultado;

                if (resultPregunta == DialogResult.OK)
                {

                    resultado = AD_ActualizarDatos.ActualizarCargoABD(c);
                    if (resultado)
                    {

                        MessageBox.Show("Cargo actualizado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                    }

                }
                else
                {
                    MessageBox.Show("NO SE MODIFICO EL CARGO");
                }

            }
            else
            {
                MessageBox.Show("Error al actualizar el Cargo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdCargo.Text.Equals("") || !ExisteEnGrillaCargo(int.Parse(txtIdCargo.Text)))
            {
                MessageBox.Show("NO SE ELIMINO EL CARGO - no encontrado");
            }
            else
            {
                txtIdCargo.Enabled = true;
                Cargo c = ObtenerDatosCargo();
                bool resultado;
                DialogResult resultPregunta = MessageBox.Show("Está por eliminar la cargo ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_EliminarDatos.EliminarCargoBD(c);
                    if (resultado)
                    {
                        MessageBox.Show("Cargo eliminado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al Elminar el Cargo");
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ELIMINO EL CARGO");
                }
            }
        }
    
        private void dgrGrillaCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCargo.Enabled = false;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaCargo.Rows[indice];
            int idcargo = int.Parse(filaSeleccionada.Cells["IdCargo"].Value.ToString());

            Cargo c = AD_ObtenerDatos.ObtenerCargo(idcargo);

            LimpiarCampos();
            CargarCampos(c);
        }

        private void AgregarCargo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }
    }
}
