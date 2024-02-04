namespace ObraSocial.Domain.Entities
{
    public class Curso : BaseEntity<Curso>
    {
        public string Nome { get; private set; }
        public Situacao Situacao { get; private set; }
        public Livro Doutrinario { get; private set; }
    }
}