using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace academia2024.Domain
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public string Estado { get; set; }
        
        [ForeignKey("UsuarioId")]
        [StringLength(100)]
        public int UsuarioId { get; set; }
        
        [ForeignKey("IdProducto")]
        public int ProductoId { get; set; }
     }
}
