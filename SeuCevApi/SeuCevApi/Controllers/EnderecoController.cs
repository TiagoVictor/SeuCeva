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

        public async Task<IActionResult> Save(EnderecoDto dto)
        {
            return NoContent();
        }

        public async Task<IActionResult> Edit(EnderecoDto dto)
        {
            return NoContent();
        }

        public async Task<IActionResult> Delete(EnderecoDto dto)
        {
            return NoContent();
        }

        public IQueryable<Endereco> GetAll()
        {
            return _enderecoService.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _enderecoService.GetById(id);
        }
    }
}
