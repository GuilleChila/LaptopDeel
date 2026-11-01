using System;

namespace LaptopDeel.Entidades
{
    public class LogSesionDTO
    {
        public int IdSesion { get; set; }
        public string Usuario { get; set; } = string.Empty;
        public DateTime UltimaActividad { get; set; }
        public string TiempoActivo { get; set; } = string.Empty;

        public LogSesionDTO() { }

        public LogSesionDTO(int idSesion, string usuario, DateTime ultimaActividad, string tiempoActivo)
        {
            IdSesion = idSesion;
            Usuario = usuario;
            UltimaActividad = ultimaActividad;
            TiempoActivo = tiempoActivo;
        }
    }
}