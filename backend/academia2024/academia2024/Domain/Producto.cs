using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace academia2024.Domain
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        
        [StringLength(200)]
        public string Barrio { get; set; }
        public string? Descripcion { get; set; }

        public int Precio { get; set; }
        public string Estado { get; set; }
        
        [StringLength(200)]
        public string? UrlImagen { get; set; }


    }
}
