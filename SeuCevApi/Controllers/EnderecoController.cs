using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.EnderecoDto;

namespace SeuCevApi.Controllers
{
    [Route("v1")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost("Addres")]
        public async Task<IActionResult> PostAsync(
            [FromBody] AddresCreationDto dto,
            [FromServices] IEnderecoService _enderecoService)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _enderecoService.SaveAsync(dto);
            return Created($"v1/addres/{dto.Rua}", dto);
        }

        [HttpPut("Addres/{id}")]
        public async Task<IActionResult> EditAsync(
            [FromBody] AddresUpdateDto dto,
            [FromServices] IEnderecoService _enderecoService,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            await _enderecoService.EditAsync(dto, id);
            return NoContent();
        }

        [HttpDelete("Addres/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] IEnderecoService _enderecoService)
        {
            if (id == 0)
                return BadRequest();

            await _enderecoService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("Addres")]
        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoService.GetAll();
        }

        [HttpGet("Addres/{id}")]
        public Endereco GetById(int id)
        {
            return _enderecoService.GetById(id);
        }
    }
}
