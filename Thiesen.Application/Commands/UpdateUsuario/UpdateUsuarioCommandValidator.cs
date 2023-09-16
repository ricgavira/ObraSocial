using FluentValidation;
using ObraSocial.Application.Resources;

namespace ObraSocial.Application.Commands.UpdateUsuario
{
    public class UpdateUsuarioCommandValidator : AbstractValidator<UpdateUsuarioCommand>
    {
        public UpdateUsuarioCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(ValidationMessages.RequiredNome);

            RuleFor(x => x.Login)
                .NotEmpty()
                .WithMessage(ValidationMessages.RequiredLogin);

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(ValidationMessages.RequiredPassword);
        }
    }
}