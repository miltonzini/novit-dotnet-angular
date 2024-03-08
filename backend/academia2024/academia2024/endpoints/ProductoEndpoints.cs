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
            app.MapGet("/id/{IdProducto:int}", (AppDbContext context, int IdProducto) =>
            {
                var productos = context.Productos.Where(p => p.IdProducto == IdProducto)
                    .Select(p => p.ConvertToProductoDto());

                return Results.Ok(productos);
            }).WithTags("Producto");


            // Traer producto por código alfanumérico
            app.MapGet("/codigo/{Codigo:regex([a-zA-Z0-9]+)}", (AppDbContext context, string Codigo) =>
            {
                var productos = context.Productos.Where(p => p.Codigo == Codigo)
                    .Select(p => p.ConvertToProductoDto());

                return Results.Ok(productos);
            }).WithTags("Producto");


            // Traer productos por estado
            app.MapGet("/estado/{Estado:alpha}", (AppDbContext context, string Estado) =>
            {
                var productos = context.Productos.Where(p => p.Estado == Estado)
                    .Select(p => p.ConvertToProductoDto());

                return Results.Ok(productos);
            }).WithTags("Producto");


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
