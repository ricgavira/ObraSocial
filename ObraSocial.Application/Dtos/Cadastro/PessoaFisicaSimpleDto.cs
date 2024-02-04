using ObraSocial.Domain;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Application.Dtos.Cadastro
{
    public class PessoaFisicaSimpleDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? NomeDaMae { get; set; }
        public string? NomeDoPai { get; set; }
        public Raca? Raca { get; set; }
        public Sexo? Sexo { get; set; }
        public Classificacao Classificacao { get; set; }
        public string? Naturalidade { get; set; }
        public string? Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}