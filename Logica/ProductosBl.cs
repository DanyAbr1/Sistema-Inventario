using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class ProductosBl
    {

        public DataTable LLenarProductos()
        {
            ProductosDal pro = new ProductosDal();

            return pro.ObtenerProductos();
        }

        public void RegProducto(Productos entidad)
        {
           ProductosDal regproductos = new ProductosDal();

           regproductos.InsertarProductos(entidad);

        }

        //public void EliminarClientes(Clientes entidad)
        //{
        //    ClientesDal EliminacionCliente = new ClientesDal();

        //    EliminacionCliente.EliminarClientes(entidad);
        //}

        public void ActualizarProductos(Productos entidad)
        {
            ProductosDal Actuali = new ProductosDal();

            Actuali.ActualizarProductos(entidad);

        }
        public void ActualizarInventario(Productos entidad)
        {
            ProductosDal ActualInv = new ProductosDal();

            ActualInv.ActualizarInventario(entidad);

        }

        public DataTable BusquedaProductos(string parametro, string opcion)
        {
            ProductosDal BusquedaPro = new ProductosDal();

            return BusquedaPro.BusquedaProductos(parametro, opcion);
        }
        public DataTable BuscarCombo(int ID_Proveedor)
        {
            ProductosDal Buscarcombo = new ProductosDal();

            return Buscarcombo.BusquedaCombo(ID_Proveedor);
        }
        public DataTable verProveedor()
        {
            ProductosDal prod = new ProductosDal();
            return prod.DatProveedor();

        }
        public DataTable buscarInventario(string Ndesc, string FechaF, string FechaT, string exist, string provee)
        {
            ProductosDal proDal= new ProductosDal();

            return proDal.BuscarInventario(Ndesc, FechaF, FechaT, exist, provee);
        }
        public bool ValidarInvetario(int cant,string producto)
        {
            ProductosDal val= new ProductosDal();
            return val.ValidarInventario(cant, producto);
        }
    }
}

