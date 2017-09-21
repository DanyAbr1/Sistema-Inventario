using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Datos
{
    public class Acceso
    {
        // Clase de acceso a datos.

        #region "Variables (Clases) de Conexion"
        private SqlConnection Conexion;
        #endregion

        //Constructor
        public Acceso()
        {
            Conexion = new SqlConnection(CadenaConexion);
        }
        private string CadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Facturacion.Properties.Settings.Conex"].ToString();
            }

        }

        public SqlConnection ObtenerConexion()
        {
            return Conexion;
        }
    }
}
