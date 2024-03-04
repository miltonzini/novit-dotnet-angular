﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using academia2024.Database;

#nullable disable

namespace academia2024.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("academia2024.Domain.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Precio")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UrlImagen")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("IdProducto");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Barrio = "Palermo",
                            Descripcion = "Casa con patio.",
                            Estado = "reservado",
                            Precio = 50,
                            UrlImagen = "https://picsum.photos/200"
                        },
                        new
                        {
                            IdProducto = 2,
                            Barrio = "Almagro",
                            Descripcion = "Departamento 2 ambientes.",
                            Estado = "reservado",
                            Precio = 999,
                            UrlImagen = "https://picsum.photos/201"
                        },
                        new
                        {
                            IdProducto = 3,
                            Barrio = "Monserrat",
                            Descripcion = "Departamento 4 ambientes.",
                            Estado = "disponible",
                            Precio = 888,
                            UrlImagen = "https://picsum.photos/202"
                        });
                });

            modelBuilder.Entity("academia2024.Domain.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasMaxLength(100)
                        .HasColumnType("INTEGER");

                    b.HasKey("IdReserva");

                    b.ToTable("Reserva");

                    b.HasData(
                        new
                        {
                            IdReserva = 1,
                            Estado = "ingresada",
                            ProductoId = 1,
                            UsuarioId = 1
                        },
                        new
                        {
                            IdReserva = 2,
                            Estado = "ingresada",
                            ProductoId = 2,
                            UsuarioId = 2
                        });
                });

            modelBuilder.Entity("academia2024.Domain.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            NombreUsuario = "Juan",
                            Password = "abcde",
                            Rol = "comercial"
                        },
                        new
                        {
                            IdUsuario = 2,
                            NombreUsuario = "Martín",
                            Password = "hijkl",
                            Rol = "comercial"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
