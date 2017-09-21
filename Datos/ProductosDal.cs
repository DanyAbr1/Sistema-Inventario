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
    public class ProductosDal
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        private SqlDataReader Reader;
        DataSet ds = new DataSet();
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public ProductosDal()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerProductos()
        {
            string query = "Select * From Producto ";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public void InsertarProductos(Productos Producto)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "proc_ProductoInsert";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Producto", Producto.ID_Producto);
                    ComandoSQL.Parameters.AddWithValue("@Descripcion_Producto", Producto.Descripcion_Producto);
                    ComandoSQL.Parameters.AddWithValue("@Precio_Compra", Producto.Precio_Compra);
                    ComandoSQL.Parameters.AddWithValue("@Precio_Venta", Producto.Precio_Venta);
                    ComandoSQL.Parameters.AddWithValue("@Inventario", Producto.Inventario);
                    ComandoSQL.Parameters.AddWithValue("@ID_Proveedor", Producto.ID_Proveedor);
                    ComandoSQL.Parameters.AddWithValue("@Fecha_Entrada", Producto.Fecha_Entrada);



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

        //public void EliminarClientes(Clientes Clientes)
        //{
        //    AccesoDatos.ObtenerConexion().Open();


        //    using (ComandoSQL = new SqlCommand())
        //    {
        //        ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
        //       // ComandoSQL.CommandType = CommandType.StoredProcedure;
        //        ComandoSQL.CommandText = "Update Clientes SET Estado = @Estado WHERE ID_Cliente = @ID_Cliente";
        //        try
        //        {
        //            ComandoSQL.Parameters.AddWithValue("@ID_Cliente", Clientes.ID_Cliente);
        //            ComandoSQL.Parameters.AddWithValue("@Estado", Clientes.Estado);


        //            //Ejecutar Comando
        //            ComandoSQL.ExecuteNonQuery();
        //        }
        //        catch (Exception)
        //        {
        //            throw;

        //        }
        //        finally
        //        {
        //            AccesoDatos.ObtenerConexion().Close();
        //        }

        //    }

        //}

        public void ActualizarProductos(Productos Producto)
        {
            string query = "UPDATE Producto SET Descripcion_Producto = @Descripcion_Producto," +
                           "Precio_Compra = @Precio_Compra, Precio_Venta = @Precio_Venta," +
                           "Inventario = @Inventario,Fecha_Entrada=@Fecha_Entrada"+
                           " WHERE ID_Producto = @ID_Producto";

            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = query;
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Producto", Producto.ID_Producto);
                    ComandoSQL.Parameters.AddWithValue("@Descripcion_Producto", Producto.Descripcion_Producto);
                    ComandoSQL.Parameters.AddWithValue("@Precio_Compra", Producto.Precio_Compra);
                    ComandoSQL.Parameters.AddWithValue("@Precio_Venta", Producto.Precio_Venta);
                    ComandoSQL.Parameters.AddWithValue("@Inventario", Producto.Inventario);
                    ComandoSQL.Parameters.AddWithValue("@Fecha_Entrada", Producto.Fecha_Entrada);

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
        public void ActualizarInventario(Productos Producto)
        {
            string query = "UPDATE Producto SET Inventario = Inventario-@Inventario Where ID_Producto=@ID_Producto";

            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = query;
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID_Producto", Producto.ID_Producto);
                    //ComandoSQL.Parameters.AddWithValue("@Descripcion_Producto", Producto.Descripcion_Producto);
                    //ComandoSQL.Parameters.AddWithValue("@Precio_Compra", Producto.Precio_Compra);
                    //ComandoSQL.Parameters.AddWithValue("@Precio_Venta", Producto.Precio_Venta);
                    ComandoSQL.Parameters.AddWithValue("@Inventario", Producto.Inventario);


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
        public DataTable BusquedaProductos(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;

            if (opcion.Equals("Descripcion_Producto"))
            {
                query = "SELECT * FROM Producto WHERE Descripcion_Producto LIKE @param";
            }
            else if (opcion.Equals("ID_Producto"))
            {
                query = "SELECT * FROM Producto WHERE ID_Producto LIKE @param";
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
        public DataTable BusquedaCombo(int ID_Proveedor)
        {
             AccesoDatos.ObtenerConexion().Open();
             string query = string.Empty;

                      
            query = "SELECT * FROM Proveedor WHERE ID_Proveedor=@param";
            

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandText = query;
                ComandoSQL.CommandType = CommandType.Text;

                try
                {
                    ComandoSQL.Parameters.AddWithValue("@param", ""+ID_Proveedor+"");


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
        public DataTable DatProveedor()
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;


            query = "SELECT * FROM Proveedor";


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandText = query;
                ComandoSQL.CommandType = CommandType.Text;

                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@param", "%" + parametro + "%");


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
        public bool ValidarInventario(int inventario, string producto)
        {
            bool existe = false;
            int i = 0;
            string query = "select * from Producto where Descripcion_Producto=@Descripcion and Inventario>=@param";
            using (SqlCommand cmd = new SqlCommand(query, AccesoDatos.ObtenerConexion()))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@param", inventario);
                    cmd.Parameters.AddWithValue("@Descripcion", producto);

                    Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        i++;
                    }

                    if (i >= 1) { existe = true; }
                    else { existe = false; }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Reader.Close();
                    cmd.Connection.Close();
                }
                return existe;
            }
        }
        public DataTable BuscarInventario(string desc,string fechaFrom,string fechaTo,string exist, string provee) 
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;
            if (string.Empty != desc)
            {
                desc = " and Descripcion_Producto like '"+desc+"'";
            }

            if (string.Empty != exist)
            {
                if (exist == "Si") 
                {
                    exist = " and Inventario > '0'";
                }
                if (exist == "No")
                {
                    exist = " and Inventario = '0'";
                }
            }
            if (string.Empty != provee)
            {
                provee = " and Proveedor.Nombre_Compañia Like '" + provee + "'";
            }
            query = "SELECT ID_Producto,Fecha_Entrada,Descripcion_Producto,Precio_Compra,Precio_Venta,Inventario,Proveedor.Nombre_Compañia"
            + " From Producto inner join Proveedor on Producto.ID_Proveedor = Proveedor.ID_Proveedor" +
            " WHERE Fecha_Entrada between('" + fechaFrom + "' )and('" + fechaTo + "')" + desc + "" + exist + "" + provee + "";
            
            //SELECT ID_Producto,Fecha_Entrada,Descripcion_Producto,Precio_Compra,Precio_Venta,Inventario,sup.Nombre_Compañia FROM Producto pro, Proveedor sup WHERE pro.Fecha_Entrada between('2017-09-15' )and('2017-09-15') and Descripcion_Producto like '%bl%' and Inventario > '0' and sup.Nombre_Compañia like '%Block Dominicana  %'
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandText = query;
                ComandoSQL.CommandType = CommandType.Text;

                try
                {
                   // ComandoSQL.Parameters.AddWithValue("@param", "" + ID_Proveedor + "");


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
