using System;

namespace LaptopDeel.Entidades
{
    public class RespaldoDTO
    {
        public DateTime FechaHora { get; set; }
        public string NombreArchivo { get; set; } = string.Empty;
        public string RutaDestino { get; set; } = string.Empty;
        public long TamanoBytes { get; set; }
        public string TipoDestino { get; set; } = string.Empty;
        public bool EstadoExitoso { get; set; }

        public string FechaFormateada => FechaHora.ToString("dd/MM/yyyy HH:mm");

        public string TamanoFormateado
        {
            get
            {
                if (TamanoBytes < 1024) return $"{TamanoBytes} B";
                if (TamanoBytes < 1048576) return $"{(TamanoBytes / 1024.0):F2} KB";
                return $"{(TamanoBytes / 1048576.0):F2} MB";
            }
        }
    }
}