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
    public partial class AgregarMedicamentos : Form
    {
        public AgregarMedicamentos()
        {
            InitializeComponent();
        }

        private void AgregarMedicamentos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();
        }

        
        private void LimpiarCampos()
        {
            txtCodMed.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            txtCodProv.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                dgrGrillaMedicamento.DataSource = AD_CargarGrillas.CargarGrillaMedicamentos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de Medicamentos");
            }

        }

        private void CargarCampos(Medicamentos m)
        {
            txtCodMed.Text = m.CodigoMedicamento.ToString();
            txtPrecio.Text = m.PrecioMedicamento.ToString();
            txtDescripcion.Text = m.DescripcionMedicamento;
            txtCodProv.Text = m.CodProveedor.ToString();
        }

       
        private Medicamentos ObtenerDatosMedicamentos()
        {
            Medicamentos med = new Medicamentos();

            try
            {
                med.CodigoMedicamento = int.Parse(txtCodMed.Text);
                med.PrecioMedicamento = float.Parse(txtPrecio.Text);
                med.DescripcionMedicamento = txtDescripcion.Text.Trim();
                med.CodProveedor = int.Parse(txtCodProv.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar tipos de datos correctos");
            }
            return med;
        }



        private bool ExisteEnGrillaElMedicamento(int buscarPorCodMed)
        {
            bool resultado = false;

            for (int i = 0; i < dgrGrillaMedicamento.Rows.Count; i++)
            {
                if (dgrGrillaMedicamento.Rows[i].Cells["CodMed"].Value.Equals(buscarPorCodMed))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        private void AgregarMedicamentoAGrilla(Medicamentos med)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaCodigoMed = new DataGridViewTextBoxCell();
            celdaCodigoMed.Value = med.CodigoMedicamento;
            fila.Cells.Add(celdaCodigoMed);

            DataGridViewTextBoxCell celdaPrecioMed = new DataGridViewTextBoxCell();
            celdaPrecioMed.Value = med.PrecioMedicamento;
            fila.Cells.Add(celdaPrecioMed);

            DataGridViewTextBoxCell celdaDescripMed = new DataGridViewTextBoxCell();
            celdaDescripMed.Value = med.DescripcionMedicamento;
            fila.Cells.Add(celdaDescripMed);

            DataGridViewTextBoxCell celdaCodProvMed = new DataGridViewTextBoxCell();
            celdaCodProvMed.Value = med.CodProveedor;
            fila.Cells.Add(celdaCodProvMed);

            //grillaMedicamentos.Rows.Add(fila);
            //MessageBox.Show("Medicamento agregado con exito");
        }

        private void dgrGrillaMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaMedicamento.Rows[indice];
            int codMed = int.Parse(filaSeleccionada.Cells["CodMed"].Value.ToString()); // ver aca 

            Medicamentos m = AD_ObtenerDatos.ObtenerMedicamento(codMed);

            LimpiarCampos();
            CargarCampos(m);
            btnEliminar.Enabled = true;
            btnAñadir.Enabled = false;
            btnActualizar.Enabled = true;

        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Medicamentos m = ObtenerDatosMedicamentos();
            bool resultado;
            DialogResult resultPregunta = MessageBox.Show("Está por modificar datos ¿Desea actualizar los datos modificados?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            

            if (resultPregunta == DialogResult.OK)
            {
                resultado = AD_ActualizarDatos.ActualizarMedicamentosABD(m);

                if (resultado)
                {
                    MessageBox.Show("Medicamento actualizado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    btnAñadir.Enabled = true;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("NO SE MODIFICO EL MEDICAMENTO");
                }

            }
            else
            {
                MessageBox.Show("Error al actualizar medicamento");
                LimpiarCampos();
                btnAñadir.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Medicamentos m = ObtenerDatosMedicamentos();
            bool resultado;
            DialogResult resultPregunta = MessageBox.Show("Está por eliminar el medicamento ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultPregunta == DialogResult.OK)
            {
                resultado = AD_EliminarDatos.EliminarMedicamentoDeBD(m);
                if (resultado)
                {
                    MessageBox.Show("Medicamento eliminado con exito");
                    LimpiarCampos();
                    CargarGrilla();
    

                }
                else
                {
                    MessageBox.Show("Error al eliminar medicamento");

                }

            }
            else
            {
                MessageBox.Show("NO SE ELIMINO AL MEDICAMENTO");
                
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool tieneCodigo = false;
            bool tienePrecio = false;
            bool tieneCodProv = false;
            bool tieneDescripcion = false;
            bool existeEnGrilla = false;

            if (txtCodMed.Text.Equals(""))
            {
                MessageBox.Show("Ingrese codigo del medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                txtCodMed.Focus();
            }
            else
            {
                tieneCodigo = true;
            }

            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese precio del medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
            }
            else
            {
                tienePrecio = true;
            }

            if (txtCodProv.Text.Equals(""))
            {
                MessageBox.Show("Ingrese codigo del proveedor del medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProv.Focus();
            }
            else
            {
                tieneCodProv = true;
            }

            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese descripcion del medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
            }
            else
            {
                tieneDescripcion = true;
            }


            try
            {
                existeEnGrilla = ExisteEnGrillaElMedicamento(int.Parse(txtCodMed.Text));
            }
            catch (Exception)
            {
                txtCodMed.Focus();
            }

            if (existeEnGrilla == true)
            {
                MessageBox.Show("El medicamento que quiere registrar ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            if (tieneCodigo && tienePrecio && tieneCodProv && tieneDescripcion && existeEnGrilla == false)
            {
                Medicamentos med = ObtenerDatosMedicamentos();
                bool resultado = AD_AgregarDatosBD.AgregarMedicamentosABD(med);

                if (resultado)
                {
                    MessageBox.Show("Medicamento agregado con exito");
                    AgregarMedicamentoAGrilla(med);
                    LimpiarCampos();
                    CargarGrilla();
                    btnAñadir.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error al agregar el medicamento");
                }

            }
        }

        private void buscarPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMedCodigo ventanabuscar = new BuscarMedCodigo();
            ventanabuscar.Show();
        }

        private void buscarPorDescripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMedPorDescripcion ventanabusdes = new BuscarMedPorDescripcion();
            ventanabusdes.Show();
        }
    }
}


