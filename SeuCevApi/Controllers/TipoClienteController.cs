using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.TipoClienteDto;

namespace SeuCevApi.Controllers
{
    [Route("v1")]
    [ApiController]
    public class TipoClienteController : ControllerBase
    {
        private readonly ITipoClienteService _service;

        public TipoClienteController(ITipoClienteService tipoClienteService)
        {
            _service = tipoClienteService;
        }

        [HttpPost("ClientType")]
        public async Task<IActionResult> PostAsync(
            [FromBody] ClientTypeCreationDto dto,
            [FromServices] ITipoClienteService _service)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _service.Save(dto);
            return Created($"v1/ClientType/{dto.Descricao}", dto);
        }

        [HttpPut("ClientType/{id}")]
        public async Task<IActionResult> EditAsync(
            [FromBody] ClientTypeUpdate dto,
            [FromServices] ITipoClienteService _service,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            await _service.Edit(dto, id);
            return Ok();
        }

        [HttpDelete("ClientType/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] ITipoClienteService _service)
        {
            if (id == 0)
                return BadRequest();

            await _service.Delete(id);
            return NoContent();
        }

        [HttpGet("ClientTypes")]
        public IEnumerable<TipoCliente> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("ClientTypes/{id}")]
        public TipoCliente GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}