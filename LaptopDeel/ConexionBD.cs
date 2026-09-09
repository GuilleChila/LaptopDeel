using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace LaptopDeel
{
    public class ConexionBD
    {
        private const string Cadena = "Server=127.0.0.1;Port=3307;Database=laptopdeel_db;Uid=leadepre;Pwd=leloandro;SslMode=none;";

        // Solo crea y devuelve la instancia (sin abrirla)
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(Cadena);
        }

        public static bool ProbarConexion()
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open(); // Se abre una sola vez dentro del using
                    return conexion.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del error:\n" + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}