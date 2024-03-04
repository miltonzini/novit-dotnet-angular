using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace academia2024.Database.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barrio = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    UrlImagen = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", maxLength: 100, nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.IdReserva);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreUsuario = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Rol = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Barrio", "Descripcion", "Estado", "Precio", "UrlImagen" },
                values: new object[,]
                {
                    { -3, "Monserrat", "Departamento 4 ambientes.", "disponible", 888, "https://picsum.photos/202" },
                    { -2, "Almagro", "Departamento 2 ambientes.", "reservado", 999, "https://picsum.photos/201" },
                    { -1, "Palermo", "Casa con patio.", "reservado", 50, "https://picsum.photos/200" }
                });

            migrationBuilder.InsertData(
                table: "Reserva",
                columns: new[] { "IdReserva", "Estado", "ProductoId", "UsuarioId" },
                values: new object[,]
                {
                    { -2, "ingresada", 2, 2 },
                    { -1, "ingresada", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "IdUsuario", "NombreUsuario", "Password", "Rol" },
                values: new object[,]
                {
                    { -2, "Martín", "abcde", "comercial" },
                    { -1, "Juan", "abcde", "comercial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
