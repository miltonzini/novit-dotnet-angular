namespace academia2024.endpoints.DTO
{
    public record ProductoDto(
        int IdProducto,
        string Barrio,
        string? Descripcion,
        int Precio,
        string Estado,
        string? UrlImagen);
}
