namespace ObraSocial.Application.Dtos.Cadastro
{
    public class UsuarioRetornoDto
    {
        public UsuarioRetornoDto(string nome, string login)
        {
            Nome = nome;
            Login = login;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
    }
}
