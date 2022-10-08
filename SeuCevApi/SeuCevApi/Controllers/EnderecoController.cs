using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost("SalvaEndereco")]
        public async Task<IActionResult> Save(EnderecoDto dto)
        {
            return NoContent();
        }

        [HttpPost("EditaEndereco")]
        public async Task<IActionResult> Edit(EnderecoDto dto)
        {
            return NoContent();
        }

        [HttpPost("DeletaEndereco")]
        public async Task<IActionResult> Delete(EnderecoDto dto)
        {
            return NoContent();
        }

        [HttpGet("RecuperaTodosEnderecos")]
        public IEnumerable<Endereco> RecuperaTodos()
        {
            return _enderecoService.GetAll();
        }

        [HttpGet("RecuperaEnderecoPorId")]
        public Endereco RecuperaPorId(int id)
        {
            return _enderecoService.GetById(id);
        }
    }
}
