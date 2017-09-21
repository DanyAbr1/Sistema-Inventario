using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class FacturaDal
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public FacturaDal()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerFactura()
        {
            string query = "Select * From Factura";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }
        public DataTable ObtenerIDFactura(int ID, double Total)
        {
            string query = string.Empty;
            query = "SELECT * FROM Factura WHERE ID_Cliente=@param and Total=@param1";
            using (ComandoSQL = new SqlCommand())
            {
                
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandText = query;
                ComandoSQL.CommandType = CommandType.Text;

                try
                {
                    ComandoSQL.Parameters.AddWithValue("@param", ID);
                    ComandoSQL.Parameters.AddWithValue("@param1", Total);

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
        public void InsertarFactura(Factura Factura)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_FacturaInsert";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Factura", Factura.ID_Factura);
                    ComandoSQL.Parameters.AddWithValue("@Id_Cliente", Factura.Id_Cliente);
                    ComandoSQL.Parameters.AddWithValue("@Fecha", Factura.Fecha);
                    ComandoSQL.Parameters.AddWithValue("@Forma_Pago", Factura.Forma_Pago);
                    ComandoSQL.Parameters.AddWithValue("@Total", Factura.Total);
                    ComandoSQL.Parameters.AddWithValue("@Vendedor", Factura.Vendedor);
                   


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

        public void EliminarClientes(Clientes Clientes)
        {
            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
               // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "Update Clientes SET Estado = @Estado WHERE ID_Cliente = @ID_Cliente";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Cliente", Clientes.ID_Cliente);
                    ComandoSQL.Parameters.AddWithValue("@Estado", Clientes.Estado);
                  

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

        public void ActualizarFactura(Factura factura)
        {
            string query = "UPDATE Clientes SET Nombre = @Nombre," +
                           "Apellido=@Apellido,Direccion = @Direccion, Telefono = @Telefono," +
                           "Documento = @Documento" +
                           " WHERE ID_Cliente = @ID_Cliente";

            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = query;
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Cliente", factura.Id_Cliente);
                    ComandoSQL.Parameters.AddWithValue("@Nombre", factura.Forma_Pago);
                    ComandoSQL.Parameters.AddWithValue("@Direccion", factura.ID_Factura);
                    ComandoSQL.Parameters.AddWithValue("@Telefono", factura.Vendedor);
                    ComandoSQL.Parameters.AddWithValue("@Documento", factura.Fecha);
                    ComandoSQL.Parameters.AddWithValue("@Apellido", factura.Total);


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

        public DataTable BusquedaClientes(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;

            if (opcion.Equals("Nombre"))
            {
                query = "SELECT * FROM Clientes WHERE Nombre LIKE @param and Estado='Y'";
            }
            else if (opcion.Equals("Documento"))
            {
                query = "SELECT * FROM Clientes WHERE Documento LIKE @param and Estado='Y'";
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
