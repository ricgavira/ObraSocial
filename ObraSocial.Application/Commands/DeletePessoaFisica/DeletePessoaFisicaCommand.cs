using MediatR;

namespace ObraSocial.Application.Commands.DeletePessoaFisica
{
    public class DeletePessoaFisicaCommand : IRequest<Unit>
    {
        public DeletePessoaFisicaCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}