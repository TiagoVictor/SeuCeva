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

        public async Task<IActionResult> Save(ProdutoDto dto)
        {
            await _produtoService.Save(dto);
            return NoContent();
        }

        public async Task<IActionResult> Delete(ProdutoDto dto)
        {
            await _produtoService.Delete(dto);
            return NoContent();
        }

        public async Task<IActionResult> Edit(ProdutoDto dto)
        {
            await _produtoService.Edit(dto);
            return NoContent();
        }

        public IQueryable<Produto> GetAll()
        {
            return _produtoService.GetAll();
        }

        public Produto GetById(int id)
        {
            return _produtoService.GetById(id);
        }
    }
}
