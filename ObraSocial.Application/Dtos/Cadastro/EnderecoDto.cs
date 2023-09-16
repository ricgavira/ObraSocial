using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Application.Dtos.Cadastro
{
    public class EnderecoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Bairro Bairro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        public virtual PessoaFisicaDto PessoaFisicaDto { get; set; }
    }
}
