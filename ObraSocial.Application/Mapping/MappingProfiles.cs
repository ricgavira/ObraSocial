using AutoMapper;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<string, byte[]>()
                .ConvertUsing<Base64Converter>();

            CreateMap<byte[], string>()
                .ConvertUsing<Base64Converter>();

            CreateMap<PessoaFisica, PessoaFisicaDto>()
                .ForMember(dest => dest.Foto, opt => opt.MapFrom(src => Convert.ToBase64String(src.Foto)));

            CreateMap<PessoaFisicaDto, PessoaFisica>()
                .ForMember(dest => dest.Foto, opt => opt.MapFrom(src => Convert.FromBase64String(src.Foto)));

            CreateMap<PessoaFisica, PessoaFisicaSimpleDto>().ReverseMap();

            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Usuario, UsuarioRetornoDto>().ReverseMap();            
            CreateMap<Contato, ContatoDto>().ReverseMap();
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
        }

        private class Base64Converter : ITypeConverter<string, byte[]>, ITypeConverter<byte[], string>
        {
            public byte[] Convert(string source, byte[] destination, ResolutionContext context)
                => System.Convert.FromBase64String(source);

            public string Convert(byte[] source, string destination, ResolutionContext context)
                => System.Convert.ToBase64String(source);
        }
    }
}