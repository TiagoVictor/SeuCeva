using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using System.Collections.Generic;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPlanoController : ControllerBase
    {
        private readonly ITipoPlanoService _tipoPlanoService;

        public TipoPlanoController(ITipoPlanoService tipoPlanoService)
        {
            _tipoPlanoService = tipoPlanoService;
        }

        [HttpPost("SalvaTipoPlano")]
        public async Task<IActionResult> Save(TipoPlanoDto dto)
        {
            await _tipoPlanoService.Save(dto);
            return NoContent();
        }

        [HttpPost("EditaTipoPlano")]
        public async Task<IActionResult> Edit(TipoPlanoDto dto)
        {
            await _tipoPlanoService.Edit(dto);
            return NoContent();
        }

        [HttpPost("DeletaTipoPlano")]
        public async Task<IActionResult> Delete(TipoPlanoDto dto)
        {
            await _tipoPlanoService.Delete(dto);
            return NoContent();
        }

        [HttpGet("RecuperaTodosTipoPlano")]
        public IEnumerable<TipoPlano> RecuperaTodos()
        {
            return _tipoPlanoService.GetAll();
        }

        [HttpGet("RecuperaTipoPlanoPorId")]
        public TipoPlano RecuperaPorId(int id)
        {
            return _tipoPlanoService.GetById(id);
        }
    }
}
