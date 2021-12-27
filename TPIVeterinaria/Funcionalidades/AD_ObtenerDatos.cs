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
    public class AD_ObtenerDatos
    {
        public static Cliente ObtenerCliente(string documento, int tipodoc)//Busca en la tabla el cliente con el Doc enviado y devuelve a la persona(p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente p = new Cliente();

            SqlCommand cmd = new SqlCommand();
            string consulta = "ConsultCliente";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@documento", documento);
            cmd.Parameters.AddWithValue("@tipodoc", tipodoc);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null && dr.Read())
            {
                p.NombreClientes = dr["nombre"].ToString();
                p.ApellidoCliente = dr["apellido"].ToString();
                p.TipoDocumento = int.Parse(dr["tipo_doc_dueño"].ToString());
                p.NumeroDocumento = dr["nro_doc_dueño"].ToString();
                p.MailCliente = dr["mail"].ToString();
            }
            cn.Close();
            return p;
        }
        public static bool ValidarUsuario(string nombreDeUsuario, string password, int cargo)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);

            try
            {
                bool resultado = false;
                bool resultadoCargo = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@passUsu", password);
                cmd.Parameters.AddWithValue("@id_Cargo", cargo);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                //otro validar
                resultadoCargo = ValidarCargo(cargo);

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1 && resultadoCargo == true)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
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
        public static bool ValidarCargo(int cargo)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultRolEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCargo", cargo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static Mascotas ObtenerMascotasPorNombre(string documento, int tipodoc, int nrohisto)//Busca en la tabla el cliente con el Doc enviado y devuelve a la persona(p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Mascotas p = new Mascotas();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetUnaMascota";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.Parameters.AddWithValue("@tipodoc", tipodoc);
                cmd.Parameters.AddWithValue("@nrohitso", nrohisto);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    p.NroHistoMascota = int.Parse(dr["nro_hist_clinica"].ToString());
                    p.NombreMascota = dr["nombre"].ToString();
                    p.IdRazaMascota = int.Parse(dr["id_raza"].ToString());
                    p.IdEspecieMascota = int.Parse(dr["id_especie"].ToString());
                    p.IdSexoMascota = int.Parse(dr["id_sexo"].ToString());
                    p.NroDocMascota = dr["nro_doc_dueño"].ToString();
                    p.TipoDocMascota = int.Parse(dr["tipo_doc_dueño"].ToString());
                    p.FechaIngresoMascota = DateTime.Parse(dr["fecha_nacimiento"].ToString());
                    p.FechaNacMascota = DateTime.Parse(dr["fecha_ingreso_vet"].ToString());
                    p.PesoAproxMascota = int.Parse(dr["peso_aprox_ingreso"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return p;
        }
        public static Mascotas ObtenerMascotas(string documento, int tipodoc)//Busca en la tabla el cliente con el Doc enviado y devuelve a la mascota(p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Mascotas p = new Mascotas();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MASCOTAS WHERE nro_doc_dueño like @documento AND tipo_doc_dueño like @tipodoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.Parameters.AddWithValue("@tipodoc", tipodoc);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    p.NroHistoMascota = int.Parse(dr["nro_hist_clinica"].ToString());
                    p.NombreMascota = dr["nombre"].ToString();
                    p.IdRazaMascota = int.Parse(dr["id_raza"].ToString());
                    p.IdEspecieMascota = int.Parse(dr["id_especie"].ToString());
                    p.IdSexoMascota = int.Parse(dr["id_sexo"].ToString());
                    p.NroDocMascota = dr["nro_doc_dueño"].ToString();
                    p.TipoDocMascota = int.Parse(dr["tipo_doc_dueño"].ToString());
                    p.FechaIngresoMascota = DateTime.Parse(dr["fecha_nacimiento"].ToString());
                    p.FechaNacMascota = DateTime.Parse(dr["fecha_ingreso_vet"].ToString());
                    p.PesoAproxMascota = int.Parse(dr["peso_aprox_ingreso"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static Proveedores ObtenerProveedorAEliminar(int codProv)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Proveedores p = new Proveedores();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultProvedor";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProv", codProv);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.CodigoDelProveedor = int.Parse(dr["mat_lab_prov"].ToString());
                    p.NombreProveedor = dr["nombre"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static Vacunas ObtenerVacunasxcod(int codvac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Vacunas p = new Vacunas();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultVacunas";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codvac", codvac);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.CodigoVacuna = int.Parse(dr["cod_vacuna"].ToString());
                    p.PrecioVacuna = float.Parse(dr["precio"].ToString());
                    p.NombreVacuna = dr["descripcion"].ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static Medicamentos ObtenerMedicamento(int codmed)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Medicamentos p = new Medicamentos();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultMedicamento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codmed", codmed);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.CodigoMedicamento = int.Parse(dr["cod_medicamento"].ToString());
                    p.PrecioMedicamento = float.Parse(dr["precio"].ToString());
                    p.DescripcionMedicamento = dr["descripcion"].ToString();
                    p.CodProveedor = int.Parse(dr["mat_lab_prov"].ToString());


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }



        public static Cargo ObtenerCargo(int idcargo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cargo p = new Cargo();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultCargo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcargo", idcargo);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.IdCargo = int.Parse(dr["id_cargo"].ToString());
                    p.NombreCargo = dr["nombre"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }
        public static Diagnostico ObtenerDiagnostico(int iddiag)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Diagnostico p = new Diagnostico();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultDiagnostico";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iddiag", iddiag);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.IdDiagnostico = int.Parse(dr["id_diagnostico"].ToString());
                    p.Nombrediagnostico = dr["nombre_diagnostico"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }
        public static TipoDocumento ObtenerTipoDocumento(int idtipo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            TipoDocumento p = new TipoDocumento();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultTipoDocumento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtipo", idtipo);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.IdTipoDocumento = int.Parse(dr["id_tipo_documento"].ToString());
                    p.NombreTipoDoc = dr["nombre_tipo_documento"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static Empleados ObtenerEmpleado(int idtipo, string doc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Empleados p = new Empleados();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultEmpleado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrodoc", doc);
                cmd.Parameters.AddWithValue("@idtipo", idtipo);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    p.TipoDocumento = int.Parse(dr["tipo_doc_dueño"].ToString());
                    p.NroDocumento = dr["nro_doc_dueño"].ToString();
                    p.Nombre = dr["nombre"].ToString();
                    p.Apellido = dr["apellido"].ToString();
                    p.Celular = dr["celular"].ToString();
                    p.Cargo = int.Parse(dr["id_cargo"].ToString());
                    p.FechaIngreso = DateTime.Parse(dr["fecha_ingreso"].ToString());
                    p.Calle = dr["calle"].ToString();
                    p.NroCalle = dr["calle_nro"].ToString();
                    p.CodPostal = dr["cod_postal"].ToString();
                    //p.ID = int.Parse(dr["idEmpleado"].ToString());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Persisten problemas...");
            }
            finally
            {
                cn.Close();
            }
            return p;

        }
        //"SELECT * FROM EMPLEADOS WHERE @nrodoc = nro_doc_dueño"

        public static DataTable ObtenerEmpleadoXDoc(int nroDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM EMPLEADOS WHERE @nrodoc = nro_doc_dueño";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrodoc", nroDoc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static Servicio ObtenerServicio(int idser)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Servicio p = new Servicio();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultServicio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idserv", idser);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.ID = int.Parse(dr["id_servicio"].ToString());
                    p.Nombre = dr["nombre"].ToString();
                    p.Precio = float.Parse(dr["costo"].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde");
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static Especie ObtenerEspecie(int idesp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Especie p = new Especie();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultEspecie";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idesp", idesp);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.ID = int.Parse(dr["id_especie"].ToString());
                    p.Nombre = dr["nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        public static Consulta ObtenerUnaConsulta(int nroconsu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Consulta c = new Consulta();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultConsultaXNumero";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroconsu", nroconsu);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    c.NroConsulta = int.Parse(dr["nro_consulta"].ToString());
                    c.NroHistClinicaConsulta = int.Parse(dr["nro_hist_clinica"].ToString());
                    c.TipoDocEmpleadoConsulta = int.Parse(dr["tipo_doc_empleado"].ToString());
                    c.NroDocEmpleadoConsulta = dr["nombre"].ToString();
                    c.FechaConsulta = DateTime.Parse(dr["fecha"].ToString());
                    c.HoraConsulta = TimeSpan.Parse(dr["hora"].ToString());
                    c.IdMotivoConsulta = int.Parse(dr["id_motivo"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si persisten los problemas intente nuevamente mas tarde" + ex);
            }
            finally
            {
                cn.Close();
            }
            return c;
        }

        public static DataTable ObtenerBarrio(int codpost)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codpost", codpost);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable ObtenerMedicamentoPorCodigo(int codMed)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultMedicamentoXCodigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codMed", codMed);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable ObtenerMedicamentoPorDescripcion(string desc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultMedicamentoXDescirpcion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable ConsultarProveedorPorCodigoProv(int codProv)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultBuscarProveedorXCodigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProv", codProv);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable ExisteHistoriaClinica(int nroHistoria)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM MASCOTAS WHERE nro_hist_clinica = @nroHistoria";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroHistoria", nroHistoria);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
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


        public static DataTable ConsultarProveedorPorNombreProv(string nomProv)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultBuscarProveedorXNombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomProv", nomProv);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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


        public static DataTable ObtenerVacuna(int codvac)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultVacunas";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codvac", codvac);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable ObtenerVacunaXnom(string nomVac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ConsultVacunasXnom";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", nomVac);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        

        public static bool ValidarNorHistClinica(int Nro)
    {
        string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection cn = new SqlConnection(cadenaConexion);

        try
        {
            SqlCommand cmd = new SqlCommand();
            string consulta = "ConsultNroHistClinica";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nro", Nro);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = consulta;

            cn.Open();

            cmd.Connection = cn;

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            if (tabla.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            MessageBox.Show("ERROR... Hay probñlmas al validar");
            return false;
        }
        finally
        {
            cn.Close();
        }

       
    }
        public static int obtenerIdEmpleado()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(id) FROM Usuario";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();

                cmd.Connection = cn;


                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {
                
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        public static int ObtenerUltimoNroConsulta()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(nro_consulta) FROM CONSULTAS";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }

        }

        public static DataTable ObtenerDiagnosticoParaTransaccion(int idDiagnostico)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM DIAGNOSTICO WHERE id_diagnostico like @idDiag";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idDiag", idDiagnostico);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable ObtenerEmpleadosIngresadosEnJulio()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM EMPLEADOS WHERE MONTH(fecha_ingreso) = '07'";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable ObtenerNroEmpleadosPorCargo()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT c.nombre as 'Nombre', COUNT(e.nombre) as 'Cantidad' from Cargos c join EMPLEADOS e on (e.id_cargo=c.id_cargo) group by c.nombre";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

        public static DataTable obtenerDiagnosticoXNombre(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDiagnosticoXNombre";

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@nombre", nombre);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                return tabla;
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

    }


}

 