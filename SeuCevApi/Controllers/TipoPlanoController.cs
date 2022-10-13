using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.TipoPlanoDto;

namespace SeuCevApi.Controllers
{
    [Route("v1")]
    [ApiController]
    public class TipoPlanoController : ControllerBase
    {
        private readonly ITipoPlanoService _tipoPlanoService;

        public TipoPlanoController(ITipoPlanoService tipoPlanoService)
        {
            _tipoPlanoService = tipoPlanoService;
        }

        [HttpPost("PlanType")]
        public async Task<IActionResult> PostAsync(
            [FromBody] PlanTypeCreationDto dto,
            [FromServices] ITipoPlanoService _tipoPlanoService)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _tipoPlanoService.Save(dto);
            return Created($"v1/PlanType/{dto.Descricao}", dto);
        }

        [HttpPut("PlanType/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromBody] PlanTypeUpdateDto dto,
            [FromServices] ITipoPlanoService _tipoPlanoService,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            await _tipoPlanoService.Edit(dto, id);
            return Ok();
        }

        [HttpDelete("PlanType/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] ITipoPlanoService _tipoPlanoService)
        {
            if (id == 0)
                return BadRequest();

            await _tipoPlanoService.Delete(id);
            return NoContent();
        }

        [HttpGet("PlanType")]
        public IEnumerable<TipoPlano> GetAll()
        {
            return _tipoPlanoService.GetAll();
        }

        [HttpGet("PlanType/{id}")]
        public TipoPlano GetById(int id)
        {
            return _tipoPlanoService.GetById(id);
        }
    }
}
