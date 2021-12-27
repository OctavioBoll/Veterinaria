using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPIVeterinaria.Entidades;

namespace TPIVeterinaria.Funcionalidades
{
    public class AD_ActualizarDatos
    {

        public static bool ActualizarCliente(Cliente p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", p.NombreClientes);
                cmd.Parameters.AddWithValue("@apellido", p.ApellidoCliente);
                cmd.Parameters.AddWithValue("@idTipoDoc", p.TipoDocumento);
                cmd.Parameters.AddWithValue("@nroDoc", p.NumeroDocumento);
                cmd.Parameters.AddWithValue("@mail", p.MailCliente);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool ActualizarMascotas(Mascotas p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarMascota";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@hist", p.NroHistoMascota);
                cmd.Parameters.AddWithValue("@nombre", p.NombreMascota);
                cmd.Parameters.AddWithValue("@idraza", p.IdRazaMascota);
                cmd.Parameters.AddWithValue("@idespecie", p.IdEspecieMascota);
                cmd.Parameters.AddWithValue("@fechanac", p.FechaNacMascota);
                cmd.Parameters.AddWithValue("@pesoaprox", p.PesoAproxMascota);
                cmd.Parameters.AddWithValue("@idsexo", p.IdSexoMascota);
                cmd.Parameters.AddWithValue("@fechaingreso", p.FechaIngresoMascota);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool ActualizarProveedorABD(Proveedores prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarProveedor";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProv", prov.CodigoDelProveedor);
                cmd.Parameters.AddWithValue("@nombre", prov.NombreProveedor);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            return resultado;
        }

        public static bool ActualizarVacunasABD(Vacunas prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarVacunas";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codvac", prov.CodigoVacuna);
                cmd.Parameters.AddWithValue("@precio", prov.PrecioVacuna);
                cmd.Parameters.AddWithValue("@nombre", prov.NombreVacuna);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            return resultado;
        }

        public static bool ActualizarMedicamentosABD(Medicamentos m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarMedicamentos";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codmed", m.CodigoMedicamento);
                cmd.Parameters.AddWithValue("@precio", m.PrecioMedicamento);
                cmd.Parameters.AddWithValue("@codprov", m.CodProveedor);
                cmd.Parameters.AddWithValue("@descirp", m.DescripcionMedicamento);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            return resultado;
        }

        public static bool ActualizarBarrioABD(Barrio m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codpos", m.CodigoPostal);
                cmd.Parameters.AddWithValue("@nombre", m.NombreBarrio);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            return resultado;
        }

        public static bool ActualizarCargoABD(Cargo m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarCargo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcargo", m.IdCargo);
                cmd.Parameters.AddWithValue("@nombre", m.NombreCargo);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            return resultado;
        }

        public static bool ActualizarDiagnosticoABD(Diagnostico m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarDiagnostico";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iddiag", m.IdDiagnostico);
                cmd.Parameters.AddWithValue("@nombre", m.Nombrediagnostico);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            return resultado;
        }

        public static bool ActualizarTipoDocumentoABD(TipoDocumento m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarTipoDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtipo", m.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@nombre", m.NombreTipoDoc);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            return resultado;
        }

        public static bool ActualizarEmpleadosABD(Empleados m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarEmpleados";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDocumento", m.TipoDocumento);
                cmd.Parameters.AddWithValue("@NroDocumento", m.NroDocumento);
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", m.Apellido);
                cmd.Parameters.AddWithValue("@Celular", m.Celular);
                cmd.Parameters.AddWithValue("@Id_cargo", m.Cargo);
                cmd.Parameters.AddWithValue("@FechaIngreso", m.FechaIngreso);
                cmd.Parameters.AddWithValue("@Calle", m.Calle);
                cmd.Parameters.AddWithValue("@NroCalle", m.NroCalle);
                cmd.Parameters.AddWithValue("@Cod_postal", m.CodPostal);
                //cmd.Parameters.AddWithValue("@Usuario", m.Usuario);
                //cmd.Parameters.AddWithValue("@Contraseña", m.Contraseña);
                //cmd.Parameters.AddWithValue("@ID", m.ID);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            return resultado;
        }

        public static bool ActualizarDarDeBajaEmpleadosABD(Empleados m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarEmpleados";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDocumento", m.TipoDocumento);
                cmd.Parameters.AddWithValue("@NroDocumento", m.NroDocumento);
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", m.Apellido);
                cmd.Parameters.AddWithValue("@Celular", m.Celular);
                cmd.Parameters.AddWithValue("@Id_cargo", m.Cargo);
                cmd.Parameters.AddWithValue("@FechaIngreso", m.FechaIngreso);
                cmd.Parameters.AddWithValue("@FechaEgreso", m.FechaFinLaboral);
                cmd.Parameters.AddWithValue("@Motivo", m.Motivo);
                cmd.Parameters.AddWithValue("@Calle", m.Calle);
                cmd.Parameters.AddWithValue("@NroCalle", m.NroCalle);
                cmd.Parameters.AddWithValue("@Cod_postal", m.CodPostal);
                //cmd.Parameters.AddWithValue("@Usuario", m.Usuario);
                //cmd.Parameters.AddWithValue("@Contraseña", m.Contraseña);
                //cmd.Parameters.AddWithValue("@ID", m.ID);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            return resultado;
        }

        public static bool ActualizarServicioABD(Servicio m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarServicio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idserv", m.ID);
                cmd.Parameters.AddWithValue("@nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@precio", m.Precio);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            return resultado;
        }
        public static bool ActualizarEspecieABD(Especie m)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarEspecie";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idesp", m.ID);
                cmd.Parameters.AddWithValue("@nombre", m.Nombre);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            return resultado;
        }



        public static bool ActualizarTurno(Turno turno)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "ActualizarTurno";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", turno.FechaTurno);
                cmd.Parameters.AddWithValue("@hora", turno.HoraTurno);
                cmd.Parameters.AddWithValue("@servicio", turno.IdServicioTurno);
                cmd.Parameters.AddWithValue("@nroHist", turno.NroHistorialClinicoTurno);
                cmd.Parameters.AddWithValue("@nro", turno.NroTurno);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                resultado = true;

                return resultado;
            }
            catch (Exception)
            {

                return resultado;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool ActualizarRaza(Raza raza)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "ActualizarRaza";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", raza.NombreRaza);
                cmd.Parameters.AddWithValue("@descripcion", raza.DescripcionRaza);
                cmd.Parameters.AddWithValue("@IdRaza", raza.IdRaza);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                resultado = true;

                return resultado;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool ActualizarMotivo(Motivo motivo)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "ActualizarMotivo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", motivo.NombreMotivo);
                cmd.Parameters.AddWithValue("@desc", motivo.DescripcionMotivo);
                cmd.Parameters.AddWithValue("@id", motivo.IdMotivo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                resultado = true;

                return resultado;
            }
            catch (Exception)
            {

                return resultado;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool ActualizarConsulta(Consulta consSelecc)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "ActualizarConsulta";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroHist", consSelecc.NroHistClinicaConsulta);
                cmd.Parameters.AddWithValue("@tipoDoc", consSelecc.TipoDocEmpleadoConsulta);
                cmd.Parameters.AddWithValue("@nroDoc", consSelecc.NroDocEmpleadoConsulta);
                cmd.Parameters.AddWithValue("@fecha", consSelecc.FechaConsulta);
                cmd.Parameters.AddWithValue("@hora", consSelecc.HoraConsulta);
                cmd.Parameters.AddWithValue("@motivo", consSelecc.IdMotivoConsulta);
                cmd.Parameters.AddWithValue("@nro", consSelecc.NroConsulta);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                resultado = true;

                return resultado;
            }
            catch (Exception)
            {

                return resultado;
            }
            finally
            {
                cn.Close();
            }
        }













    }
}
