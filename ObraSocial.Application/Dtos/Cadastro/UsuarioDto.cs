﻿namespace ObraSocial.Application.Dtos.Cadastro
{
    public class UsuarioDto
    {
        public UsuarioDto(string nome, string login, string password)
        {
            Nome = nome;
            Login = login;
            Password = password;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
