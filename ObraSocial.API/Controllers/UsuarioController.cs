using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Application.Resources;
using ObraSocial.Application.Service.Cadastro.Interface;

namespace ObraSocial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateAsync([FromBody] UsuarioDto usuarioDto)
        {
            if (usuarioDto == null)
                throw new ArgumentNullException($"{ValidationMessages.InvalidParameter} - {nameof(usuarioDto)}");

            var retorno = await _usuarioService.AddAsync(usuarioDto);

            if (retorno == null)
                return BadRequest(ValidationMessages.ExistUsuario);

            return Ok(retorno);
        }

        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {            
            var usuariosDto = await _usuarioService.GetAllAsync();
            return Ok(usuariosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var usuarioDto = await _usuarioService.GetByIdAsync(id);

            if (usuarioDto == null)
                return NotFound(ValidationMessages.NotFoundUsuario);

            return Ok(usuarioDto);
        }

        [HttpPut]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateAsync([FromBody] UsuarioDto usuarioDto)
        {
            await _usuarioService.UpdateAsync(usuarioDto);
            return NoContent();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            var retorno = _usuarioService.LoginUser(loginDto);

            if (retorno == null)
                return BadRequest(ValidationMessages.InvalidLogin);

            return Ok(retorno);
        }
    }
}