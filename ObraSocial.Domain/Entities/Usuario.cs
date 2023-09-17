using ObraSocial.Domain.Enums;

namespace ObraSocial.Domain.Entities
{
    public class Usuario : BaseEntity<Usuario>
    {
        public Usuario() { }
        public Usuario(string nome, string login, string password, Role role)
        {
            Nome = nome;
            Login = login;
            Password = password;
            Role = role;
        }

        public string Nome { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Role Role { get; private set; }
    }
}
