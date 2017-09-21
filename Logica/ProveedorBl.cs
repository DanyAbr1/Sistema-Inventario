using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Logica
{
    public class ProveedorBl
    {
        public DataTable LLenarProveedor()
        {
            ProveedorDal pro = new ProveedorDal();

            return pro.ObtenerProveedor();
        }

        public void RegProveedor(Proveedor entidad)
        {
            ProveedorDal regproveedor = new ProveedorDal();

            regproveedor.InsertarProveedor(entidad);

        }

        //public void EliminarClientes(Clientes entidad)
        //{
        //    ClientesDal EliminacionCliente = new ClientesDal();

        //    EliminacionCliente.EliminarClientes(entidad);
        //}

        public void ActualizarProveedor(Proveedor entidad)
        {
            ProveedorDal Actuali = new ProveedorDal();

            Actuali.ActualizarProveedor(entidad);

        }

        public DataTable BusquedaProveedor(string parametro, string opcion)
        {
            ProveedorDal BusquedaPro = new ProveedorDal();

            return BusquedaPro.BusquedaProveedor(parametro, opcion);
        }
    }
}
