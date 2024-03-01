using Microsoft.EntityFrameworkCore;
using academia2024.Domain;

namespace academia2024.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Poductos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
