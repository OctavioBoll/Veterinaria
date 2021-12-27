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
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }
        private void AgregarProveedor_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla();

        }

        private void LimpiarCampos()
        {
            txtCodigoProveedor.Text = "";
            txtNombre.Text = "";
        }

        private Proveedores ObtenerDatosProveedores()
        {
            Proveedores p = new Proveedores();
            p.NombreProveedor = txtNombre.Text.Trim();
            p.CodigoDelProveedor = int.Parse(txtCodigoProveedor.Text.Trim());
            
            return p;
        }

        private bool ExisteEnGrillaElProveedor(int buscarPorCodProv)
        {
            bool resultado = false;

            for (int i = 0; i < dgrProveedor.Rows.Count; i++)
            {
                if (dgrProveedor.Rows[i].Cells["columnaCodigoProv"].Value.Equals(buscarPorCodProv))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }

        private void AgregarProveedorAGrilla(Proveedores prov)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaCodigoProv = new DataGridViewTextBoxCell();
            celdaCodigoProv.Value = prov.CodigoDelProveedor;
            fila.Cells.Add(celdaCodigoProv);

            DataGridViewTextBoxCell celdaNombreProv = new DataGridViewTextBoxCell();
            celdaNombreProv.Value = prov.NombreProveedor;
            fila.Cells.Add(celdaNombreProv);

            
            
        }
        private void CargarGrilla()
        {
            try
            {
                dgrProveedor.DataSource = AD_CargarGrillas.CargarGrillaProveedores();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el listado de proveedores");
            }

        }

        private void CargarCampos(Proveedores p)
        {
            txtCodigoProveedor.Text = p.CodigoDelProveedor.ToString();
            txtNombre.Text = p.NombreProveedor;
        }

        private void ConsultarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VolverAPantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgrProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifProveedores.Enabled = true;
            btnBajaProveedores.Enabled = true;

            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrProveedor.Rows[indice];
            int codProv = int.Parse(filaSeleccionada.Cells["CodigoProveedor"].Value.ToString());

            Proveedores p = AD_ObtenerDatos.ObtenerProveedorAEliminar(codProv);

            LimpiarCampos();
            CargarCampos(p);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool tieneCodigo = false;
            bool tieneNombre = false;
            bool existeEnGrilla = false;

            if (txtCodigoProveedor.Text.Equals(""))
            {
                MessageBox.Show("Ingrese codigo del proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoProveedor.Focus();
            }
            else
            {
                tieneCodigo = true;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre del proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else
            {
                tieneNombre = true;
            }

            try
            {
                existeEnGrilla = ExisteEnGrillaElProveedor(int.Parse(txtCodigoProveedor.Text));
            }
            catch (Exception)
            {
                txtCodigoProveedor.Focus();
            }

            if (existeEnGrilla == true)
            {
                MessageBox.Show("El proveedor que quiere registrar ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            if (tieneCodigo && tieneNombre && existeEnGrilla == false)
            {
                Proveedores prov = ObtenerDatosProveedores();
                bool resultado = AD_AgregarDatosBD.AgregarProveedorABD(prov);

                if (resultado)
                {
                    MessageBox.Show("Proveedor agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AgregarProveedorAGrilla(prov);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al agregar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifProveedores_Click_1(object sender, EventArgs e)
        {
            if (txtCodigoProveedor.Text.Equals("") && txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Para modificar debe seleccionar un proveedor de la grilla");

            }
            else
            {
                Proveedores p = ObtenerDatosProveedores();
                bool resultado = AD_ActualizarDatos.ActualizarProveedorABD(p);

                if (resultado)
                {
                    DialogResult resultPregunta = MessageBox.Show("Está por modificar datos ¿Desea actualizar los datos modificados?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (resultPregunta == DialogResult.OK)
                    {
                        MessageBox.Show("Proveedor actualizado con exito");
                        LimpiarCampos();
                        CargarGrilla();

                    }
                    else
                    {
                        MessageBox.Show("NO SE MODIFICO A LA PERSONA");
                    }

                }
                else
                {
                    MessageBox.Show("Error al actualizar proveedor");
                }
            }
        }

        private void btnBajaProveedores_Click_1(object sender, EventArgs e)
        {
            Proveedores p = ObtenerDatosProveedores();
            bool resultado = AD_EliminarDatos.EliminarProveedorDeBD(p);

            if (resultado)
            {
                DialogResult resultPregunta = MessageBox.Show("Está por eliminar el proveedor ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultPregunta == DialogResult.OK)
                {
                    MessageBox.Show("Proveedor eliminado con exito");
                    LimpiarCampos();
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("NO SE ELIMINO A LA PERSONA");
                }

            }
            else
            {
                MessageBox.Show("Error al ELIMINAR proveedor");
            }
        }

        private void buscarPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProveedorCodigo ventanabuscador = new BuscarProveedorCodigo();
            ventanabuscador.Show();
        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProvPorNombre ventanabuscadorXnombre = new BuscarProvPorNombre();
            ventanabuscadorXnombre.Show();
        }
    }
}

