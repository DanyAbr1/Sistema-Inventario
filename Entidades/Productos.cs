using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        public int ID_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public double Precio_Compra { get; set; }
        public double Precio_Venta { get; set; }
        public int Inventario { get; set; }
        public int ID_Proveedor { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        
    }
}
