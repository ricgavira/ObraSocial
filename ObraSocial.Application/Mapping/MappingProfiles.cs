using AutoMapper;
using ObraSocial.Application.Commands.CreatePessoaFisica;
using ObraSocial.Application.Commands.CreateUsuario;
using ObraSocial.Application.Commands.UpdatePessoaFisica;
using ObraSocial.Application.Commands.UpdateUsuario;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PessoaFisica, CreatePessoaFisicaCommand>();
            CreateMap<CreatePessoaFisicaCommand, PessoaFisica>();
            CreateMap<PessoaFisica, UpdatePessoaFisicaCommand>();
            CreateMap<PessoaFisica, PessoaFisicaDto>();
            CreateMap<Usuario, CreateUsuarioCommand>();
            CreateMap<Usuario, UpdateUsuarioCommand>();
            CreateMap<CreateUsuarioCommand, Usuario>();
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<Contato, ContatoDto>();
            CreateMap<Endereco, EnderecoDto>();
        }
    }
}