using academia2024.Database;
using Carter;
namespace academia2024.endpoints
{
    public class UsuarioEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder routes)
        {
            var app = routes.MapGroup("/api/Usuario");

            // Traer todos los usuarios
            app.MapGet("/listado", (AppDbContext context) =>
            {
                var usuarios = context.Usuarios.Select(u => u.ConvertToUsuarioDto());

                return Results.Ok(usuarios);

            }).WithTags("Usuario");

            // Traer usuario por Id 
            app.MapGet("/id/{IdUsuario:int}", (AppDbContext context, int IdUsuario) =>
            {
                var usuario = context.Usuarios.Where(u => u.IdUsuario == IdUsuario)
                    .Select(u => u.ConvertToUsuarioDto());

                return Results.Ok(usuario);
            }).WithTags("Usuario");

            // Traer usuarios por rol
            app.MapGet("/codigo/{Rol:alpha}", (AppDbContext context, string Rol) =>
            {
                var usuarios = context.Usuarios.Where(u => u.Rol == Rol)
                    .Select(u => u.ConvertToUsuarioDto());

                return Results.Ok(usuarios);
            }).WithTags("Usuario");

            // Crear Usuario (post)
            // -- usar api key 
            // -- chequear que NombreUsuario no exista en la base de datos
            // -- hashear contraseña


            // Validar usuario (post)
            // ...


        }
    }
}
