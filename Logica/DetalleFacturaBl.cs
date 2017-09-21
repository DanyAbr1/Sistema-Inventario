using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Logica
{
    public class DetalleFacturaBl
    {
        public DataTable LlenarClientes()
        {
            ClientesDal cli = new ClientesDal();

            return cli.ObtenerClientes();
        }

        public void RegDetalleFactura(DetalleFacturas entidad)
        {
            DetalleFacturaDal RegistroDetalle = new DetalleFacturaDal();

            RegistroDetalle.InsertaDetalleFactura(entidad);

        }

        public void EliminarClientes(Clientes entidad)
        {
            ClientesDal EliminacionCliente = new ClientesDal();

            EliminacionCliente.EliminarClientes(entidad);
        }

        public void ActualizarClientes(Clientes entidad)
        {
            ClientesDal ActualizacionCliente = new ClientesDal();

            ActualizacionCliente.ActualizarClientes(entidad);

        }

        public DataTable BusquedaClientes(string parametro, string opcion)
        {
            ClientesDal BusquedaCliente = new ClientesDal();

            return BusquedaCliente.BusquedaClientes(parametro, opcion);
        }
    }
}
