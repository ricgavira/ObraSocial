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

        public PessoaFisicaDto Novo()
        {
            _pessoaFisicaDto = new PessoaFisicaDto();
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComNome(string nome)
        {
            _pessoaFisicaDto.Nome = nome;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComCPF(string cpf)
        {
            _pessoaFisicaDto.CPF = cpf;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComRG(string rg)
        {
            _pessoaFisicaDto.RG = rg;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComNomeDaMae(string nomeDaMae)
        {
            _pessoaFisicaDto.NomeDaMae = nomeDaMae;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComNomeDoPai(string nomeDoPai)
        {
            _pessoaFisicaDto.NomeDoPai = nomeDoPai;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComDataNascimento(DateTime dataNascimento)
        {
            _pessoaFisicaDto.DataNascimento = dataNascimento;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComFoto(byte[] foto)
        {
            _pessoaFisicaDto.Foto = foto;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComRaca(Raca raca)
        {
            _pessoaFisicaDto.Raca = raca;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComNaturalidade(string naturalidade)
        {
            _pessoaFisicaDto.Naturalidade = naturalidade;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComNacionalidade(string nacionalidade)
        {
            _pessoaFisicaDto.Nacionalidade = nacionalidade;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComSexo(Sexo sexo)
        {
            _pessoaFisicaDto.Sexo = sexo;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComContatos(List<ContatoDto> contatosDto)
        {
            _pessoaFisicaDto.ContatosDto = contatosDto;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComContato(ContatoDto contatoDto)
        {
            _pessoaFisicaDto.ContatosDto.Add(contatoDto);
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComEnderecos(List<EnderecoDto> enderecosDto)
        {
            _pessoaFisicaDto.EnderecosDto = enderecosDto;
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto ComEndereco(EnderecoDto enderecoDto)
        {
            _pessoaFisicaDto.EnderecosDto.Add(enderecoDto);
            return _pessoaFisicaDto;
        }

        public PessoaFisicaDto Build()
        {
            return _pessoaFisicaDto;
        }
    }
}