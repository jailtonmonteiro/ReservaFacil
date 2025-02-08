namespace ReservaFacil.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime DataReserva { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = new Usuario();
    }
}
