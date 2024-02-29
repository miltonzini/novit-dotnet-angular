using Carter;

namespace academia20204.Endpoints
{
    public class MainEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder routes)
        {
            var app = routes.MapGroup("/api/test");

            app.MapGet("/HolaMundo", () => "Hello, world!").WithTags("Hola Mundo");
            app.MapPost("/HolaMundo", () => "Hello, world!").WithTags("Hola Mundo");
            app.MapGet("/sumarUno/{numero}", (int numero) => (numero + 1).ToString()).WithTags("Otros");
            app.MapGet("/DescribirPersona/{nombre}/{edad}/{ciudad}", (string nombre, int edad, string ciudad) => $"{nombre} tiene {edad} años y vive en {ciudad}.").WithTags("Otros");

        }
    }
}
