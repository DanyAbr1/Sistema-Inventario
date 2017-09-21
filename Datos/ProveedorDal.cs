using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class ProveedorDal
    {
          #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public ProveedorDal()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerProveedor()
        {
            string query = "Select * From Proveedor'";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public void InsertarProveedor(Proveedor Proveedor)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_ProveedorInsert";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Proveedor", Proveedor.ID_Proveedor);
                    ComandoSQL.Parameters.AddWithValue("@Nombre_Compañia", Proveedor.Nombre_Compañia);
                    ComandoSQL.Parameters.AddWithValue("@Direccion", Proveedor.Direccion);
                    ComandoSQL.Parameters.AddWithValue("@Contacto", Proveedor.Contacto);
                    ComandoSQL.Parameters.AddWithValue("@Correo", Proveedor.Correo);
                    ComandoSQL.Parameters.AddWithValue("@Telefono", Proveedor.Telefono);


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

        public void EliminarClientes(Proveedor Proveedor)
        {
            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
               // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "Update Clientes SET Estado = @Estado WHERE ID_Cliente = @ID_Cliente";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Proveedor", Proveedor.ID_Proveedor);
              //      ComandoSQL.Parameters.AddWithValue("@Estado", Proveedor.Estado);
                  

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

        public void ActualizarProveedor(Proveedor Proveedor)
        {
            string query = "UPDATE Proveedor SET Nombre_Compañia = @Nombre_Compañia," +
                           "Direccion = @Direccion, Telefono = @Telefono," +
                           "Correo = @Correo, Contacto = @Contacto" +
                           " WHERE ID_Proveedor = @ID_Proveedor";

            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = query;
                try
                {
  
                    ComandoSQL.Parameters.AddWithValue("@ID_Proveedor", Proveedor.ID_Proveedor);
                    ComandoSQL.Parameters.AddWithValue("@Nombre_Compañia", Proveedor.Nombre_Compañia);
                    ComandoSQL.Parameters.AddWithValue("@Direccion", Proveedor.Direccion);
                    ComandoSQL.Parameters.AddWithValue("@Contacto", Proveedor.Contacto);
                    ComandoSQL.Parameters.AddWithValue("@Correo", Proveedor.Correo);
                    ComandoSQL.Parameters.AddWithValue("@Telefono", Proveedor.Telefono);

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

        public DataTable BusquedaProveedor(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;

            if (opcion.Equals("Nombre_Compañia"))
            {
                query = "SELECT * FROM Proveedor WHERE Nombre_Compañia LIKE @param";
            }
            else if (opcion.Equals("Contacto"))
            {
                query = "SELECT * FROM Proveedor WHERE Contacto LIKE @param ";
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

    }
}
