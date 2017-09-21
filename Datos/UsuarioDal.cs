using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class UsuarioDal
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public UsuarioDal()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerUsuario()
        {
            string query = "Select * From Usuario where Estado ='Y'";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public void InsertarUsuario(Usuario Usuario)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_UsuarioInsert";
                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@Id_Usuario", Usuario.Id_Usuario);
                    ComandoSQL.Parameters.AddWithValue("@Usuario", Usuario.NUsuario);
                    ComandoSQL.Parameters.AddWithValue("@Clave", Usuario.Clave);
                    ComandoSQL.Parameters.AddWithValue("@Nivel", Usuario.Nivel);
                    ComandoSQL.Parameters.AddWithValue("@Estado", Usuario.Estado);


                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
            }

        }

        public void EliminarUsuario(Usuario Usuario)
        {
            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "Update Usuario SET Estado = @Estado WHERE ID_Usuario = @ID_Usuario";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Usuario", Usuario.ID_Usuario);
                    ComandoSQL.Parameters.AddWithValue("@Estado", Usuario.Estado);
                    //ComandoSQL.Parameters.AddWithValue("@Clave", Usuario.Clave);
                    //ComandoSQL.Parameters.AddWithValue("@Nivel", Usuario.Nivel);



                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }

            }

        }

        public void ActualizarUsuario(Usuario Usuario)
        {
            string query = "UPDATE Usuario SET Usuario = @Usuario," +
                           "Clave=@Clave,Nivel = @Nivel WHERE ID_Usuario = @ID_Usuario";

            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = query;
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Usuario", Usuario.ID_Usuario);
                    ComandoSQL.Parameters.AddWithValue("@Usuario", Usuario.NUsuario);
                    ComandoSQL.Parameters.AddWithValue("@Clave", Usuario.Clave);
                    ComandoSQL.Parameters.AddWithValue("@Nivel", Usuario.Nivel);
                   // ComandoSQL.Parameters.AddWithValue("@Estado", Usuario.Estado);
               


                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }

            }

        }

        public DataTable BusquedaUsuario(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;

            if (opcion.Equals("Usuario"))
            {
                query = "SELECT * FROM Usuario WHERE Usuario LIKE @param and Estado='Y'";
            }
            else if (opcion.Equals("ID_Usuario"))
            {
                query = "SELECT * FROM Usuario WHERE ID_Usuario LIKE @param and Estado='Y'";
            }

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandText = query;
                ComandoSQL.CommandType = CommandType.Text;

                try
                {
                    ComandoSQL.Parameters.AddWithValue("@param", "%" + parametro + "%");


                    using (AdaptadorSQL = new SqlDataAdapter())
                    {
                        AdaptadorSQL.SelectCommand = ComandoSQL;
                        Dt = new DataTable();
                        AdaptadorSQL.Fill(Dt);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }

                return Dt;
            }
        }
        public DataTable ObtenerNivel()
        {
            string query = "Select * From NivelUsuario";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;

        }
        public DataTable BuscarNivelpermiso(string parametro)
        {
            string query = "Select Nivel From Usuario Where Usuario = @param";
              
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandText = query;
                ComandoSQL.CommandType = CommandType.Text;

                try
                {
                    ComandoSQL.Parameters.AddWithValue("@param", parametro);


                    using (AdaptadorSQL = new SqlDataAdapter())
                    {
                        AdaptadorSQL.SelectCommand = ComandoSQL;
                        Dt = new DataTable();
                        AdaptadorSQL.Fill(Dt);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }

                return Dt;
            }

        } 

    }
}
