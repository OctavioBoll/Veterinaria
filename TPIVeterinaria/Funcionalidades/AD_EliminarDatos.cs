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
    public class AD_EliminarDatos
    {


        public static bool EliminarClienteBD(Cliente med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarCliente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipodoc", med.TipoDocumento);
                cmd.Parameters.AddWithValue("@nrodoc", med.NumeroDocumento);

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



        public static bool EliminarMascotaBD(Mascotas med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarMascota";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipodoc", med.TipoDocMascota);
                cmd.Parameters.AddWithValue("@nrodoc", med.NroDocMascota);
                cmd.Parameters.AddWithValue("@nrohis", med.NroHistoMascota);

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

        public static bool EliminarProveedorDeBD(Proveedores prov)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarProveedor";

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
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarVacunasDeBD(Vacunas vac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarVacunas";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codvac", vac.CodigoVacuna);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarMedicamentoDeBD(Medicamentos med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarMedicamento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codmed", med.CodigoMedicamento);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }


        public static bool EliminarBarrioBD(Barrio med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarBarrio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codpost", med.CodigoPostal);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarCargoBD(Cargo med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarCargo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcargo", med.IdCargo);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool EliminarDiagnosticoBD(Diagnostico med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarDiagnostico";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iddiag", med.IdDiagnostico);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool EliminarTipoDocumentoBD(TipoDocumento med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarTipoDocumento";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtipo", med.IdTipoDocumento);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarServicioBD(Servicio med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarServicio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idserv", med.ID);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool EliminarEspecieBD(Especie med)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarEspecie";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idesp", med.ID);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay medicamentos que pertenecen a este proveedor. Por favor primero elimine los medicamentos");
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }





        public static bool EliminarTurno(int NroTurno)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "EliminarTurno";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nro", NroTurno);
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
        public static bool EliminarRaza(int IdRaza)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "EliminarRaza";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdRaza", IdRaza);
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
        public static bool EliminarMotivo(int IdMotivo)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "EliminarMotivo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", IdMotivo);
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
        public static bool EliminarConsulta(int consulSelecc)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "EliminarConsulta";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nro", consulSelecc);
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







    }
}
