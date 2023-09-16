using FluentValidation;
using ObraSocial.Application.Helpers;
using ObraSocial.Application.Resources;

namespace ObraSocial.Application.Dtos.Cadastro.Validations
{
    public class PessoaFisicaDtoValidator : AbstractValidator<PessoaFisicaDto>
    {
        public PessoaFisicaDtoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(ValidationMessages.RequiredNome);

            RuleFor(x => x.NomeDaMae)
                .NotEmpty()
                .WithMessage(ValidationMessages.RequiredNomeMae);

            RuleFor(x => x.DataNascimento)
                .NotNull()
                .WithMessage(ValidationMessages.RequiredDataNascimento)
                .LessThan(DateTime.Now)
                .WithMessage(ValidationMessages.InvalidDataNascimento);

            RuleFor(x => x.CPF)
                .NotEmpty()
                .WithMessage(ValidationMessages.RequiredCPF)
                .Must(CPFHelper.IsValid)
                .WithMessage(ValidationMessages.InvalidCPF);
        }
    }
}