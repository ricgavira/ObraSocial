using AutoMapper;
using MediatR;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Domain.Repositories;

namespace ObraSocial.Application.Queries.GetPessoaFisicaById
{
    public class GetPessoaFisicaByIdQueryHandler : IRequestHandler<GetPessoaFisicaByIdQuery, PessoaFisicaDto>
    {
        private readonly IPessoaFisicaRepository _repository;
        private readonly IMapper _mapper;

        public GetPessoaFisicaByIdQueryHandler(IPessoaFisicaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PessoaFisicaDto> Handle(GetPessoaFisicaByIdQuery request, CancellationToken cancellationToken)
        {
            var pessoaFisica = await _repository.GetByIdAsync(request.Id);

            return _mapper.Map<PessoaFisicaDto>(pessoaFisica);
        }
    }
}