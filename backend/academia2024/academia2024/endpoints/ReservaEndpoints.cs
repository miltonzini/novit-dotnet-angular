using academia2024.Database;
using Carter;
using Microsoft.EntityFrameworkCore;
using academia2024.endpoints.DTO;
using academia2024.Domain;
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
            app.MapPost("/crear", (AppDbContext context, ReservaDto reservaDto) =>
            {
                // Pending: chequear que el usuario de la sesión tenga el rol "vendedor".
                // ...

                // Pending (validación cantidad de reservas hechas por el usuario):
                // -- if (ReservasIngresadasPorElUsuario >= 3)
                // ------ return BadRequest y mostrar mensaje "El máximo de reservas ingresadas por vendedor es 3"
                // ...

                // Pending (otras validaciones de la consigna):
                // -- if (r.producto.barrio = "X" && producto.precio < 100.000) [crear variable bool "autoaprobar"]
                // ------ r.estado = "aprobada"
                // ------ r.producto.estado = "vendido"
                // -- else
                // ------ r.estado = "ingresada"
                // ------ r.producto.estado = "reservado"
                // ------ u.reservasIngresadas++

                Reserva reserva = new Reserva
                {
                    UsuarioId = reservaDto.UsuarioId,
                    ProductoId = reservaDto.ProductoId
                };
                // Obtener el nombre del usuario y la descripción del producto
                var usuario = context.Usuarios.FirstOrDefault(u => u.IdUsuario == reservaDto.UsuarioId);
                var producto = context.Productos.FirstOrDefault(p => p.IdProducto == reservaDto.ProductoId);

                if (usuario != null && producto != null)
                {
                    reserva.NombreUsuario = usuario.NombreUsuario;
                    reserva.DescripcionProducto = producto.Descripcion;
                }
                else
                {
                    return Results.BadRequest("Usuario o producto no encontrado");
                }

                context.Reservas.Add(reserva);
                
                // pending: sumar 1 en Usuario.ReservasIngresadas

                context.SaveChanges();

                return Results.Created();
            }).WithTags("Reserva");

            
            // Cancelar Reserva
            // -- chequear que el usuario de la sesión tenga el rol "vendedor".
            // -- chequear que la reserva se encuentre "ingresada"
            // -- ¿chequear que el producto tenga estado "reservado"?
            // -- r.estado = "cancelada"
            // -- r.producto.estado= "disponible"
            // ...


            // Aprobar Reserva
            // -- If (estado == "aprobada" || estado == "cancelada" || estado == "rechazada")
            // ------ return BadRequest y mostrar mensaje "La reserva se encuentra cerrada y no puede modificarse su estado"
            // -- chequear haya sesión iniciada y que el usuario de la misma tenga rol comercial
            // -- chequear que el producto tenga estado "reservado"
            // -- r.estado = "aprobada"
            // -- r.producto.estado= "vendido"
            // -- aumentar un número a Usuario.ventas
            // ...


            // Rechazar Reserva
            // -- chequear haya sesión iniciada y que el usuario de la misma tenga rol comercial
            // -- r.estado = "rechazada"
            // -- r.producto.estado = "disponible".
            // ...

        }
    }
}
