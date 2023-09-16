using AutoMapper;
using MediatR;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Helpers;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Application.Commands.CreatePessoaFisica
{
    public class CreatePessoaFisicaCommandHandler : IRequestHandler<CreatePessoaFisicaCommand, int>
    {
        private readonly IUnitOfWork<PessoaFisica> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public CreatePessoaFisicaCommandHandler(IUnitOfWork<PessoaFisica> unitOfWork, 
                                                IMapper mapper, 
                                                IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }

        public async Task<int> Handle(CreatePessoaFisicaCommand request, CancellationToken cancellationToken)
        {
            var pessoaFisicaExiste = await _pessoaFisicaRepository.GetByCPFAsync(StringHelper.OnlyNumber(request?.CPF ?? ""));

            if (!pessoaFisicaExiste.Any())
                return -1;

            var pessoaFisica = _mapper.Map<PessoaFisica>(request);

            await _unitOfWork.BeginTransactionAsync();
            var retorno = await _unitOfWork.AddAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();

            return retorno.Id;
        }
    }
}