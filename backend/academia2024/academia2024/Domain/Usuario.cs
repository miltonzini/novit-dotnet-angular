using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace academia2024.Domain
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        
        [StringLength(100)]
        public string NombreUsuario { get; set; }
        
        [StringLength(100)]
        public string password { get; set; }
        
        [StringLength(100)]
        public string rol { get; set; }

    }
}
