using MediatR;
using ObraSocial.Application.Resources;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Application.Commands.DeletePessoaFisica
{
    public class DeletePessoaFisicaCommandHandler : IRequestHandler<DeletePessoaFisicaCommand, Unit>
    {
        private readonly IUnitOfWork<PessoaFisica> _unitOfWork;
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public DeletePessoaFisicaCommandHandler(IUnitOfWork<PessoaFisica> unitOfWork, 
                                                IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _unitOfWork = unitOfWork;
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }

        public async Task<Unit> Handle(DeletePessoaFisicaCommand request, CancellationToken cancellationToken)
        {
            var pessoaFisica = await _pessoaFisicaRepository.GetByIdAsync(request.Id);

            if (pessoaFisica == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundPessoaFisica);

            await _unitOfWork.DeleteAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();

            return Unit.Value;
        }
    }
}