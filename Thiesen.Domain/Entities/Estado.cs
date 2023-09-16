namespace ObraSocial.Domain.Entities
{
    public class Estado : BaseEntity<Estado>
    {
        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        public virtual List<Cidade>? Cidades { get; set; }
    }
}
