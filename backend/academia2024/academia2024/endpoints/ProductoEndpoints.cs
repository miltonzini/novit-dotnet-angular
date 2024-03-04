using academia2024.Database;
using Carter;
namespace academia2024.endpoints
{
    public class ProductoEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder routes)
        {
            var app = routes.MapGroup("/api/Producto");

            // Traer todos los productos
            app.MapGet("/listado", (AppDbContext context) =>
            {
                var productos = context.Productos.Select(p => p.ConvertToProductoDto());

                return Results.Ok(productos);

            }).WithTags("Producto");

            // Traer producto según ID
            app.MapGet("/{IdProducto:int}", (AppDbContext context, int IdProducto) =>
            {
                var productos = context.Productos.Where(p => p.IdProducto == IdProducto)
                    .Select(p => p.ConvertToProductoDto());

                return Results.Ok(productos);
            }).WithTags("Producto");


            // Traer producto por código alfanumérico
            // ...

            // Traer productos con estado "disponible"
            // ...

            // Traer productos con estado "reservado"
            // ...

            // Traer productos con estado "vendido"
            // ...

            // Crear nuevo producto
            // -- chequear que el usuario sea vendedor
            // ...

            // Actualizar producto
            // -- chequear que el usuario sea vendedor
            // ...

            // Eliminar producto
            // -- chequear que el usuario sea vendedor
            // ...

        }
    }
}
