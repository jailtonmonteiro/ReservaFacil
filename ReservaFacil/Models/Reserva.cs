namespace ReservaFacil.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        //Dados de Usuário
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = new Usuario();

        //Dados de Espaço
        public int EspacoId { get; set; }
        public Espaco Espaco { get; set; } = new Espaco();

        //Dados de Reserva
        public DateTime DataReserva { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string Observacao { get; set; } = string.Empty;
        public bool Confirmada { get; set; } = false;
    }
}
