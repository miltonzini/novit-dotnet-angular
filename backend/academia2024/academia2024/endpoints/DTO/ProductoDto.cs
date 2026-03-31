namespace academia2024.endpoints.DTO
{
    public record ProductoDto(
        int IdProducto,
        string Codigo, 
        string Barrio,
        string? Descripcion,
        int Precio,
        string Estado,
        string? UrlImagen);
}