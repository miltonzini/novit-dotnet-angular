using academia2024.Database;
using Carter;
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
                var reservas = context.Reservas.Select(r => r.ConvertToReservaDto());

                return Results.Ok(reservas);

            }).WithTags("Reserva");

            // Traer reserva según ID
            // ...

            // Traer reservas con estado "ingresada"
            // ...

            // Traer reservas con estado "aprobada"
            // ...

            // Traer reservas con estado "cancelada"
            // ...

            // Traer reservas con estado "rechazada"
            // ...

            // Ingresar Reserva
            // -- r.estado = "ingresada"
            // -- r.producto.estado= "reservado"
            // ...

            // Aprobar Reserva
            // -- r.estado = "aprobada"
            // -- r.producto.estado= "vendido"
            // ...

            // Cancelar Reserva
            // -- r.estado = "cancelada"
            // -- r.producto.estado= "disponible"
            // ...

            // Rechazar Reserva
            // -- r.estado = "rechazada"
            // -- r.producto.estado= "disponible"
            // ...

        }
    }
}
