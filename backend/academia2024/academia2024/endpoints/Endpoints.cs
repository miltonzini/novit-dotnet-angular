using Carter;

namespace academia20204.Endpoints
{
    public class MainEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder routes)
        {
            var app = routes.MapGroup("/api/test");

            app.MapGet("/HolaMundo", () => "Hello, world!").WithTags("Endpoints de prueba iniciales");
            app.MapPost("/HolaMundo", () => "Hello, world!").WithTags("Endpoints de prueba iniciales");
            app.MapGet("/sumarUno/{numero}", (int numero) => (numero + 1).ToString()).WithTags("Endpoints de prueba iniciales");
            app.MapGet("/DescribirPersona/{nombre}/{edad}/{ciudad}", (string nombre, int edad, string ciudad) => $"{nombre} tiene {edad} años y vive en {ciudad}.").WithTags("Endpoints de prueba iniciales");

        }
    }
}