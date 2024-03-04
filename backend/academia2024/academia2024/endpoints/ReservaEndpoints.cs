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
            // -- chequear que el usuario sea vendedor
            // -- if (ReservasIngresadasPorElUsuario >= 3)
            // ------ return BadRequest y mostrar mensaje "El máximo de reservas ingresadas por vendedor es 3"
            // -- if (r.producto.barrio = "X" && producto.precio < 100.000)
            // ------ r.estado = "ingresada"
            // -- r.estado = "ingresada"
            // -- r.producto.estado= "reservado"
            // ...

            // Aprobar Reserva
            // -- If (estado == "aprobada" || estado == "cancelada" || estado == "rechazada")
            // ------ return BadRequest y mostrar mensaje "La reserva se encuentra cerrada y no puede modificarse su estado"
            // -- chequear si el usuario logueado tiene rol comercial
            // -- chequear que el producto tenga estado "reservado"
            // -- r.estado = "aprobada"
            // -- r.producto.estado= "vendido"
            // ...

            // Cancelar Reserva
            // -- chequear que el producto tenga estado "reservado"
            // -- r.estado = "cancelada"
            // -- r.producto.estado= "disponible"
            // ...

            // Rechazar Reserva
            // -- chequear si el usuario logueado tiene rol comercial
            // -- r.estado = "rechazada"
            // -- r.producto.estado= "disponible"
            // ...

        }
    }
}
