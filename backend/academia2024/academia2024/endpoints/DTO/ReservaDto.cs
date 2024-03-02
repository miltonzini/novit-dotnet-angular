namespace academia2024.endpoints.DTO
{
    public record ReservaDto(
        int Id, 
        string Estado, 
        int UsuarioId, 
        int ProductoId);
}
