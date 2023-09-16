namespace ObraSocial.Domain.Entities
{
    public class Bairro : BaseEntity<Bairro>
    {
        public Bairro(string nome, int cidadeId)
        {
            Nome = nome;
            CidadeId = cidadeId;
        }

        public string Nome { get; private set; }
        public int CidadeId { get; private set; }
        public Cidade? Cidade { get; set; }
        public virtual List<Endereco>? Enderecos { get; set; }
    }
}