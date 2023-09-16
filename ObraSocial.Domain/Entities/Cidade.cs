namespace ObraSocial.Domain.Entities
{
    public class Cidade : BaseEntity<Cidade>
    {
        public Cidade(string nome, int estadoId)
        {
            Nome = nome;
            EstadoId = estadoId;
        }

        public string Nome { get; private set; }
        public int EstadoId { get; private set; }
        public Estado? Estado { get; set; }
        public virtual List<Bairro>? Bairros { get; set; }
    }
}