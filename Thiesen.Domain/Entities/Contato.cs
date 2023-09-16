using ObraSocial.Domain.Enums;

namespace ObraSocial.Domain.Entities
{
    public class Contato : BaseEntity<Contato>
    {
        public Contato(string nome, TipoContato tipoContato, int pessoaFisicaId)
        {
            Nome = nome;
            TipoContato = tipoContato;
            PessoaFisicaId = pessoaFisicaId;
        }

        public string Nome { get; private set; }
        public TipoContato TipoContato { get; private set; }
        public int PessoaFisicaId { get; private set; }
        public PessoaFisica? PessoaFisica { get; set; }
    }
}
