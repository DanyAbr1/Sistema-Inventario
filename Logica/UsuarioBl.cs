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
    public class UsuarioBl
    {

            public DataTable LlenarClientes()
            {
                ClientesDal cli = new ClientesDal();

                return cli.ObtenerClientes();
            }

            public void RegUsuario(Usuario entidad)
            {
                UsuarioDal RegistroUsu = new UsuarioDal();

                RegistroUsu.InsertarUsuario(entidad);

            }

            public void EliminarUsuario(Usuario entidad)
            {
                UsuarioDal EliminacionUsuario = new UsuarioDal();

                EliminacionUsuario.EliminarUsuario(entidad);
            }

            public void ActualizarUsuario(Usuario entidad)
            {
                UsuarioDal ActualizarUsuario = new UsuarioDal();

                ActualizarUsuario.ActualizarUsuario(entidad);

            }

            public DataTable ObtenerNivelUsuario()
            {
                UsuarioDal nivel = new UsuarioDal();
                return nivel.ObtenerNivel();
            }
            public DataTable BuscarNivelUsuario(string nivelusu)
            {
                UsuarioDal nivel = new UsuarioDal();
                return nivel.BuscarNivelpermiso(nivelusu);
            }
            public DataTable BusquedaUsuario(string parametro, string opcion)
            {
                UsuarioDal BusquedaUsuario = new UsuarioDal();

                return BusquedaUsuario.BusquedaUsuario(parametro, opcion);
            }
        }
    }

