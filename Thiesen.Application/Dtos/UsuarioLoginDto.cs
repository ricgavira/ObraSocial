namespace ObraSocial.Application.Dtos
{
    public class UsuarioLoginDto
    {
        public UsuarioLoginDto(string login, string token)
        {
            Login = login;
            Token = token;
        }

        public string Login { get; set; }
        public string Token { get; set; }
    }
}