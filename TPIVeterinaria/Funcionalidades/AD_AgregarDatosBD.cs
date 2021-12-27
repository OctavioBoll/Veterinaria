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
    public class AD_AgregarDatosBD
    {
        public static bool AgregarClienteABD(Cliente P) //Agrega el cliente a la BD y devuelve true si lo logra
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipodoc", P.TipoDocumento);
                cmd.Parameters.AddWithValue("@nrodoc", P.NumeroDocumento);
                cmd.Parameters.AddWithValue("@nombre", P.NombreClientes);
                cmd.Parameters.AddWithValue("@apellido", P.ApellidoCliente);
                cmd.Parameters.AddWithValue("@mail", P.MailCliente);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                return resultado;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AgregarMascotaABD(Mascotas P) //Agrega el cliente a la BD y devuelve true si lo logra
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertMascota";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", P.NombreMascota);
                cmd.Parameters.AddWithValue("@idraza", P.IdRazaMascota);
                cmd.Parameters.AddWithValue("@idespecie", P.IdEspecieMascota);
                cmd.Parameters.AddWithValue("@fechanac", P.FechaNacMascota);
                cmd.Parameters.AddWithValue("@pesoaprox", P.PesoAproxMascota);
                cmd.Parameters.AddWithValue("@idsexo", P.IdSexoMascota);
                cmd.Parameters.AddWithValue("@tipodoc", P.TipoDocMascota);
                cmd.Parameters.AddWithValue("@nrodoc", P.NroDocMascota);
                cmd.Parameters.AddWithValue("@fechaingreso", P.FechaIngresoMascota);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                return resultado;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool AgregarUsuario(UsuarioEmpleado usu) 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", usu.NombreEmpleado);
                cmd.Parameters.AddWithValue("@Password", usu.PasswordEmpleado);
                cmd.Parameters.AddWithValue("@idCargo", usu.ID);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                return resultado;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AgregarProveedorABD(Proveedores prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "Insert_Proveedores";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProveedor", prov.CodigoDelProveedor);
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
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AgregarVacunaABD(Vacunas vac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertVacunas";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codvac", vac.CodigoVacuna);
                cmd.Parameters.AddWithValue("@precio", vac.PrecioVacuna);
                cmd.Parameters.AddWithValue("@desc", vac.NombreVacuna);

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
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AgregarMedicamentosABD(Medicamentos med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertMedicamento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codmed", med.CodigoMedicamento);
                cmd.Parameters.AddWithValue("@precio", med.PrecioMedicamento);
                cmd.Parameters.AddWithValue("@desc", med.DescripcionMedicamento);
                cmd.Parameters.AddWithValue("@codprov", med.CodProveedor);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error No Existe un Proveedor con ese Codigo");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AgregarBarrioABD(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codpos", b.CodigoPostal);
                cmd.Parameters.AddWithValue("@nombre", b.NombreBarrio);
                

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool AgregarCargoABD(Cargo b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertCargo";

                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@nom", b.NombreCargo);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool AgregarDiagnosticoABD(Diagnostico b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertDiagnostico";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iddiag", b.IdDiagnostico);
                cmd.Parameters.AddWithValue("@nombre", b.Nombrediagnostico);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool AgregarTipoDocumentoABD(TipoDocumento b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertTipoDoc";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", b.NombreTipoDoc);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool AgregarEmpleadoABD(Empleados b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertEmpleado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoDocumento", b.TipoDocumento);
                cmd.Parameters.AddWithValue("@NroDocumento", b.NroDocumento);
                cmd.Parameters.AddWithValue("@Nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", b.Apellido);
                cmd.Parameters.AddWithValue("@Celular",int.Parse( b.Celular));
                cmd.Parameters.AddWithValue("@Id_cargo", b.Cargo);
                cmd.Parameters.AddWithValue("@FechaIngreso", b.FechaIngreso);
                cmd.Parameters.AddWithValue("@Calle", b.Calle);
                cmd.Parameters.AddWithValue("@NroCalle", b.NroCalle);
                cmd.Parameters.AddWithValue("@Cod_postal",int.Parse( b.CodPostal));
                cmd.Parameters.AddWithValue("@Id", b.ID);
                //cmd.Parameters.AddWithValue("@Usuario", b.Usuario);
                //cmd.Parameters.AddWithValue("@Contraseña", b.Contraseña);



                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool AgregarServicioABD(Servicio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertServicio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@precio", b.Precio);
                cmd.Parameters.AddWithValue("@nom", b.Nombre);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("error el Agregar el Servicio");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AgregarEspecieABD(Especie b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertEspecie";

                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@nom", b.Nombre);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool AgregarRaza(Raza ra)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertRaza";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", ra.NombreRaza);
                cmd.Parameters.AddWithValue("@descripcion", ra.DescripcionRaza);
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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AgregarTurno(Turno t)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertTurno";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", t.FechaTurno);
                cmd.Parameters.AddWithValue("@hora", t.HoraTurno);
                cmd.Parameters.AddWithValue("@servicio", t.IdServicioTurno);
                cmd.Parameters.AddWithValue("@nroHist", t.NroHistorialClinicoTurno);
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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AgregarMotivo(Motivo m)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertMotivo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", m.NombreMotivo);
                cmd.Parameters.AddWithValue("@desc", m.DescripcionMotivo);
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

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AgregarConsulta(Consulta c, List<int> listaCodVacunas, List<int> listaIdDiagnostico, List<int> listaMedicamento)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertConsulta";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroConsulta", c.NroConsulta);
                cmd.Parameters.AddWithValue("@nroHist", c.NroHistClinicaConsulta);
                cmd.Parameters.AddWithValue("@tipoDoc", c.TipoDocEmpleadoConsulta);
                cmd.Parameters.AddWithValue("@nroDoc", c.NroDocEmpleadoConsulta);
                cmd.Parameters.AddWithValue("@fecha", c.FechaConsulta);
                cmd.Parameters.AddWithValue("@hora", c.HoraConsulta);
                cmd.Parameters.AddWithValue("@idMotivo", c.IdMotivoConsulta);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDeConsulta");
                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();


                foreach (int codigoVac in listaCodVacunas)
                {
                    string queryVacunasXConsulta = "INSERT INTO VACUNAS_X_CONSULTAS VALUES(@cod_vacuna, @nro_consulta, @cantidad)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cod_vacuna", codigoVac);
                    cmd.Parameters.AddWithValue("@nro_consulta", c.NroConsulta);
                    cmd.Parameters.AddWithValue("@cantidad", 1); // esto es 1 porque en una consulta, misma una vacuna siempre tendra una dosis... no se le pueden aplicar mas de una dosis de la misma vacuna en la consulta

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = queryVacunasXConsulta;
                    cmd.ExecuteNonQuery();

                }

                foreach (var idDiag in listaIdDiagnostico)
                {
                    string queryDiagnosticoXConsulta = "INSERT INTO DIAGNOSTICO_X_CONSULTA VALUES(@id_diagnostico, @nro_consulta)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id_diagnostico", idDiag);
                    cmd.Parameters.AddWithValue("@nro_consulta", c.NroConsulta);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = queryDiagnosticoXConsulta;
                    cmd.ExecuteNonQuery();

                }

                foreach (var codmedicamento in listaMedicamento)
                {
                    string consultaPorMed = "InsertMedicamentoXConsulta";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codmed", codmedicamento);
                    cmd.Parameters.AddWithValue("@codcons", c.NroConsulta);
                    cmd.Parameters.AddWithValue("@cantidad", 1);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consultaPorMed;
                    cmd.ExecuteNonQuery();

                }

                objTransaccion.Commit();

                resultado = true;

                return resultado;
            }
            catch (Exception exe)
            {
                objTransaccion.Rollback();
                MessageBox.Show(exe.ToString());
                return false;
                throw;
            }
            finally
            {
                cn.Close();
            }
        }







    }
}
