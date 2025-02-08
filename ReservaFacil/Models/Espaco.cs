namespace ReservaFacil.Models
{
    public class Espaco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CapacidadeMaxima { get; set; }
        public bool Disponivel { get; set; } = true;
    }
}
