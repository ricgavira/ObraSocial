using NSubstitute;
using ObraSocial.Domain;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Test.Domain
{
    public class PessoaFisicaTests
    {
        [Fact(DisplayName = "Deve criar pessoa física")]
        public void DevePessoaFisica()
        {
            var pessoaFisica = new PessoaFisica(
                Arg.Any<string>(),
                Arg.Is<string>(x => x.Length == 11),
                Arg.Any<string>(),
                Arg.Any<string>(),
                Arg.Any<string>(),
                Arg.Any<DateTime>(),
                null,
                Raca.Pardo, 
                Arg.Any<string>(),
                Arg.Any<string>(),
                Sexo.Masculino,
                Classificacao.Funcionario);

            pessoaFisica.Enderecos.Add(SetupEndereco());
            pessoaFisica.Contatos.Add(SetupContato());

            Assert.NotNull(pessoaFisica);
            Assert.Equal(pessoaFisica?.Contatos?.Count(), 1);
        }

        private Contato SetupContato()
        {
            return new Contato(
                    Arg.Any<string>(),
                    TipoContato.Celular,
                    Arg.Any<int>()
                );
        }
        private Endereco SetupEndereco()
        {

            return new Endereco(
                            Arg.Any<string>(), 
                            TipoEndereco.Residencial, 
                            Arg.Is<string>(s => s.Length == 8),
                            Arg.Any<int>(),
                            Arg.Is<string>(s => s.Length == 4)
                            );
        }
    }
}