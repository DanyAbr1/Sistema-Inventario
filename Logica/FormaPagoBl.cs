using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Logica
{
    public class FormaPagoBl
    {
        public DataTable buscarFormaPago()
        {
            FormaPagoDal pago = new FormaPagoDal();

            return pago.ObtenerFormaPago();
        }
    }
}
