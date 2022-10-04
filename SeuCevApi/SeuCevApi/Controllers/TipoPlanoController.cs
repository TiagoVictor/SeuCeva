using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

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

        public async Task<IActionResult> Save(TipoPlanoDto dto)
        {
            await _tipoPlanoService.Save(dto);
            return NoContent();
        }

        public async Task<IActionResult> Edit(TipoPlanoDto dto)
        {
            await _tipoPlanoService.Edit(dto);
            return NoContent();
        }

        public async Task<IActionResult> Delete(TipoPlanoDto dto)
        {
            await _tipoPlanoService.Delete(dto);
            return NoContent();
        }

        public IQueryable<TipoPlano> GetAll()
        {
            return _tipoPlanoService.GetAll();
        }

        public TipoPlano GetById(int id)
        {
            return _tipoPlanoService.GetById(id);
        }
    }
}
