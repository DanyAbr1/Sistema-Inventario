using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFacturas
    {

        public int ID_DetalleFactura { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public int ID_Factura { get; set; }
        public double Monto { get; set; }
        public double Itbis { get; set; }
        //public int ID_Cliente { get; set; }

    }
}
