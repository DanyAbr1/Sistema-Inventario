using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Datos
{
    class ValidarTexbox
    {
        public bool SoloNumero(string cantidad)
        {
            bool numero;
            Regex rx = new Regex("^[0-9]+([.|,]+[0-9]+)?$");
            if (rx.IsMatch(cantidad))
            {
                numero = true;
            }
            else { numero = false; }
            return numero;
        }
    }
}
