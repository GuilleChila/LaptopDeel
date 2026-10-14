using System;
using System.Data;
using MySqlConnector;

namespace LaptopDeel.Datos
{
    public class ConexionBD
    {
        private const string Cadena = "Server=127.0.0.1;Port=3308;Database=laptopdeel_db;Uid=leadepre;Pwd=leloandro;SslMode=none;";

        // Solo crea y devuelve la instancia (sin abrirla)
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(Cadena);
        }
    }
}