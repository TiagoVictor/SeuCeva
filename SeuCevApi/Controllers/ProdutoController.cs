using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.ProdutoDto;

namespace SeuCevApi.Controllers
{
    [Route("v1")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost("Product")]
        public async Task<IActionResult> PostAsync(
            [FromBody] ProductCreationDto dto,
            [FromServices] IProdutoService _produtoService)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _produtoService.SaveAsync(dto);
            return Created($"v1/Product/{dto.Nome}", dto);
        }

        [HttpPut("Product/{id}")]
        public async Task<IActionResult> EditAsync(
            [FromServices] IProdutoService _produtoService,
            [FromBody] ProductUpdateDto dto,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            await _produtoService.EditAsync(dto, id);
            return Ok();
        }

        [HttpDelete("Product/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] IProdutoService _produtoService)
        {
            if (id == 0)
                return BadRequest();

            await _produtoService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("Products")]
        public IEnumerable<Produto> GetAll()
        {
            return _produtoService.GetAll();
        }

        [HttpGet("Product/{id}")]
        public Produto GetById(int id)
        {
            return _produtoService.GetById(id);
        }
    }
}
