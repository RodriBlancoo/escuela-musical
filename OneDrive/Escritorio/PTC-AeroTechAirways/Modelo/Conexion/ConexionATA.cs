using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    internal class ConexionATA
    {
        private static string servidor = "LAPTOP-RGPV52QC\\SQLEXPRESS";
        private static string baseDeDatos = "aerotech_airways";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={baseDeDatos};Integrated Security =true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}