using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace academia2024.Database.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "IdUsuario",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "IdUsuario",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Barrio", "Descripcion", "Estado", "Precio", "UrlImagen" },
                values: new object[,]
                {
                    { 1, "Palermo", "Casa con patio.", "reservado", 50, "https://picsum.photos/200" },
                    { 2, "Almagro", "Departamento 2 ambientes.", "reservado", 999, "https://picsum.photos/201" },
                    { 3, "Monserrat", "Departamento 4 ambientes.", "disponible", 888, "https://picsum.photos/202" }
                });

            migrationBuilder.InsertData(
                table: "Reserva",
                columns: new[] { "IdReserva", "Estado", "ProductoId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "ingresada", 1, 1 },
                    { 2, "ingresada", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "IdUsuario", "NombreUsuario", "Password", "Rol" },
                values: new object[,]
                {
                    { 1, "Juan", "abcde", "comercial" },
                    { 2, "Martín", "hijkl", "comercial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "IdUsuario",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "IdUsuario",
                keyValue: 2);

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
    }
}
