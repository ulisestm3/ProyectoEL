using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Productos")] 
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        [MaxLength(200), Required]
        public string NombreProducto { get; set; }
        [MaxLength(200), Required]
        public string Descripcion { get; set; }
        [MaxLength(10), Required]
        public string Precio { get; set; }
        [MaxLength(10), Required]
        public string Cantidad { get; set; }
        [MaxLength(200), Required]
        public string Proveedor { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public int IdUsuarioRegistra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public Productos()
        {
            NombreProducto = string.Empty;
            Descripcion = string.Empty;
            Precio = string.Empty;
            Cantidad = string.Empty;
            Proveedor = string.Empty;
        }
    }
}
