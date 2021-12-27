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
    public partial class AgregarTipoDocumento : Form
    {
        public AgregarTipoDocumento()
        {
            InitializeComponent();
        }


        private void LimpiarCampos()
        {
            txtIdTipoDoc.Text = "";
            txtNombre.Text = "";
        }

        private void CargarCampos(TipoDocumento t)
        {
            txtIdTipoDoc.Text = t.IdTipoDocumento.ToString();
            txtNombre.Text = t.NombreTipoDoc;
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaTipoDoc.DataSource = AD_CargarGrillas.CargarGrillaTipoDocumento();
            }
            catch (Exception )
            {
                MessageBox.Show("Error al obtener el listado de Tipo De Documento");
            }

        }

        private TipoDocumento ObtenerDatosTipoDoc()
        {
            TipoDocumento t = new TipoDocumento();

            try
            {
                if (txtIdTipoDoc.Text.Equals(""))
                {
                    txtIdTipoDoc.Text = "0";
                }
                t.IdTipoDocumento = int.Parse(txtIdTipoDoc.Text);
                t.NombreTipoDoc = txtNombre.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar tipos de datos correctos");
            }
            return t;
        }

        private void AgregarTipoDocAGrilla(TipoDocumento t)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaIdTipo = new DataGridViewTextBoxCell();
            celdaIdTipo.Value = t.IdTipoDocumento;
            fila.Cells.Add(celdaIdTipo);

            DataGridViewTextBoxCell celdaNombreTipo = new DataGridViewTextBoxCell();
            celdaNombreTipo.Value = t.NombreTipoDoc;
            fila.Cells.Add(celdaNombreTipo);

            
        }

        private bool ExisteEnGrillaTipoDoc(int idtipo)
        {
            bool resultado = false;

            for (int i = 0; i < dgrGrillaTipoDoc.Rows.Count; i++)
            {
                if (dgrGrillaTipoDoc.Rows[i].Cells["IdTipoDoc"].Value.Equals(idtipo))
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
                MessageBox.Show("Ingrese Nombre de Tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();

            }
            else
            {
                tieneNombre = true;
            }

            try
            {
                existeEnGrilla = ExisteEnGrillaTipoDoc(int.Parse(txtIdTipoDoc.Text));
            }
            catch (Exception)
            {
                txtIdTipoDoc.Focus();
            }



            if (existeEnGrilla == true)
            {
                MessageBox.Show("El tipo de documento que quiere registrar ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tieneNombre && existeEnGrilla == false)
            {
                TipoDocumento t = ObtenerDatosTipoDoc();
                bool resultado = AD_AgregarDatosBD.AgregarTipoDocumentoABD(t);

                if (resultado)
                {
                    MessageBox.Show("Tipo de Documento agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AgregarTipoDocAGrilla(t);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdTipoDoc.Enabled = true;
            int idtipo = int.Parse(txtIdTipoDoc.Text);
            bool resultado = ExisteEnGrillaTipoDoc(idtipo);
            if (resultado)
            {
                LimpiarCampos();
                TipoDocumento t = AD_ObtenerDatos.ObtenerTipoDocumento(idtipo);
                CargarCampos(t);
            }
            else
            {

                MessageBox.Show("no se encontro el Tipo de Documento");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtIdTipoDoc.Enabled = true;
            TipoDocumento t = ObtenerDatosTipoDoc();
            if (t == null)
            {
            }
            else if (ExisteEnGrillaTipoDoc(t.IdTipoDocumento))
            {
                bool resultado;
                DialogResult resultPregunta = MessageBox.Show("Está por modificar datos ¿Desea actualizar los datos modificados?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_ActualizarDatos.ActualizarTipoDocumentoABD(t);
                    if (resultado)
                    {
                        MessageBox.Show("Tipo de Documento actualizado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("NO SE MODIFICO EL TIPO DE DOCUMENTO");
                    }

                }
                else
                {
                    MessageBox.Show("Error al actualizar el Tipo de Documento");
                }
            }
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            if (txtIdTipoDoc.Text.Equals("") || !ExisteEnGrillaTipoDoc(int.Parse(txtIdTipoDoc.Text)))
            {
                MessageBox.Show("NO SE ELIMINO EL TIPO DE DOCUMENTO - no encontrado");
            }
            else
            {
                txtIdTipoDoc.Enabled = true;
                TipoDocumento v = ObtenerDatosTipoDoc();
                bool resultado;
                DialogResult resultPregunta = MessageBox.Show("Está por eliminar un Tipo de Documento ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_EliminarDatos.EliminarTipoDocumentoBD(v);
                    if (resultado)
                    {
                        MessageBox.Show("Tipo de Documento eliminado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("NO SE ELIMINO EL TIPO DE DOCUMENTO");
                    }

                }
                else
                {
                    MessageBox.Show("Error al ELIMINAR EL TIPO DE DOCUMENTO");
                }
            }
        }

        private void dgrGrillaTipoDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaTipoDoc.Rows[indice];
            int idtipo = int.Parse(filaSeleccionada.Cells["IdTipoDoc"].Value.ToString()); 

            TipoDocumento t = AD_ObtenerDatos.ObtenerTipoDocumento(idtipo);

            LimpiarCampos();
            CargarCampos(t);
        }

        private void AgregarTipoDocumento_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }
    }
}
