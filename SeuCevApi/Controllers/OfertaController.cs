using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        private readonly IOfertaService _ofertaService;

        public OfertaController(IOfertaService ofertaService)
        {
            _ofertaService = ofertaService;
        }

        [HttpPost("SalvaOferta")]
        public async Task<IActionResult> Save(OfertaDto dto)
        {
            await _ofertaService.Save(dto);
            return NoContent();
        }

        [HttpPost("EditaOferta")]
        public async Task<IActionResult> Edit(OfertaDto dto)
        {
            await _ofertaService.Edit(dto);
            return NoContent();
        }

        [HttpPost("DeletaOferta")]
        public async Task<IActionResult> Delete(OfertaDto dto)
        {
            await _ofertaService.Delete(dto);
            return NoContent();
        }

        [HttpGet("RecuperaTodasOfertas")]
        public IEnumerable<Oferta> RecuperaTodos()
        {
            return _ofertaService.GetAll();
        }

        [HttpGet("RecuperaOfertaPorId")]
        public Oferta RecuperaPorId(int id)
        {
            return _ofertaService.GetById(id);
        }
    }
}
