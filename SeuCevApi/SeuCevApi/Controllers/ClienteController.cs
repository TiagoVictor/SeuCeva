using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IActionResult> Save(ClienteDto dto)
        {
            await _clienteService.Save(dto);
            return NoContent();
        }

        public async Task<IActionResult> Edit(ClienteDto dto)
        {
            await _clienteService.Edit(dto);
            return NoContent();
        }

        public async Task<IActionResult> Delete(ClienteDto dto)
        {
            await _clienteService.Delete(dto);
            return NoContent();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _clienteService.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteService.GetById(id);
        }
    }
}
