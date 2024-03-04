using academia2024.Database;
using Carter;
namespace academia2024.endpoints
{
    public class UsuarioEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder routes)
        {
            var app = routes.MapGroup("/api/Reserva");

            // Traer todos los usuarios
            app.MapGet("/listado", (AppDbContext context) =>
            {
                var reservas = context.Reservas.Select(r => r.ConvertToReservaDto());

                return Results.Ok(reservas);

            }).WithTags("Usuario");

            // Traer usuario por Id
            // ...

            // Traer usuarios con rol "vendedor"
            // ... 

            // Traer usuarios con rol "comercial"
            // ...

            // Crear Usuario (post)
            // -- usar api key 
            // -- chequear que NombreUsuario no exista en la base de datos
            // -- hashear contraseña


            // Validar usuario (post)
            // ...


        }
    }
}
