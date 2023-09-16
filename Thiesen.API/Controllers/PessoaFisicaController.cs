using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ObraSocial.Application.Commands.CreatePessoaFisica;
using ObraSocial.Application.Commands.DeletePessoaFisica;
using ObraSocial.Application.Commands.UpdatePessoaFisica;
using ObraSocial.Application.Queries.GetAllPessoasFisicas;
using ObraSocial.Application.Queries.GetPessoaFisicaById;
using ObraSocial.Application.Resources;

namespace ObraSocial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PessoaFisicaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreatePessoaFisicaCommand command)
        {
            if (command == null)
                throw new ArgumentNullException($"{ValidationMessages.InvalidParameter} - {nameof(command)}");

            var id = await _mediator.Send(command);

            if (id == -1)
                return BadRequest(ValidationMessages.ExistPessoaFisica);

            return Ok(id);            
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCommand = new DeletePessoaFisicaCommand(id);
            await _mediator.Send(deleteCommand);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var query = new GetAllPessoasFisicasQuery();
            var pessoasFisicasDto = await _mediator.Send(query);
            return Ok(pessoasFisicasDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var query = new GetPessoaFisicaByIdQuery(id);
            var pessoaFisicaDto = await _mediator.Send(query);

            if (pessoaFisicaDto == null)
                return NotFound();

            return Ok(pessoaFisicaDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdatePessoaFisicaCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
    }
}