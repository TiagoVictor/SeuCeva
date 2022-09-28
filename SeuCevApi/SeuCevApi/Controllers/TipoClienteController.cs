using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoClienteController : ControllerBase
    {
        private readonly ITipoClienteService _service;

        public TipoClienteController(ITipoClienteService tipoClienteService)
        {
            _service = tipoClienteService;
        }

        public async Task<IActionResult> Save(TipoClienteDto dto)
        {
            await _service.Save(dto);
            return NoContent();
        }

        public async Task<IActionResult> Delete(TipoClienteDto dto)
        {
            await _service.Delete(dto);
            return NoContent();
        }

        public async Task<IActionResult> Edit(TipoClienteDto dto)
        {
            await _service.Edit(dto);
            return NoContent();
        }

        public IQueryable<TipoCliente> GetAll()
        {
            return _service.GetAll();
        }

        public TipoCliente GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
