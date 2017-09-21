using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        
        public int ID_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public int Id_Cliente { get; set; }
        public string Forma_Pago { get; set; }
        public string Vendedor { get; set; }

    }
}
