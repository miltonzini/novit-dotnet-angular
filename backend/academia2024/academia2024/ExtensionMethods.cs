using academia2024.Domain;
using academia2024.endpoints.DTO;

namespace academia2024

{
    public static class ExtensionMethods   
    {
        public static ReservaDto ConvertToReservaDto(this Reserva r) =>
            new(r.IdReserva, r.Estado, r.UsuarioId, r.Usuario.NombreUsuario, r.ProductoId, r.Producto.Descripcion);

        public static UsuarioDto ConvertToUsuarioDto(this Usuario u) =>
            new(u.IdUsuario, u.NombreUsuario, u.Password, u.Rol, u.Ventas);

        public static ProductoDto ConvertToProductoDto(this Producto p) =>
            new(p.IdProducto, p.Codigo, p.Barrio, p.Descripcion, p.Precio, p.Estado, p.UrlImagen);
    }
}
