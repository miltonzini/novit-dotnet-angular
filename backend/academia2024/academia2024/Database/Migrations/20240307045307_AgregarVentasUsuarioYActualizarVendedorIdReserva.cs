using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace academia2024.Database.Migrations
{
    /// <inheritdoc />
    public partial class AgregarVentasUsuarioYActualizarVendedorIdReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ventas",
                table: "Usuario",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Barrio", "Codigo", "Descripcion", "Estado", "Precio", "UrlImagen" },
                values: new object[] { 6, "Saavedra", "asdasd", "Casa.", "vendido", 1500000, "https://picsum.photos/217" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IdUsuario",
                keyValue: 1,
                column: "Ventas",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "IdUsuario",
                keyValue: 2,
                column: "Ventas",
                value: 0);

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "IdUsuario", "NombreUsuario", "Password", "Rol", "Ventas" },
                values: new object[] { 3, "Esteban", "abcd987", "vendedor", 1 });

            migrationBuilder.InsertData(
                table: "Reserva",
                columns: new[] { "IdReserva", "Estado", "ProductoId", "UsuarioId" },
                values: new object[] { 3, "aprobada", 6, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "IdUsuario",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Ventas",
                table: "Usuario");
        }
    }
}
