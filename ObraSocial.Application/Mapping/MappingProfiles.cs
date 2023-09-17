using AutoMapper;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PessoaFisica, PessoaFisicaDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Usuario, UsuarioRetornoDto>().ReverseMap();            
            CreateMap<Contato, ContatoDto>().ReverseMap();
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
        }
    }
}