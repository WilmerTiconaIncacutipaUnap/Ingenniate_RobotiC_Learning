using System;
using System.Text;

namespace TiendaJapSoftware.Server
{
    public static class Seguridad
    {
        public static string Encriptar(string cadenaEncriptar)
        {
            String resultado = string.Empty;
            byte[] encriptado = Encoding.Unicode.GetBytes(cadenaEncriptar);
            resultado = Convert.ToBase64String(encriptado);
            return resultado;
        }
        public static string DesEncriptar(string cadenaDesencriptar)
        {
            String resultado = string.Empty;
            byte[] desencriptado = Convert.FromBase64String(cadenaDesencriptar);
            resultado = Encoding.Unicode.GetString(desencriptado);
            return resultado;
        }
    }
}
