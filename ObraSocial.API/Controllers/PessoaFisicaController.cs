using Microsoft.AspNetCore.Mvc;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Application.Resources;
using ObraSocial.Application.Service.Cadastro.Interface;

namespace ObraSocial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;
        public PessoaFisicaController(IPessoaFisicaService pessoaFisicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] PessoaFisicaDto pessoaFisicaDto)
        {
            if (pessoaFisicaDto == null)
                throw new ArgumentNullException($"{ValidationMessages.InvalidParameter} - {nameof(pessoaFisicaDto)}");

            var retorno = await _pessoaFisicaService.CreateAsync(pessoaFisicaDto);

            if (retorno == null)
                return BadRequest(ValidationMessages.ExistPessoaFisica);

            return Ok(retorno);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _pessoaFisicaService.DeleteAsync(id);

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var pessoasFisicasDto = await _pessoaFisicaService.GetAllAsync();
            return Ok(pessoasFisicasDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var pessoaFisicaDto = await _pessoaFisicaService.GetByIdAsync(id);

            if (pessoaFisicaDto == null)
                return NotFound(ValidationMessages.NotFoundPessoaFisica);

            return Ok(pessoaFisicaDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] PessoaFisicaDto pessoaFisicaDto)
        {
            await _pessoaFisicaService.UpdateAsync(pessoaFisicaDto);

            return NoContent();
        }
    }
}