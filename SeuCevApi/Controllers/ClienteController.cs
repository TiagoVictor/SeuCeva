using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.ClienteDto;

namespace SeuCevApi.Controllers
{
    [Route("v1")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost("Client")]
        public async Task<IActionResult> PostAsync(
            [FromBody] ClientCreationDto dto,
            [FromServices] IClienteService _clienteService)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _clienteService.SaveAsync(dto);
            return Created($"v1/client/{dto.Nome}", dto);
        }

        [HttpPut("Client/{id}")]
        public async Task<IActionResult> EditAsync(
            [FromBody] ClientUpdateDto dto,
            [FromRoute] int id,
            [FromServices] IClienteService _clienteService)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            await _clienteService.EditAsync(dto, id);
            return NoContent();
        }

        [HttpDelete("Client/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] IClienteService _clienteService)
        {
            await _clienteService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("Clients")]
        public IEnumerable<Cliente> GetAll()
        {
            return _clienteService.GetAll();
        }

        [HttpGet("Client/{id}")]
        public Cliente GetById(int id)
        {
            return _clienteService.GetById(id);
        }
    }
}
