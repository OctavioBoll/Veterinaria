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
    public partial class AgregarEspecie : Form
    {
        public AgregarEspecie()
        {
            InitializeComponent();
        }

        private void AgregarEspecie_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            txtIdEspecie.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            limpiarCampos();

        }

        private void limpiarCampos()
        {
            txtIdEspecie.Text = "";
            txtNombre.Text = "";

        }

        private void cargarGrilla()
        {
            try
            {
                dgrGrillaEspecie.DataSource = AD_CargarGrillas.CargarGrillaEspecie();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }

        }

        private bool validarCampos()
        {
            bool resultado = false;
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nombre");
                txtNombre.Focus();
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        private Especie obtenerDatosEspecie()
        {

            Especie especie = new Especie();


            especie.Nombre = txtNombre.Text.Trim();
            if (txtIdEspecie.Text.Equals(""))
            {

            }
            else
            {
                especie.ID = int.Parse((txtIdEspecie.Text));
            }


            return especie;
        }

        private void cargarCamposEspecie(Especie especie)
        {
            txtNombre.Text = especie.Nombre;
            txtIdEspecie.Text = especie.ID.ToString();
        }

        private void dgrGrillaEspecie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaEspecie.Rows[indice];
            int id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
            try
            {
                Especie especie = AD_ObtenerDatos.ObtenerEspecie(id);

                cargarCamposEspecie(especie);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }
        }





        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool resultado = validarCampos();
            if (resultado)
            {
                try
                {
                    Especie especie = obtenerDatosEspecie();
                    bool resultado2 = AD_AgregarDatosBD.AgregarEspecieABD(especie);
                    if (resultado2)
                    {
                        MessageBox.Show("Especie agregada con exito");
                        cargarGrilla();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar especie...");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + ex.Message);
                }

            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool validados = validarCampos();
            if (validados)
            {
                try
                {
                    Especie especie = obtenerDatosEspecie();
                    bool resultado = AD_ActualizarDatos.ActualizarEspecieABD(especie);

                    if (resultado)
                    {
                        MessageBox.Show("Especie actualizada");
                        cargarGrilla();
                        limpiarCampos();
                        btnActualizar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + ex.Message);
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Especie especie = obtenerDatosEspecie();
                bool resultado = AD_EliminarDatos.EliminarEspecieBD(especie);

                if (resultado)
                {
                    MessageBox.Show("Especie eliminada");
                    cargarGrilla();
                    limpiarCampos();
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }

        }


    }
}