namespace academia2024.endpoints.DTO
{
    public record ReservaDto(
        int IdReserva, 
        string Estado, 
        int UsuarioId, 
        string NombreUsuario,
        int ProductoId,
        string DescripcionProducto
        );
}
