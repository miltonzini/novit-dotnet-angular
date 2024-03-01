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
        
        [ForeignKey("IdUsuario")]
        [StringLength(100)]
        public string NombreUsuario { get; set; }
        
        [ForeignKey("IdProducto")]
        public int ProductoId { get; set; }
        
        [StringLength(100)]
        public Producto Producto { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
