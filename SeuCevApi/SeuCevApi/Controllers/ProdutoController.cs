using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost("SalvaProduto")]
        public async Task<IActionResult> Save(ProdutoDto dto)
        {
            await _produtoService.Save(dto);
            return NoContent();
        }

        [HttpPost("DeletaProduto")]
        public async Task<IActionResult> Delete(ProdutoDto dto)
        {
            await _produtoService.Delete(dto);
            return NoContent();
        }

        [HttpPost("EditaProduto")]
        public async Task<IActionResult> Edit(ProdutoDto dto)
        {
            await _produtoService.Edit(dto);
            return NoContent();
        }

        [HttpGet("RecuperaTodosProdutos")]
        public IEnumerable<Produto> RecuperaTodos()
        {
            return _produtoService.GetAll();
        }

        [HttpGet("RecuperaProdutosPorId")]
        public Produto RecuperaPorId(int id)
        {
            return _produtoService.GetById(id);
        }
    }
}
