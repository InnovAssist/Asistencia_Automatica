using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MySql.Data.MySqlClient;

namespace Asistencia_Automatica
{
    public class Conexion
    {
        // Parametros para conectar a la DB
        private string IP = "localhost";
        private string BaseDeDatos = "asistencias";
        private string Usuario = "root";
        private string password = "";
        private string cadenaConexion;
        private MySqlConnection conexion;

        // String con todos los parametros juntos
        public Conexion()
        {
            cadenaConexion = "Database=" + BaseDeDatos +
                             "; DataSource=" + IP +
                             "; User Id=" + Usuario +
                             "; Password=" + password;
        }

        // Funcion de conexion para conectar a la conectividad
        public MySqlConnection getConexion()
        {

            // Se fija si la conexion es conectable
            if (conexion == null)
            {
                // Si es conectable la conecta
                conexion = new MySqlConnection(cadenaConexion);
                // Abre la conexion conectada
                conexion.Open();
            }

            // Devuelve la conexion conectada 
            return conexion;

        }
    }
}

