using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPIVeterinaria.Entidades;
using TPIVeterinaria.Funcionalidades;

namespace TPIVeterinaria
{
    public partial class AgregarClientes : Form
    {
        public AgregarClientes()
        {
            InitializeComponent();
            this.tpMensaje.SetToolTip(btnAñadirCliente,"Añadir Un Nuevo Cliente");
            this.tpMensaje.SetToolTip(btnActualizarCliente, "Guardar cambios de un Cliente");
            this.tpMensaje.SetToolTip(btnBuscarCliente, "Buscar Un Cliente por Tipo y Numero Documento");
            this.tpMensaje.SetToolTip(btnEliminarCliente, "Eliminar un Cliente Seleccionado");
            this.tpMensaje.SetToolTip(btnAñadirMascota, "Añadir Una Nueva Mascota al Cliente");
            this.tpMensaje.SetToolTip(btnActualizarMascota, "Guardar cambios de una Mascota");
            this.tpMensaje.SetToolTip(btnBuscarMascota, "Buscar Una Mascota");
            this.tpMensaje.SetToolTip(btnEliminarMascota, "Eliminar Una Mascota Seleccionada");
        }

        private void AgregarClientes_Load(object sender, EventArgs e)//Pantalla Principal Agregar 
        {
            LimpiarCampos();
            CargarGrillaCliente();
            CargarCombosTipoDocumentos();
            gbDatosMascotas.Enabled = false;
            CargarCombosRaza();
            CargarCombosEspecies();
            CargarCombosSexo();
        }

        //Limpiar Campos
        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtNroDocumento.Text = "";
            txtMail.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }
        private void LimpiarCamposMascotas()
        {
            txtNombreMascota.Text = "";
            cmbRaza.SelectedIndex = -1;
            cmbEspecie.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            nupPeso.Value = 0;
            txtFechaNac.Text = "";
            txtFechaIngreso.Text = "";
        }

        //Cargar Combos
            //Clientes
        private void CargarCombosTipoDocumentos()
        {
                cmbTipoDocumento.DataSource = AD_CargarCombos.CargarComboGenerico("TIPOS_DOCUMENTOS");
                cmbTipoDocumento.DisplayMember = "nombre_tipo_documento";
                cmbTipoDocumento.ValueMember = "id_tipo_documento";
                cmbTipoDocumento.SelectedIndex = -1;
        }
            //Mascotas
        private void CargarCombosRaza()
        {
                cmbRaza.DataSource = AD_CargarCombos.CargarComboGenerico("RAZAS");
                cmbRaza.DisplayMember = "nombre";
                cmbRaza.ValueMember = "id_raza";
                cmbRaza.SelectedIndex = -1;
        }
        private void CargarCombosEspecies()
        {
                cmbEspecie.DataSource = AD_CargarCombos.CargarComboGenerico("ESPECIES");
                cmbEspecie.DisplayMember = "nombre";
                cmbEspecie.ValueMember = "id_especie";
                cmbEspecie.SelectedIndex = -1;
        }
        private void CargarCombosSexo()
        {
                cmbSexo.DataSource = AD_CargarCombos.CargarComboGenerico("SEXO");
                cmbSexo.DisplayMember = "nombre_tipo_sexo";
                cmbSexo.ValueMember = "id_tipo_sexo";
                cmbSexo.SelectedIndex = -1;
        }

        //Cargar Grillas y Cajas de texto
            //Clientes
        private void CargarGrillaCliente()//Cargar la Grilla de todos los Usuarios
        {
                grGrillaCliente.DataSource = AD_CargarGrillas.CargarGrillaCliente(); 
        }
        private void CargarGrillaBuscar(string doc)//Cargar la grilla con los datos de un usuario
        {
            try
            {
                grGrillaCliente.DataSource = AD_CargarGrillas.CargarGrillaBuscar(doc);
            }
            catch (Exception)
            {
                grGrillaCliente.DataSource = AD_CargarGrillas.CargarGrillaCliente();
                throw;
            }
               
        }

        

        private bool ExisteEnGrilla(string criterioABuscar)//devuelve true si esta en la grilla
        {
            bool resultado = false;
            for (int i = 0; i < grGrillaCliente.Rows.Count; i++)
            {
                if (criterioABuscar == "")
                {
                    resultado = false;
                    break;
                }
                else
                {
                    try
                    {
                        if (grGrillaCliente.Rows[i].Cells["NumeroDoc"].Value.Equals(criterioABuscar))
                        {
                            resultado = true;
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        resultado = false;
                    }
                }
            }

            return resultado;
        }
        private void CargarCampos(Cliente p)//Cargar clientes buscados seleccionado en las cajas texto
        {
            txtNombreCliente.Text = p.NombreClientes;
            txtApellidoCliente.Text = p.ApellidoCliente;
            txtNroDocumento.Text = p.NumeroDocumento;
            cmbTipoDocumento.SelectedValue = p.TipoDocumento;
            txtMail.Text = p.MailCliente;
        }
        //Mascotas
        
        //private void CargarGrillaMascotas()//Cargar la Grilla de todos las mascotas
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {
        //        bool resultado = false;

        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT nombre,id_raza,id_especie,fecha_nacimiento,peso_aprox_ingreso,id_sexo,fecha_ingreso_vet FROM MASCOTAS";

        //        cmd.Parameters.Clear();

        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;

        //        DataTable tabla = new DataTable();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);

        //        grGrillaCliente.DataSource = tabla;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}
        private void CargarCamposMascota(Mascotas p)//Cargar mascotas buscados seleccionado en las cajas texto
        {
            txtNroHisto.Text = p.NroHistoMascota.ToString();
            txtNombreMascota.Text = p.NombreMascota.ToString();
            cmbRaza.SelectedValue = p.IdRazaMascota.ToString();
            cmbEspecie.SelectedValue = p.IdEspecieMascota.ToString();
            cmbSexo.SelectedValue = p.IdSexoMascota.ToString();
            nupPeso.Value = int.Parse(p.PesoAproxMascota.ToString());
            DateTime fecha = DateTime.Parse(p.FechaNacMascota.ToString());
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
            txtFechaNac.Text = dia + mes + año;
            DateTime fecha2 = DateTime.Parse(p.FechaIngresoMascota.ToString());
            string dia2 = "";
            string mes2 = "";
            string año2 = "";
            dia2 = fecha2.Date.Day.ToString();
            if (dia2.Length == 1)
            {
                dia2 = "0" + dia2;
            }
            mes2 = fecha2.Date.Month.ToString();
            if (mes2.Length == 1)
            {
                mes2 = "0" + mes2;
            }
            año2 = fecha2.Date.Year.ToString();
            txtFechaIngreso.Text = dia2 + mes2 + año2;
        }
        private void CargarGrillaBuscarMascota(string doc, int tipodoc)//Cargar la grilla con los datos de un usuario
        {
            grMascotas.DataSource = AD_CargarGrillas.CargarGrillaBuscarMascota(doc,tipodoc);
        }
        private bool ExisteEnGrillaMascotas(int criterioABuscar)//devuelve true si esta en la grilla
        {
            bool resultado = false;
            for (int i = 0; i < grMascotas.Rows.Count; i++)
            {
                if (criterioABuscar == 0)
                {
                    resultado = false;
                    break;
                }
                else
                {
                    try
                    {
                        if (grMascotas.Rows[i].Cells["NroHistorial"].Value.Equals(criterioABuscar))
                        {
                            resultado = true;
                            break;
                        }
                        else 
                        {
                            resultado = false;
                        }
                    }
                    catch (Exception)
                    {
                        resultado = false;
                    }
                }
            }

            return resultado;
        }

        //Obtener Datos de la pantalla
            //Cliente
        private Cliente ObtenerDatosCliente()
        {
            Cliente p = new Cliente();
            p.NombreClientes = txtNombreCliente.Text.Trim();
            p.ApellidoCliente = txtApellidoCliente.Text.Trim();
            p.TipoDocumento = (int)cmbTipoDocumento.SelectedValue;
            p.NumeroDocumento = txtNroDocumento.Text.Trim();
            p.MailCliente = txtMail.Text.Trim();
            return p;

        }

            //Mascotas
        private Mascotas ObtenerDatosMascotas()
        {
            validarCamposMascotas();
            Mascotas p = new Mascotas();
            p.NroHistoMascota = int.Parse(txtNroHisto.Text.Trim());
            p.NombreMascota = txtNombreMascota.Text.Trim();
            p.IdRazaMascota = (int)cmbRaza.SelectedValue;
            p.IdEspecieMascota = (int)cmbEspecie.SelectedValue;
            p.FechaNacMascota = DateTime.Parse(txtFechaNac.Text.Trim());
            p.PesoAproxMascota = (int)nupPeso.Value;
            p.IdSexoMascota = (int)cmbSexo.SelectedValue;
            p.TipoDocMascota = (int)cmbTipoDocumento.SelectedValue;
            p.NroDocMascota = txtNroDocumento.Text.Trim();
            p.FechaIngresoMascota = DateTime.Parse(txtFechaIngreso.Text.Trim());
            return p;
        }


        //Validar Datos Rellenados
        private bool validarCamposCliente()
        {
            bool resultado = false;

            if ((cmbTipoDocumento.SelectedValue == null))
            {
                MessageBox.Show("Seleccione un Tipo de Documento...");
                cmbTipoDocumento.Focus();
            }
            else if ((int)cmbTipoDocumento.SelectedValue == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Documento...");
                cmbTipoDocumento.Focus();
            }
            else if (txtNroDocumento.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nro de Documento...");
                txtNroDocumento.Focus();
            }
            else if (txtNombreCliente.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nombre...");
                txtNombreCliente.Focus();
            }

            else if (txtApellidoCliente.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Apellido...");
                txtApellidoCliente.Focus();
            }
            else if (txtMail.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Mail...");
                txtMail.Focus();
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        private bool validarCamposMascotas()
        {
            bool resultado = false;
            if (txtNombreMascota.Text.Equals(""))
            {
                MessageBox.Show("Complete el campo Nombre de la Mascota...");
                txtNombreMascota.Focus();
            }
            else if ((int)cmbRaza.SelectedValue == -1)
            {
                MessageBox.Show("Complete el campo Raza...");
                cmbRaza.Focus();
            }
            else if ((int)cmbEspecie.SelectedValue == -1)
            {
                MessageBox.Show("Complete el campo Especie...");
                cmbEspecie.Focus();
            }
            else if (nupPeso.Value == 0)
            {
                MessageBox.Show("Ingrese peso aprox de la Mascota...");
            }
            else if ((int)cmbSexo.SelectedValue == -1)
            {
                MessageBox.Show("Ingrese el campo Sexo...");
            }
            else if (txtFechaIngreso.Text == "  /  /")
            {
                MessageBox.Show("Ingrese Fecha de Ingreso...");
            }
            else if (txtFechaNac.Text == "  /  /")
            {
                MessageBox.Show("Ingrese Fecha de Nacimiento...");
            }
            else if (int.Parse(txtNroHisto.Text) == 0) 
            {
                MessageBox.Show("No hay numero de historial");
            }
            else if(txtNroHisto.Text == null)
            {
                MessageBox.Show("Historia clinica no es valido");
            }

            else
            {
                resultado = true;
            }
            return resultado;

        }

        //Agregar a las columnas
        //Cliente
        private void AgregarCliente(Cliente p) //Agregar lo que esta en la BD a la tabla Grilla
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = p.NombreClientes;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = p.ApellidoCliente;
            fila.Cells.Add(celdaApellido);

            DataGridViewTextBoxCell celdaNumeroDoc = new DataGridViewTextBoxCell();
            celdaNumeroDoc.Value = p.NumeroDocumento;
            fila.Cells.Add(celdaNumeroDoc);

            DataGridViewTextBoxCell celdaTipoDocumento = new DataGridViewTextBoxCell();
            celdaTipoDocumento.Value = p.TipoDocumento;
            fila.Cells.Add(celdaTipoDocumento);

            DataGridViewTextBoxCell celdaMail = new DataGridViewTextBoxCell();
            celdaMail.Value = p.MailCliente;
            fila.Cells.Add(celdaMail);
        }

            //Mascota
        private void AgregarMascota(Mascotas p) //Agregar lo que esta en la BD a la tabla Grilla
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaNroHisto = new DataGridViewTextBoxCell();
            celdaNroHisto.Value = p.NroHistoMascota;
            fila.Cells.Add(celdaNroHisto);


            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = p.NombreMascota;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaRaza = new DataGridViewTextBoxCell();
            celdaRaza.Value = p.IdRazaMascota;
            fila.Cells.Add(celdaRaza);

            DataGridViewTextBoxCell celdaEspecie = new DataGridViewTextBoxCell();
            celdaEspecie.Value = p.IdEspecieMascota;
            fila.Cells.Add(celdaEspecie);

            DataGridViewTextBoxCell celdaPesoAprox = new DataGridViewTextBoxCell();
            celdaPesoAprox.Value = p.PesoAproxMascota;
            fila.Cells.Add(celdaPesoAprox);

            DataGridViewTextBoxCell celdaFechaNac = new DataGridViewTextBoxCell();
            celdaFechaNac.Value = p.FechaNacMascota;
            fila.Cells.Add(celdaFechaNac);

            DataGridViewTextBoxCell celdaSexo = new DataGridViewTextBoxCell();
            celdaSexo.Value = p.IdSexoMascota;
            fila.Cells.Add(celdaSexo);

            DataGridViewTextBoxCell celdaFechaIngreso = new DataGridViewTextBoxCell();
            celdaFechaIngreso.Value = p.FechaIngresoMascota;
            fila.Cells.Add(celdaFechaIngreso);
        }

        //Botones 
            //Clientes
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtNroDocumento.Text.Equals("") || cmbTipoDocumento.SelectedValue == null)
            {
                MessageBox.Show("Ingrese Tipo y Numero de Documento...");
            }
            else
            {
                string buscarDoc = txtNroDocumento.Text;
                int tipodoc = (int)cmbTipoDocumento.SelectedValue;

                bool resultado = ExisteEnGrilla(buscarDoc);
                if (resultado)
                {

                    LimpiarCamposMascotas();
                    Cliente p = AD_ObtenerDatos.ObtenerCliente(buscarDoc, tipodoc);
                    AgregarCliente(p);
                    CargarCampos(p);

                    CargarGrillaCliente();
                    //CargarGrillaBuscar(buscarDoc);
                    gbDatosMascotas.Enabled = true;
                    txtNroDocumento.Enabled = true;
                    cmbTipoDocumento.Enabled = true;

                    //CargarGrillaBuscarMascota(buscarDoc,tipodoc);
                    Mascotas m = AD_ObtenerDatos.ObtenerMascotas(buscarDoc, tipodoc);
                    int nrohistorial = m.NroHistoMascota;

                    if (nrohistorial != 0)
                    {
                        CargarGrillaBuscarMascota(buscarDoc, tipodoc);
                        CargarCamposMascota(m);
                    }
                    else
                    {
                        LimpiarCamposMascotas();
                        MessageBox.Show("no tene mascotas Guardadas");
                        CargarGrillaBuscarMascota(buscarDoc, tipodoc);
                    }
                }
                else
                {
                    MessageBox.Show("No Se Encontro El Cliente revise los datos");
                    CargarGrillaCliente();
                }
                    //CargarCamposMascota(m);
                
            }
           
        }
        private void btnAñadirCliente_Click(object sender, EventArgs e)
        {
            bool validar = false;
            validar = validarCamposCliente();
            if (validar)
            {
                Cliente P = ObtenerDatosCliente();
                bool resultado = AD_AgregarDatosBD.AgregarClienteABD(P);
                if (resultado)
                {
                    MessageBox.Show("Persona agregada con exito");
                    LimpiarCampos();
                    CargarGrillaCliente();
                    CargarCombosTipoDocumentos();
                    txtNombreCliente.Focus();
                }
                else
                {
                    MessageBox.Show("error al cargar el Cliente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese los Datos Solicitados...");
            }



            

            
        }
        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            
            Cliente p = ObtenerDatosCliente();
            bool resultado = AD_ActualizarDatos.ActualizarCliente(p);
            if (resultado)
            {
                MessageBox.Show("persona actualizada con exito");
                LimpiarCampos();
                CargarGrillaCliente();
                CargarCombosTipoDocumentos();
            }
            else
            {
                MessageBox.Show("Error al actualizar los campos");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (txtNroDocumento.Text.Equals("") || cmbTipoDocumento.SelectedValue == null)
            {
                MessageBox.Show("Ingrese Tipo y Numero de Documento...");
            }
            else
            {
                txtNroDocumento.Enabled = true;
                Cliente c = ObtenerDatosCliente();
                bool resultado;
                DialogResult resultPregunta = MessageBox.Show("Está por eliminar Un Cliente ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_EliminarDatos.EliminarClienteBD(c);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente eliminado con exito");
                        LimpiarCampos();
                        CargarGrillaCliente();
                    }
                    else
                    {
                        MessageBox.Show("NO SE ELIMINO AL CLIENTE");
                    }
                }
                else
                {
                    MessageBox.Show("Error al eliminar el CLiente");
                }
            }
        }

        private void grGrillaCliente_CellClick(object sender, DataGridViewCellEventArgs e)//Para poder hacer click en la grilla
        {
            int indice = e.RowIndex;
            btnBuscarCliente.Enabled = true;
            DataGridViewRow filaSeleccionada = grGrillaCliente.Rows[indice];
            string documento = filaSeleccionada.Cells["NumeroDoc"].Value.ToString();
            int tipodoc = int.Parse(filaSeleccionada.Cells["TipoDocumento"].Value.ToString());
            Cliente p = AD_ObtenerDatos.ObtenerCliente(documento, tipodoc);
            LimpiarCampos();
            CargarCampos(p);
        }

        //Mascotas
        private void btnAñadirMascota_Click(object sender, EventArgs e)
        {
            Mascotas P = ObtenerDatosMascotas();
            bool resultado = AD_AgregarDatosBD.AgregarMascotaABD(P);
            if (resultado)
            {
                string doc = P.NroDocMascota;
                int tipodoc = P.TipoDocMascota;
                MessageBox.Show("Mascota agregada con exito");
                LimpiarCamposMascotas();
                CargarGrillaBuscarMascota(doc,tipodoc);
                CargarCombosRaza();
                CargarCombosEspecies();
                CargarCombosSexo();
                CargarCombosTipoDocumentos();
                txtNombreMascota.Focus();
            }
            else
            {
                MessageBox.Show("error al cargar la Mascota");
            }
        }
        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            string buscarDoc = txtNroDocumento.Text;
            int tipodoc = (int)cmbTipoDocumento.SelectedValue;
            bool resultado = ExisteEnGrilla(buscarDoc);
            if (resultado)
            {
                LimpiarCamposMascotas();
                CargarGrillaBuscarMascota(buscarDoc, tipodoc);
                Mascotas m = AD_ObtenerDatos.ObtenerMascotas(buscarDoc, tipodoc);
                CargarCamposMascota(m);
            }
            else
            {
                grMascotas.Refresh();
                MessageBox.Show("no se encontro el cliente");
                CargarGrillaBuscarMascota(buscarDoc, tipodoc);
            }
        }
        private void grMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grMascotas.Rows[indice];
            string nrodoc = txtNroDocumento.Text;
            int tipodoc = (int)cmbTipoDocumento.SelectedValue;
            int nrohisto = int.Parse(filaSeleccionada.Cells["NroHistorial"].Value.ToString());
            Mascotas p = AD_ObtenerDatos.ObtenerMascotasPorNombre(nrodoc,tipodoc,nrohisto);
            AgregarMascota(p);
            CargarCamposMascota(p);
        }
        private void btnActualizarMascota_Click(object sender, EventArgs e)
        {
            Mascotas p = ObtenerDatosMascotas();
            string doc = p.NroDocMascota;
            int tipodoc = p.TipoDocMascota;
            bool resultado = AD_ActualizarDatos.ActualizarMascotas(p);
            if (resultado)
            {
                MessageBox.Show("mascota actualizada con exito");
                LimpiarCamposMascotas();
                CargarGrillaBuscarMascota(doc,tipodoc);
                
            }
            else
            {
                MessageBox.Show("Error al actualizar los campos");
            }
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            if (txtNroDocumento.Text.Equals("") || cmbTipoDocumento.SelectedValue == null)
            {
                MessageBox.Show("Ingrese Tipo y Numero de Documento...");
            }
            else
            {
                txtNroDocumento.Enabled = true;
                Mascotas m = ObtenerDatosMascotas();
                bool resultado;
                DialogResult resultPregunta = MessageBox.Show("Está por eliminar Una Mascota ¿Desea continuar?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultPregunta == DialogResult.OK)
                {
                    resultado = AD_EliminarDatos.EliminarMascotaBD(m);

                    if (resultado)
                    {
                        MessageBox.Show("Mascota eliminada con exito");
                        LimpiarCampos();
                        CargarGrillaCliente();
                        CargarGrillaBuscarMascota(m.NroDocMascota,m.TipoDocMascota);
                    }
                    else
                    {
                        MessageBox.Show("NO SE ELIMINO LA MASCOTA");
                    }
                }
                else
                {
                    MessageBox.Show("Error al eliminar la Mascota");
                }
            }
        }
    }
}
