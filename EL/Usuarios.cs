using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Bloqueado { get; set; }
        public byte IntentosFallidos { get; set; }
        public short IdRol { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public Usuarios()
        {
            NombreCompleto = string.Empty;
            Correo = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
        }
    }
}
