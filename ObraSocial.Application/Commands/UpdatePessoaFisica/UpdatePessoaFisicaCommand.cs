using MediatR;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Application.Commands.UpdatePessoaFisica
{
    public class UpdatePessoaFisicaCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? RG { get; set; }
        public string? NomeDaMae { get; set; }
        public string? NomeDoPai { get; set; }
        public Raca? Raca { get; set; }
        public Sexo? Sexo { get; set; }
        public string? Naturalidade { get; set; }
        public string? Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public byte[]? Foto { get; set; }
        public List<ContatoDto>? ContatosDto { get; set; }
        public List<EnderecoDto>? EnderecosDto { get; set; }

    }
}