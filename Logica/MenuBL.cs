using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Logica
{
    public class MenuBL
    {
        MenuDal Reg = new MenuDal();
        public bool VerificarAcceso(string Usu, String Clave)
        {
            return Reg.ValidarUsuario(Usu,Clave);
        }
        public DataSet MostrarMenu()
        {
            return Reg.buscar_Menu();
        }
        public DataSet MostrarSubMenu()
        {
            return Reg.buscar_SubMenu();
        }
    }
}
