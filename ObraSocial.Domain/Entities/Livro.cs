namespace ObraSocial.Domain.Entities
{
    public class Livro : BaseEntity<Livro>
    {
        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public string ISBN { get; private set; }
        public string Espirito { get; private set; }
        public string Psicografia { get; private set; }
        public string Edicao { get; private set; }
        public PessoaJuridica Editora { get; private set; }
        public int AnoPublicacao { get; private set; }
        public string Sinopse { get; private set; }
        public Genero Genero { get; private set; }
        public byte[]? Foto { get; private set; }
    }
}
