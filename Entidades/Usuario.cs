using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string NUsuario { get; set; }
        public string Clave { get; set; }
        public string Nivel { get; set; }
        public string Estado { get; set; }
    }
}
