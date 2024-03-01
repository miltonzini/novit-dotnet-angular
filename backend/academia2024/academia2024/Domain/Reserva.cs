namespace academia2024.Domain
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string NombreCliente { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
