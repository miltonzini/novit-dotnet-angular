using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace academia2024.Database.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCodigoProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Producto",
                type: "TEXT",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                column: "Codigo",
                value: "abc123");

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2,
                column: "Codigo",
                value: "oqj234");

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 3,
                column: "Codigo",
                value: "hij255");

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Barrio", "Codigo", "Descripcion", "Estado", "Precio", "UrlImagen" },
                values: new object[,]
                {
                    { 4, "Palermo", "oij255", "Departamento 1 ambiente.", "disponible", 888, "https://picsum.photos/210" },
                    { 5, "Monserrat", "laq255", "Monoambiente.", "disponible", 888, "https://picsum.photos/210" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Producto");
        }
    }
}
