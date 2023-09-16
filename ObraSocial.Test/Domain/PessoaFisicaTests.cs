using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Test.Domain
{
    public class PessoaFisicaTests
    {
        private readonly string nome = "Ricardo";
        private readonly string cpf = "11111111111";
        private readonly string nomeMae = "Mae";
        private readonly string nomePai = "Pai";
        private readonly string rg = "0000000";
        private readonly string naturalidade = "Cidade";
        private readonly string nacionalidade = "Brasileira";


        //[Fact(DisplayName = "Deve criar pessoa física")]
        //public void DevePessoaFisica()
        //{
        //    var dataNascimento = new DateTime(1970, 5, 20);
        //    var endereco = new Endereco("Rua da Divisão", TipoEndereco.Residencial, "79100000", new Bairro("Bairro", new Cidade("Cidade", new Estado("Estado", "MS"))), "100");
        //    var pessoaFisica = new PessoaFisica(nome, cpf, rg, nomeMae, nomePai, dataNascimento, null, Raca.Pardo, naturalidade, nacionalidade, Sexo.Masculino);

        //    pessoaFisica.Enderecos.Add(endereco);

        //    var contato = new Contato("Telefone Celular", TipoContato.Celular, "Ricardo");
        //    pessoaFisica.Contatos.Add(contato);

        //    Assert.NotNull(pessoaFisica);
        //    Assert.Equal(pessoaFisica.Nome, nome);
        //    Assert.True(pessoaFisica.Contatos.Count() == 1);
        //}
    }
}