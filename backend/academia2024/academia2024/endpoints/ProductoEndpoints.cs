using academia2024.Database;
using Carter;
using academia2024.endpoints.DTO;
using academia2024.Domain;
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
            app.MapPost("/crear", (AppDbContext context, ProductoDto productoDto) =>
            {
                // Pending: chequear que el usuario de la sesión tenga el rol "vendedor".
                // ...

                // Agregar.
                Producto producto = new Producto
                {
                    Codigo = productoDto.Codigo,
                    Barrio = productoDto.Barrio,
                    Descripcion = productoDto.Descripcion,
                    Precio = productoDto.Precio,
                    Estado = productoDto.Estado,
                    UrlImagen = productoDto.UrlImagen,
                };

                context.Productos.Add(producto);

                context.SaveChanges();

                return Results.Created();
            }).WithTags("Producto");


            // Actualizar producto
            app.MapPut("/{idProducto}", (AppDbContext context, int idProducto, ProductoDto productoDto) =>
            {
                // Pending: chequear que el usuario de la sesión tenga el rol "vendedor".
                // ...

                // Actualizar.
                var producto = context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);

                if (producto is null)
                    return Results.BadRequest("El producto no existe");

                producto.Codigo = productoDto.Codigo;
                producto.Barrio = productoDto.Barrio;
                producto.Descripcion = productoDto.Descripcion;
                producto.Precio = productoDto.Precio;
                producto.Estado = productoDto.Estado;
                producto.UrlImagen = productoDto.UrlImagen;

                context.SaveChanges();

                return Results.Ok();
            }).WithTags("Producto");


            // Eliminar producto
            app.MapDelete("/eliminar/{idProducto}", (AppDbContext context, int idProducto) =>
            {
                // Pending: chequear que el usuario de la sesión tenga el rol "vendedor".
                // ...

                // Eliminar
                var producto = context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);

                if (producto is null)
                    return Results.BadRequest("El producto no existe");

                context.Productos.Remove(producto);

                context.SaveChanges();

                return Results.NoContent();
            }).WithTags("Producto");

        }
    }
}
