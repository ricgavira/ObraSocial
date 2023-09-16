using FluentValidation;
using ObraSocial.Application.Resources;

namespace ObraSocial.Application.Commands.UpdatePessoaFisica
{
    public class UpdatePessoaFisicaCommandValidator : AbstractValidator<UpdatePessoaFisicaCommand>
    {
        public UpdatePessoaFisicaCommandValidator()
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
        }
    }
}