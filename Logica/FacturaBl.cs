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
    public class FacturaBl
    {
        public DataTable LlenarClientes()
        {
            ClientesDal cli = new ClientesDal();

            return cli.ObtenerClientes();
        }

        public void RegFactura(Factura entidad)
        {
            FacturaDal RegistroFac = new FacturaDal();

            RegistroFac.InsertarFactura(entidad);

        }

        public void EliminarClientes(Clientes entidad)
        {
            ClientesDal EliminacionCliente = new ClientesDal();

            EliminacionCliente.EliminarClientes(entidad);
        }

        public void ActualizarFactura(Factura entidad)
        {
            FacturaDal ActualizacionFac = new FacturaDal();

            ActualizacionFac.ActualizarFactura(entidad);

        }
        public DataTable ObtenerIDFactura(int ID, double Total){  
            FacturaDal ObtenrID = new FacturaDal();
            return ObtenrID.ObtenerIDFactura(ID,Total);
        } 

        public DataTable BusquedaClientes(string parametro, string opcion)
        {
            ClientesDal BusquedaCliente = new ClientesDal();

            return BusquedaCliente.BusquedaClientes(parametro, opcion);
        }
    }
    
}
