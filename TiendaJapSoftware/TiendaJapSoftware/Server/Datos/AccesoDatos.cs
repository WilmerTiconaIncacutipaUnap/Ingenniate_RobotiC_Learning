using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaJapSoftware.Server.Datos
{
    public class AccesoDatos
    {
        private string cadenaConexionSql;
        public string CadenaConexionSQL { get => cadenaConexionSql; }
        public AccesoDatos(string ConexionSql)
        {
            cadenaConexionSql = ConexionSql;
        }
    }
}
