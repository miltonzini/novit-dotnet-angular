using System.ComponentModel.DataAnnotations;

namespace academia2024.endpoints.DTO
{
    public record UsuarioDto(
        int IdUsuario,
        string NombreUsuario,
        string Password,
        string Rol);
}
