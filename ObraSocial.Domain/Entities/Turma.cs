namespace ObraSocial.Domain.Entities
{
    public class Turma : BaseEntity<Turma>
    {
        public string Nome { get; private set; }
        public Curso Curso { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }
        public List<PessoaFisica> Instrutores { get; private set; }
        public Livro Sustentaculo { get; private set; }
        public Situacao Situacao { get; private set; }
    }
}
