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
    public partial class AgregarBarrios : Form
    {
        public AgregarBarrios()
        {
            InitializeComponent();
        }

        private void AgregarBarrios_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }
        private void LimpiarCampos()
        {
            txtCodpostal.Text = "";
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void CargarCampos(Barrio bar)
        {
            txtNombre.Text = bar.NombreBarrio;
            txtCodpostal.Text = Convert.ToString(bar.CodigoPostal);
        }
        private void CargarGrilla()
        {
            try
            {
                dgrGrillaBarrios.DataSource = AD_CargarGrillas.CargarGrillaBarrio();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de Barrios");
            }
            
        }

        private bool ExisteEnGrillaElBarrio(int buscarPorCodpost)
        {
            bool resultado = false;

            for (int i = 0; i < dgrGrillaBarrios.Rows.Count; i++)
            {
                if (dgrGrillaBarrios.Rows[i].Cells["CodPostal"].Value.Equals(buscarPorCodpost))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }


        private void AgregarBarrioAGrilla(Barrio b)//cambiar nombre celdas
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaCodigoBar = new DataGridViewTextBoxCell();
            celdaCodigoBar.Value = b.CodigoPostal;
            fila.Cells.Add(celdaCodigoBar);

            DataGridViewTextBoxCell celdaNombreBar = new DataGridViewTextBoxCell();
            celdaNombreBar.Value = b.NombreBarrio;
            fila.Cells.Add(celdaNombreBar);

        }

        private Barrio ObtenerBarrio()
        {
            if (txtNombre.Text.Equals("") || txtCodpostal.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos correspondientes");
            }
            else
            {
                Barrio barrio = new Barrio();
                barrio.NombreBarrio = txtNombre.Text.Trim();
                barrio.CodigoPostal = int.Parse(txtCodpostal.Text.Trim());
                return barrio;
            }
            return null;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            txtCodpostal.Enabled = true;
            bool tieneCodigo = false;
            bool tieneNombre = false;
            bool existeEnGrilla = false;

            if (txtCodpostal.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Codigo Postal del Barrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCodpostal.Focus();
            }
            else
            {
                tieneCodigo = true;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else
            {
                tieneNombre = true;
            }
            try
            {
                existeEnGrilla = ExisteEnGrillaElBarrio(int.Parse(txtCodpostal.Text));
            }
            catch (Exception)
            {
                txtCodpostal.Focus();
            }

            if (existeEnGrilla == true)
            {
                MessageBox.Show("El Barrio que quiere registrar ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            if (tieneCodigo && tieneNombre && existeEnGrilla == false)
            {
                Barrio b = ObtenerBarrio();
                bool resultado = AD_AgregarDatosBD.AgregarBarrioABD(b);

                if (resultado)
                {
                    MessageBox.Show("Barrio agregado con exito");
                    AgregarBarrioAGrilla(b);
                    LimpiarCampos();
                    CargarGrilla();


                }
                else
                {
                    MessageBox.Show("Error al agregar el Barrio");
                }

            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            txtCodpostal.Enabled = true;
            if (txtCodpostal.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un Codigo Postal para la busqueda");
                txtCodpostal.Focus();
            }
            else
            {
                int codpost = int.Parse(txtCodpostal.Text);
                bool resultado = ExisteEnGrillaElBarrio(codpost);
                if (resultado)
                {
                    dgrGrillaBarrios.DataSource = AD_ObtenerDatos.ObtenerBarrio(codpost);
                    //CargarGrilla();
                    //AgregarBarrioAGrilla(b);
                }
                else
                {
                    CargarGrilla();
                }
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Barrio b = ObtenerBarrio();
            bool resultado;
            if (b == null)
            {
                MessageBox.Show("Rellene los Campos...");
            }
            else if (ExisteEnGrillaElBarrio(b.CodigoPostal))
            {
                DialogResult resultPregunta = MessageBox.Show("Está por modificar datos ¿Desea actualizar los datos modificados?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_ActualizarDatos.ActualizarBarrioABD(b);

                    if (resultado)
                    {
                        MessageBox.Show("Barrio actualizado con exito");
                        LimpiarCampos();
                        CargarGrilla();


                    }
                    else
                    {
                        MessageBox.Show("NO SE MODIFICO EL BARRIO");
                    }

                }
                else
                {
                    MessageBox.Show("Error al actualizar BARRIO");

                }
            }
            else
            {
                MessageBox.Show("Error al Actualizar Barrio");
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodpostal.Text.Equals("") || !ExisteEnGrillaElBarrio(int.Parse(txtCodpostal.Text)))
            {
                MessageBox.Show("NO SE ELIMINO EL BARRIO - Barrio no encontrado");
            }
            else
            {
                txtCodpostal.Enabled = true;
                Barrio b = ObtenerBarrio();
                bool resultado;
                DialogResult resultPregunta = MessageBox.Show("Está por eliminar el Barrio ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_EliminarDatos.EliminarBarrioBD(b);

                    if (resultado)
                    {
                        MessageBox.Show("Barrio eliminado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("NO SE ELIMINO AL BARRIO");
                    }
                }
                else
                {
                    MessageBox.Show("Error al eliminar barrio");
                }
            }
        }

        private void dgrGrillaBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaBarrios.Rows[indice];
            int cod = int.Parse(filaSeleccionada.Cells["CodPostal"].Value.ToString());
            String nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
            Barrio barrio = new Barrio();
            barrio.CodigoPostal = cod;
            barrio.NombreBarrio = nombre;
            LimpiarCampos();
            CargarCampos(barrio);
        }
    }
}
