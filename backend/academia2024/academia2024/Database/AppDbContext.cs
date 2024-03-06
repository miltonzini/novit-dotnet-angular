using Microsoft.EntityFrameworkCore;
using academia2024.Domain;

namespace academia2024.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    IdProducto = 1,
                    Codigo = "abc123",
                    Barrio = "Palermo",
                    Descripcion = "Casa con patio.",
                    Precio = 50,
                    Estado = "reservado",
                    UrlImagen = "https://picsum.photos/200"
                },
                new Producto
                {
                    IdProducto = 2,
                    Codigo = "oqj234",
                    Barrio = "Almagro",
                    Descripcion = "Departamento 2 ambientes.",
                    Precio = 999,
                    Estado = "reservado",
                    UrlImagen = "https://picsum.photos/201"
                },
                new Producto
                {
                    IdProducto = 3,
                    Codigo = "hij255",
                    Barrio = "Monserrat",
                    Descripcion = "Departamento 4 ambientes.",
                    Precio = 888,
                    Estado = "disponible",
                    UrlImagen = "https://picsum.photos/202"
                },
                new Producto
                {
                    IdProducto = 4,
                    Codigo = "oij255",
                    Barrio = "Palermo",
                    Descripcion = "Departamento 1 ambiente.",
                    Precio = 888,
                    Estado = "disponible",
                    UrlImagen = "https://picsum.photos/210"
                },
                new Producto
                {
                    IdProducto = 5,
                    Codigo = "laq255",
                    Barrio = "Monserrat",
                    Descripcion = "Monoambiente.",
                    Precio = 888,
                    Estado = "disponible",
                    UrlImagen = "https://picsum.photos/210"
                }
            );
            modelBuilder.Entity<Usuario>().HasData(
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
                    Password = "hijkl",
                    Rol = "comercial"
                }
            );
            modelBuilder.Entity<Reserva>().HasData(
                new Reserva
                {
                    IdReserva = 1,
                    Estado = "ingresada",
                    UsuarioId = 1,
                    ProductoId = 1
                },
                new Reserva
                {
                    IdReserva = 2,
                    Estado = "ingresada",
                    UsuarioId = 2,
                    ProductoId = 2
                }
            );
        }
    }
}
