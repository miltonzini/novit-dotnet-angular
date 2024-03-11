using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace academia2024.Database.Migrations
{
    /// <inheritdoc />
    public partial class AgregarAtributosFaltantesEnReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescripcionProducto",
                table: "Reserva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreUsuario",
                table: "Reserva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: 1,
                columns: new[] { "DescripcionProducto", "NombreUsuario" },
                values: new object[] { "Casa con patio.", "Juan" });

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: 2,
                columns: new[] { "DescripcionProducto", "NombreUsuario" },
                values: new object[] { "Departamento 2 ambientes.", "Martín" });

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReserva",
                keyValue: 3,
                columns: new[] { "DescripcionProducto", "NombreUsuario" },
                values: new object[] { "Casa.", "Esteban" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionProducto",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "NombreUsuario",
                table: "Reserva");
        }
    }
}
