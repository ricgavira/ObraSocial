using ObraSocial.Application.Dtos.Cadastro.Builders;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Test.Service
{
    public class PessoaFisicaCommandTests
    {
        private readonly string nome = "Ricardo";
        private readonly string cpf = "11111111111";
        private readonly string nomeMae = "Mae";
        private readonly string nomePai = "Pai";
        private readonly string rg = "0000000";
        private readonly string naturalidade = "Cidade";
        private readonly string nacionalidade = "Brasileira";
        private PessoaFisica pessoaFisica;
        private PessoaFisicaDtoBuilder pessoaFisicaDtoBuilder;

        public PessoaFisicaCommandTests()
        {
            var dataNascimento = new DateTime(1970, 5, 20);
            pessoaFisica = new PessoaFisica(nome, cpf, rg, nomeMae, nomePai, dataNascimento, null, Raca.Pardo, naturalidade, nacionalidade, Sexo.Masculino);
            pessoaFisicaDtoBuilder = new PessoaFisicaDtoBuilder();
            //pessoaFisicaDtoBuilder
            //    .ComNome(nome)
                

            //    nome, cpf, rg, nomeMae, nomePai, dataNascimento, null, Raca.Pardo, naturalidade, nacionalidade, Sexo.Masculino
        }

        //[Fact(DisplayName = "Deve criar uma pessoa física sem erros de validação")]
        //public async Task DeveCriarUmaPessoaFisicaSemErrosDeValidacao()
        //{
        //    var pessoaFisicaRepositoryMock = Substitute.For<IPessoaFisicaRepository>();
        //    var mapperMock = Substitute.For<IMapper>();
        //    var validatorMock = Substitute.For<IValidator<PessoaFisicaDto>>();
            
        //    pessoaFisicaRepositoryMock.AddAsync(Arg.Any<PessoaFisica>())
        //                              .Returns(pessoaFisica);

        //    mapperMock.Map<PessoaFisica>(Arg.Any<PessoaFisicaDto>())
        //              .Returns(pessoaFisica);

        //    mapperMock.Map<PessoaFisicaDto>(Arg.Any<PessoaFisica>())
        //                     .Returns(pessoaFisicaDto);

        //    validatorMock.Validate(Arg.Any<PessoaFisicaDto>())
        //                 .Returns(new ValidationResult());

        //    var pessoaFisicaService = new PessoaFisicaService(pessoaFisicaRepositoryMock, mapperMock, validatorMock);

        //    var result = await pessoaFisicaService.CreateAsync(pessoaFisicaDto);

        //    Assert.NotNull(result);
        //}
   }
}