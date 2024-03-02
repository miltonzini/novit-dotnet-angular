using Microsoft.EntityFrameworkCore;
using academia2024.Domain;

namespace academia2024.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Poductos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Usuario
                {
                    IdUsuario = 1,
                    NombreUsuario = "Juan",
                    Password = "abcde",
                    Rol = "comercial"
                },
                new Usuario
                {
                IdUsuario = 2,
                    NombreUsuario = "Martín",
                    Password = "abcde",
                    Rol = "comercial"
                },

                new Producto
                {
                    IdProducto = 1,
                    Barrio = "Palermo",
                    Descripcion = "Casa con patio.",
                    Precio = 50,
                    Estado = "reservado",
                    UrlImagen = "https://picsum.photos/200"
                },
                new Producto
                {
                    IdProducto = 2,
                    Barrio = "Almagro",
                    Descripcion = "Departamento 2 ambientes.",
                    Precio = 999,
                    Estado = "reservado",
                    UrlImagen = "https://picsum.photos/201"
                },
                new Producto
                {
                    IdProducto = 3,
                    Barrio = "Monserrat",
                    Descripcion = "Departamento 4 ambientes.",
                    Precio = 888,
                    Estado = "disponible",
                    UrlImagen = "https://picsum.photos/202"
                },
                new Reserva
                {
                    Id = 1,
                    Estado = "ingresada",
                    UsuarioId = 1,
                    ProductoId = 1
                },
                new Reserva
                {
                    Id = 2,
                    Estado = "ingresada",
                    UsuarioId = 2,
                    ProductoId = 2
                }
                );
        }
    }
}
