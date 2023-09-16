using AutoMapper;
using MediatR;
using ObraSocial.Application.Resources;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Application.Commands.UpdatePessoaFisica
{
    public class UpdatePessoaFisicaCommandHandler : IRequestHandler<UpdatePessoaFisicaCommand, Unit>
    {
        private readonly IUnitOfWork<PessoaFisica> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public UpdatePessoaFisicaCommandHandler(IUnitOfWork<PessoaFisica> unitOfWork, 
                                                IMapper mapper, 
                                                IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }

        public async Task<Unit> Handle(UpdatePessoaFisicaCommand request, CancellationToken cancellationToken)
        {
            var pessoaFisica = await _pessoaFisicaRepository.GetByIdAsync(request.Id);

            if (pessoaFisica == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundPessoaFisica);

            _mapper.Map(request, pessoaFisica);

            await _unitOfWork.BeginTransactionAsync();
            await _unitOfWork.UpdateAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();

            return Unit.Value;
        }
    }
}