using FluentValidation;
using ObraSocial.Application.Resources;

namespace ObraSocial.Application.Dtos.Cadastro.Validations
{
    public class UsuarioDtoValidator : AbstractValidator<UsuarioDto>
    {
        public UsuarioDtoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(ValidationMessages.RequiredNome);

            RuleFor(x => x.Login)
                    .NotEmpty()
                    .EmailAddress()
                    .WithMessage(ValidationMessages.InvalidEmail);

            RuleFor(x => x.Password)
                    .NotEmpty()
                    .WithMessage(ValidationMessages.RequiredPassword);
        }
    }
}