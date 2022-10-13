using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.OfertaDto;

namespace SeuCevApi.Controllers
{
    [Route("v1")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        private readonly IOfertaService _ofertaService;

        public OfertaController(IOfertaService ofertaService)
        {
            _ofertaService = ofertaService;
        }

        [HttpPost("Offer")]
        public async Task<IActionResult> PostAsync([FromBody] OfferCreationDto dto,
            [FromServices] IOfertaService _ofertaService)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _ofertaService.Save(dto);
            return Created($"v1/offer/{dto.Titulo}", dto);
        }

        [HttpPut("Offer/{id}")]
        public async Task<IActionResult> Edit([FromBody] OfferUpdateDto dto,
            [FromRoute] int id,
            [FromServices] IOfertaService _ofertaService)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            await _ofertaService.Edit(dto, id);
            return Ok();
        }

        [HttpDelete("Offer/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id,
            [FromServices] IOfertaService _ofertaService)
        {
            if (id == 0)
                return BadRequest();

            await _ofertaService.Delete(id);
            return Ok();
        }

        [HttpGet("Offers")]
        public IEnumerable<Oferta> GetAll()
        {
            return _ofertaService.GetAll();
        }

        [HttpGet("Offer/{id}")]
        public Oferta GetById(int id)
        {
            return _ofertaService.GetById(id);
        }
    }
}
