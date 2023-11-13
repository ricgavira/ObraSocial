namespace ObraSocial.Domain.Entities
{
    public class Matricula : BaseEntity<Matricula>
    {
        public PessoaFisica Aluno { get; private set; }
        public Turma Turma { get; private set; }
        public SituacaoMatricula SituacaoMatricula { get; private set; }
    }
}