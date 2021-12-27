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
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            txtFechaFin.Enabled = false;
            txtMotivoFin.Enabled = false;
            txtId.Enabled = false;
            btnAñadir.Enabled = true;
            limpiarCampos();
            cargarComboTipoDocumento();
            cargarComboCargos();
            cargarGrilla();
            cargarGrillaBaja();
        }

        private void cargarGrillaBaja()
        {
            dgrGrillaListaDesempleados.DataSource = AD_CargarGrillas.CargarGrillaDesempleado();
        }

        private void cargarGrilla()
        {
            try
            {
                dgrGrillaListaEmpleados.DataSource = AD_CargarGrillas.CargarGrillaEmpleado();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void cargarComboCargos()
        {
            try
            {
                cmbCargo.DataSource = AD_CargarCombos.CargarComboGenerico("CARGOS");
                cmbCargo.DisplayMember = "nombre";
                cmbCargo.ValueMember = "id_cargo";
                cmbCargo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void cargarComboTipoDocumento()
        {
            try
            {
                cmbTipoDoc.DataSource = AD_CargarCombos.CargarComboGenerico("TIPOS_DOCUMENTOS");
                cmbTipoDoc.DisplayMember = "nombre_tipo_documento";
                cmbTipoDoc.ValueMember = "id_tipo_documento";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtNroCelular.Text = "";
            txtCodigoPostal.Text = "";
            txtFechaIng.Text = "";
            txtNombre.Text = "";
            txtNroCalle.Text = "";
            txtNroDoc.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtValidarContraseña.Text = "";
            cmbTipoDoc.SelectedIndex = -1;
            cmbCargo.SelectedIndex = -1;
            txtFechaFin.Text = "";
            txtMotivoFin.Text = "";
            txtId.Text = "";

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnEliminar.Enabled = false;
            txtFechaFin.Enabled = false;
            txtMotivoFin.Enabled = false;
            btnActualizar.Enabled = false;
            btnAñadir.Enabled = true;

        }


        private Empleados obtenerDatosEmpleado()
        {
            Empleados empleado = new Empleados();
            //MessageBox.Show(cmbCargo.SelectedValue.ToString());

            empleado.Apellido = txtApellido.Text.Trim();
            empleado.Nombre = txtNombre.Text.Trim();
            empleado.NroCalle = txtNroCalle.Text.Trim();
            empleado.Cargo = (int)cmbCargo.SelectedValue;
            empleado.Calle = txtCalle.Text.Trim();
            empleado.Celular = txtNroCelular.Text.Trim();
            empleado.CodPostal = txtCodigoPostal.Text;
            empleado.FechaIngreso = DateTime.Parse(txtFechaIng.Text);
            empleado.NroDocumento = txtNroDoc.Text;
            empleado.TipoDocumento = (int)cmbTipoDoc.SelectedValue;
           
            if (txtId.Text.Equals(""))
            {
                empleado.ID = AD_ObtenerDatos.obtenerIdEmpleado();

            }
            else
            {
                empleado.ID = int.Parse(txtId.Text);
            }
            

            if (txtFechaFin.Enabled)
            {
                empleado.FechaFinLaboral = DateTime.Parse(txtFechaFin.Text);
                empleado.Motivo = txtMotivoFin.Text.Trim();
            }




            return empleado;
        }
        private UsuarioEmpleado obtenerDatosUsuario()
        {
            UsuarioEmpleado usu = new UsuarioEmpleado();
            //MessageBox.Show(cmbCargo.SelectedValue.ToString());
            usu.NombreEmpleado = txtUsuario.Text.Trim();
            usu.PasswordEmpleado = txtContraseña.Text.Trim();
            usu.ID = (int)cmbCargo.SelectedValue;


            return usu;
        }

        private bool validarCampos()
        {
            bool resultado = false;

            if (cmbTipoDoc.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un Tipo de Documento...");
                cmbTipoDoc.Focus();
            }
            else if (txtNroDoc.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nro de Documento...");
                txtNroDoc.Focus();
            }
            else if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nombre...");
                txtNombre.Focus();
            }

            else if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Apellido...");
                txtApellido.Focus();
            }
            else if (txtNroCelular.Text.Equals(""))
            {
                txtNroCelular.Text = "0";
            }
            else if (cmbCargo.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un Cargo...");
                cmbCargo.Focus();
            }
            else if (txtFechaIng.Text == "  /  /")
            {
                MessageBox.Show("Complete el campo Fecha de Ingreso...");
                txtFechaIng.Focus();
            }
            else if (txtCalle.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Calle...");
                txtCalle.Focus();
            }

            else if (txtNroCalle.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nro de Calle...");
                txtNroCalle.Focus();
            }

            else if (txtCodigoPostal.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Codigo Postal...");
                txtCodigoPostal.Focus();
            }
            else if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Complete el Usuario...");
                txtUsuario.Focus();
            }
            else if (txtContraseña.Text.Equals("") || txtValidarContraseña.Text.Equals("") || txtContraseña.Text != txtValidarContraseña.Text)
            {
                MessageBox.Show("Complete bien los campos Contraseña y Validar contraseña...");
                txtContraseña.Focus();
            }

            else
            {
                resultado = true;
            }
            return resultado;
        }


        private void cargarCampos(Empleados empleado)
        {
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtNroCalle.Text = empleado.NroCalle;
            txtNroDoc.Text = empleado.NroDocumento;
            cmbTipoDoc.SelectedValue = empleado.TipoDocumento;
            cmbCargo.SelectedValue = empleado.Cargo;
            txtNroCelular.Text = empleado.Celular;
            txtCodigoPostal.Text = empleado.CodPostal;
            DateTime fecha = empleado.FechaIngreso;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();

            txtFechaIng.Text = dia + mes + año;
            txtCalle.Text = empleado.Calle;
            //txtUsuario.Text = empleado.Usuario;
            //txtContraseña.Text = empleado.Contraseña;
            //txtValidarContraseña.Text = empleado.Contraseña;
            txtId.Text = empleado.ID.ToString();


        }



        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bool validar = validarCampos();
            if (validar)
            {
                try
                {
                    UsuarioEmpleado usu = obtenerDatosUsuario();
                    bool resultadoAgregarUsuario = AD_AgregarDatosBD.AgregarUsuario(usu);
                    
                    
                        Empleados empleado = obtenerDatosEmpleado();
                        // MessageBox.Show(empleado.Cargo.ToString());
                        bool resultado = AD_AgregarDatosBD.AgregarEmpleadoABD(empleado);
                        if (resultado)
                        {
                            MessageBox.Show("Empeado agregado con exito");
                            limpiarCampos();
                            cargarComboCargos();
                            cargarComboTipoDocumento();
                            cmbTipoDoc.Focus();
                            cargarGrilla();

                        }
                        else
                        {
                            MessageBox.Show("Hubo un error...");
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
            bool validar = validarCampos();
            if (validar)
            {
                try
                {
                    Empleados empleado = obtenerDatosEmpleado();
                    bool resultado = AD_ActualizarDatos.ActualizarEmpleadosABD(empleado);
                    if (resultado)
                    {
                        MessageBox.Show("Empleado actualizado con exito");
                        limpiarCampos();
                        cargarComboCargos();
                        cargarComboTipoDocumento();
                        cargarGrilla();
                        cmbTipoDoc.Focus();
                        btnActualizar.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnAñadir.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar empleado...");
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
            txtFechaFin.Enabled = true;
            txtMotivoFin.Enabled = true;
            if (txtFechaFin.Text == "  /  /")
            {
                MessageBox.Show("Complete el campo Fecha de final laboral");
            }
            else
            {
                try
                {
                    Empleados empleado = obtenerDatosEmpleado();
                    bool resultado = AD_ActualizarDatos.ActualizarDarDeBajaEmpleadosABD(empleado);
                    if (resultado)
                    {
                        MessageBox.Show("Empleado dado de baja con exito con exito");
                        limpiarCampos();
                        cargarGrillaBaja();
                        cargarGrilla();


                    }
                    else
                    {
                        MessageBox.Show("Error al dar de baja empleado...");
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + ex.Message);
                }
            }

        }

        private void dgrGrillaListaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnAñadir.Enabled = false;

            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgrGrillaListaEmpleados.Rows[indice];
            string doc = filaSeleccionada.Cells["NroDoc"].Value.ToString();
            int idtipo = int.Parse(filaSeleccionada.Cells["TipoDoc"].Value.ToString());

            try
            {
                Empleados empleado = AD_ObtenerDatos.ObtenerEmpleado(idtipo,doc);
                limpiarCampos();
                cargarCampos(empleado);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }


        }

    }
}

