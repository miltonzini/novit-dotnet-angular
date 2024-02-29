using Carter;

namespace academia20204.Endpoints
{
    public class MainEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder routes)
        {
            routes.MapGet("/testHolaMundo", () => "Hello, world!");
            routes.MapPost("/testHolaMundo", () => "Hello, world!");
            routes.MapGet("/sumarUno/{numero}", (int numero) => (numero + 1).ToString());
            routes.MapGet("/testDescribirPersona/{nombre}/{edad}/{ciudad}", (string nombre, int edad, string ciudad) => $"{nombre} tiene {edad} años y vive en {ciudad}.");

        }
    }
}
