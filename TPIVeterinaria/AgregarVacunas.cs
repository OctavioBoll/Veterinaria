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
    public partial class AgregarVacunas : Form
    {
        public AgregarVacunas()
        {
            InitializeComponent();
        }

        private void AgregarVacunas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }
        private void LimpiarCampos()
        {
            txtCodvacuna.Text = "";
            txtPrecio.Text = "";
            txtNombre.Text = "";
        }

        private void CargarCampos(Vacunas v)
        {
            txtCodvacuna.Text = v.CodigoVacuna.ToString();
            txtPrecio.Text = v.PrecioVacuna.ToString();
            txtNombre.Text = v.NombreVacuna.ToString();
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaVacunas.DataSource = AD_CargarGrillas.CargarGrillaVacunas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de vacunas");
            }

        }

        private Vacunas ObtenerDatosVacunas()
        {
            Vacunas vac = new Vacunas();

            try
            {
                vac.CodigoVacuna = int.Parse(txtCodvacuna.Text);
                vac.PrecioVacuna = float.Parse(txtPrecio.Text);
                vac.NombreVacuna = txtNombre.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar tipos de datos correctos");
            }
            return vac;
        }

        private void AgregarVacunaAGrilla(Vacunas vac)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaCodigoVac = new DataGridViewTextBoxCell();
            celdaCodigoVac.Value = vac.CodigoVacuna;
            fila.Cells.Add(celdaCodigoVac);

            DataGridViewTextBoxCell celdaPrecioVac = new DataGridViewTextBoxCell();
            celdaPrecioVac.Value = vac.PrecioVacuna;
            fila.Cells.Add(celdaPrecioVac);
           
        }

        private bool ExisteEnGrillaLaVacuna(int buscarPorCodVac)
        {
            bool resultado = false;

            for (int i = 0; i < dgrGrillaVacunas.Rows.Count; i++)
            {
                if (dgrGrillaVacunas.Rows[i].Cells["CodVacuna"].Value.Equals(buscarPorCodVac))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool tieneCodigo = false;
            bool tienePrecio = false;
            bool tieneNombre = false;
            bool existeEnGrilla = false;

            if (txtCodvacuna.Text.Equals(""))
            {
                MessageBox.Show("Ingrese codigo de la vacuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodvacuna.Focus();
            }
            else
            {
                tieneCodigo = true;
            }

            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese precio de la vacuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();

            }
            else
            {
                tienePrecio = true;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese descripcion de la vacuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else
            {
                tieneNombre = true;
            }

            try
            {
                existeEnGrilla = ExisteEnGrillaLaVacuna(int.Parse(txtCodvacuna.Text));
            }
            catch (Exception)
            {
                txtCodvacuna.Focus();
            }



            if (existeEnGrilla == true)
            {
                MessageBox.Show("La vacuna que quiere registrar ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tieneCodigo && tienePrecio && tieneNombre && existeEnGrilla == false)
            {
                Vacunas vac = ObtenerDatosVacunas();
                bool resultado = AD_AgregarDatosBD.AgregarVacunaABD(vac);

                if (resultado)
                {
                    MessageBox.Show("Vacuna agregada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AgregarVacunaAGrilla(vac);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al agregar la vacuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Vacunas v = ObtenerDatosVacunas();
            bool resultado;
            DialogResult resultPregunta = MessageBox.Show("Está por modificar datos ¿Desea actualizar los datos modificados?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultPregunta == DialogResult.OK)
            {
                
                resultado = AD_ActualizarDatos.ActualizarVacunasABD(v);
                if (resultado)
                {
                    MessageBox.Show("Vacuna actualizada con exito");
                    LimpiarCampos();
                    CargarGrilla();



                }
                else
                {
                    MessageBox.Show("Error al actualizar vacuna");
                }

            }
            else
            {
                MessageBox.Show("NO SE MODIFICO LA VACUNA");

            }

        }



        private void btnElminar_Click(object sender, EventArgs e)
        {
            Vacunas v = ObtenerDatosVacunas();
            bool resultado;
            DialogResult resultPregunta = MessageBox.Show("Está por eliminar la vacuna ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultPregunta == DialogResult.OK)
            {
                resultado = AD_EliminarDatos.EliminarVacunasDeBD(v);

                if (resultado)
                {
                    MessageBox.Show("Vacuna eliminada con exito");
                    LimpiarCampos();
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al ELIMINAR VACUNA");
                }

            }
            else
            {
                MessageBox.Show("NO SE ELIMINO A LA VACUNA");

            }
        }
    

        private void dgrGrillaVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaVacunas.Rows[indice];
            int codVac = int.Parse(filaSeleccionada.Cells["CodVacuna"].Value.ToString());

            Vacunas v = AD_ObtenerDatos.ObtenerVacunasxcod(codVac);

            LimpiarCampos();
            CargarCampos(v);
        }

        private void buscarPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarvacunaXcod ventanabusvac = new BuscarvacunaXcod();
            ventanabusvac.Show();
        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarvacXnom ventanabuscarnombre = new BuscarvacXnom();
            ventanabuscarnombre.Show();
        }
    }

}
