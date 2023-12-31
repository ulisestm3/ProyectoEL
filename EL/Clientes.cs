﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        [MaxLength(200), Required]
        public string NombreCliente { get; set; }

        [MaxLength(10), Required]
        public string Numero { get; set; }

        [MaxLength(200), Required]
        public string Correo { get; set; }      

        [Required]
        public bool Activo { get; set; }
        [Required]
        public int IdUsuarioRegistra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public Clientes()
        {
            NombreCliente = string.Empty;
            Correo = string.Empty;
            Numero = string.Empty;
        }
    }
}
