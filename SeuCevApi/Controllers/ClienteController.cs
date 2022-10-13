using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.ClienteDto;

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

        [HttpPost("SalvaCliente")]
        public async Task<IActionResult> Save(ClientCreationDto dto)
        {
            await _clienteService.Save(dto);
            return NoContent();
        }

        [HttpPost("EditaCliente")]
        public async Task<IActionResult> Edit(ClientCreationDto dto)
        {
            await _clienteService.Edit(dto);
            return NoContent();
        }

        [HttpPost("ExcluiCliente")]
        public async Task<IActionResult> Delete(ClientCreationDto dto)
        {
            await _clienteService.Delete(dto);
            return NoContent();
        }

        [HttpGet("RecuperaClientes")]
        public IEnumerable<Cliente> RecuperaTodos()
        {
            return _clienteService.GetAll();
        }

        [HttpGet("RecuperaClientePorId")]
        public Cliente RecuperaPorId(int id)
        {
            return _clienteService.GetById(id);
        }
    }
}
