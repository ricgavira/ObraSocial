using ObraSocial.Domain.Enums;

namespace ObraSocial.Application.Dtos.Cadastro.Builders
{
    public class PessoaFisicaDtoBuilder
    {
        private PessoaFisicaDto _pessoaFisicaDto;

        public PessoaFisicaDtoBuilder()
        {
            Novo();
        }

        public PessoaFisicaDtoBuilder Novo()
        {
            _pessoaFisicaDto = new PessoaFisicaDto();
            return this;
        }

        public PessoaFisicaDtoBuilder ComNome(string nome)
        {
            _pessoaFisicaDto.Nome = nome;
            return this;
        }

        public PessoaFisicaDtoBuilder ComCPF(string cpf)
        {
            _pessoaFisicaDto.CPF = cpf;
            return this;
        }

        public PessoaFisicaDtoBuilder ComRG(string rg)
        {
            _pessoaFisicaDto.RG = rg;
            return this;
        }

        public PessoaFisicaDtoBuilder ComNomeDaMae(string nomeDaMae)
        {
            _pessoaFisicaDto.NomeDaMae = nomeDaMae;
            return this;
        }

        public PessoaFisicaDtoBuilder ComNomeDoPai(string nomeDoPai)
        {
            _pessoaFisicaDto.NomeDoPai = nomeDoPai;
            return this;
        }

        public PessoaFisicaDtoBuilder ComDataNascimento(DateTime dataNascimento)
        {
            _pessoaFisicaDto.DataNascimento = dataNascimento;
            return this;
        }

        public PessoaFisicaDtoBuilder ComFoto(string foto)
        {
            _pessoaFisicaDto.Foto = foto;
            return this;
        }

        public PessoaFisicaDtoBuilder ComRaca(Raca raca)
        {
            _pessoaFisicaDto.Raca = raca;
            return this;
        }

        public PessoaFisicaDtoBuilder ComNaturalidade(string naturalidade)
        {
            _pessoaFisicaDto.Naturalidade = naturalidade;
            return this;
        }

        public PessoaFisicaDtoBuilder ComNacionalidade(string nacionalidade)
        {
            _pessoaFisicaDto.Nacionalidade = nacionalidade;
            return this;
        }

        public PessoaFisicaDtoBuilder ComSexo(Sexo sexo)
        {
            _pessoaFisicaDto.Sexo = sexo;
            return this;
        }

        public PessoaFisicaDtoBuilder ComContatos(List<ContatoDto> contatosDto)
        {
            _pessoaFisicaDto.ContatosDto = contatosDto;
            return this;
        }

        public PessoaFisicaDtoBuilder ComContato(ContatoDto contatoDto)
        {
            _pessoaFisicaDto.ContatosDto.Add(contatoDto);
            return this;
        }

        public PessoaFisicaDtoBuilder ComEnderecos(List<EnderecoDto> enderecosDto)
        {
            _pessoaFisicaDto.EnderecosDto = enderecosDto;
            return this;
        }

        public PessoaFisicaDtoBuilder ComEndereco(EnderecoDto enderecoDto)
        {
            _pessoaFisicaDto.EnderecosDto.Add(enderecoDto);
            return this;
        }

        public PessoaFisicaDto Build()
        {
            return _pessoaFisicaDto;
        }
    }
}