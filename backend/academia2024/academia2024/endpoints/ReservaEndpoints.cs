using academia2024.Database;
using Carter;
using Microsoft.EntityFrameworkCore;
namespace academia2024.endpoints
{
    public class ReservaEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder routes)
        {
            var app = routes.MapGroup("/api/Reserva");

            // Traer todas las reservas
            app.MapGet("/listado", (AppDbContext context) =>
            {
                var reservas = context.Reservas
                    .Include(r => r.Usuario)
                    .Include(r => r.Producto)
                    .Select(r => r.ConvertToReservaDto());

                return Results.Ok(reservas);

            }).WithTags("Reserva");

            // Traer reserva según ID
            app.MapGet("/id/{IdReserva:int}", (AppDbContext context, int IdReserva) =>
            {
                var reserva = context.Reservas
                    .Include(r => r.Usuario)
                    .Include(r => r.Producto)
                    .Where(r => r.IdReserva == IdReserva)
                    .Select(r => r.ConvertToReservaDto());

                return Results.Ok(reserva);
            }).WithTags("Reserva");

            // Traer reservas segùn estado
            app.MapGet("/estado/{Estado:alpha}", (AppDbContext context, string Estado) =>
            {
                var reservas = context.Reservas
                    .Include(r => r.Usuario)
                    .Include(r => r.Producto)
                    .Where(r => r.Estado == Estado)
                    .Select(r => r.ConvertToReservaDto());

                return Results.Ok(reservas);
            }).WithTags("Reserva");

            // Ingresar Reserva
            // -- chequear que el usuario sea vendedor
            // -- if (ReservasIngresadasPorElUsuario >= 3)
            // ------ return BadRequest y mostrar mensaje "El máximo de reservas ingresadas por vendedor es 3"
            // -- if (r.producto.barrio = "X" && producto.precio < 100.000)
            // ------ r.estado = "ingresada"
            // -- r.estado = "ingresada"
            // -- r.producto.estado= "reservado"
            // ...

            // Cancelar Reserva
            // -- chequear que el usuario sea vendedor
            // -- chequear que la reserva se encuentre "ingresada"
            // -- ¿chequear que el producto tenga estado "reservado"?
            // -- r.estado = "cancelada"
            // -- r.producto.estado= "disponible"
            // ...


            // Aprobar Reserva
            // -- If (estado == "aprobada" || estado == "cancelada" || estado == "rechazada")
            // ------ return BadRequest y mostrar mensaje "La reserva se encuentra cerrada y no puede modificarse su estado"
            // -- chequear si el usuario logueado y tiene rol comercial
            // -- chequear que el producto tenga estado "reservado"
            // -- r.estado = "aprobada"
            // -- r.producto.estado= "vendido"
            // -- aumentar un número a Usuario.ventas
            // ...


            // Rechazar Reserva
            // -- chequear si el usuario logueado tiene rol comercial
            // -- r.estado = "rechazada"
            // -- r.producto.estado= "disponible"
            // ...

        }
    }
}
