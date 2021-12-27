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
    public partial class AgregarServicio : Form
    {
        public AgregarServicio()
        {
            InitializeComponent();
        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {

            cargarGrilla();
            txtId.Enabled = false;

        }

        private void limpiarCampos()
        {
            txtPrecio.Text = "";
            txtNombre.Text = "";
            txtId.Text = "";

        }


        private void cargarGrilla()
        {
            try
            {
                dgrGrillaServicio.DataSource = AD_CargarGrillas.CargarGrillaServicio();
            }
            catch (Exception)
            {

                MessageBox.Show("Error no se pudo Cargar la Lista");
            }


        }

        private void cargarCampos(Servicio ser)
        {
            txtNombre.Text = ser.Nombre;
            txtPrecio.Text = ser.Precio.ToString();
            txtId.Text = ser.ID.ToString();
        }

        private bool validarCampos()
        {
            bool resultado = false;
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nombre");
                txtNombre.Focus();
            }
            else if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Precio");
                txtPrecio.Focus();
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

        private Servicio obtenerDatosServicio()
        {
            Servicio ser = new Servicio();
            if (txtId.Text.Equals(""))
            {
                txtId.Text = "0";
            }

            ser.ID = int.Parse(txtId.Text.Trim());
            ser.Nombre = txtNombre.Text.Trim();
            ser.Precio = float.Parse(txtPrecio.Text.Trim());


            return ser;
        }




        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool validar = validarCampos();
            if (validar)
            {
                try
                {
                    Servicio ser = obtenerDatosServicio();
                    bool resultado = AD_AgregarDatosBD.AgregarServicioABD(ser);

                    if (resultado)
                    {
                        MessageBox.Show("El servicio se agrego exitosamente");
                        cargarGrilla();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar servicio..");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al Agregar");
                }
            }


        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            bool validar = validarCampos();
            if (validar)
            {
                try
                {
                    Servicio ser = obtenerDatosServicio();
                    bool resultado = AD_ActualizarDatos.ActualizarServicioABD(ser);

                    if (resultado)
                    {
                        MessageBox.Show("Servicio actualizado");
                        cargarGrilla();
                        limpiarCampos();

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al Actualizar");
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio ser = obtenerDatosServicio();
                bool resultado = AD_EliminarDatos.EliminarServicioBD(ser);

                if (resultado)
                {
                    MessageBox.Show("Servicio eliminado");
                    cargarGrilla();
                    limpiarCampos();

                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Eliminar");
            }

        }

        private void dgrGrillaServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaServicio.Rows[indice];
            int id = int.Parse(filaSeleccionada.Cells["IdServicio"].Value.ToString());
            try
            {
                Servicio ser = AD_ObtenerDatos.ObtenerServicio(id);

                cargarCampos(ser);

            }
            catch (Exception )
            {

                MessageBox.Show("No se Encontro el cliente");
            }

        }
    }
}
