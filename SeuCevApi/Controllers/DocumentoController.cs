using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.DocumentoDto;

namespace SeuCevApi.Controllers
{
    [Route("v1")]
    [ApiController]
    public class DocumentoController : ControllerBase
    {
        private readonly IDocumentoService _documentoService;

        public DocumentoController(IDocumentoService documentoService)
        {
            _documentoService = documentoService;
        }

        [HttpPost("Document")]
        public async Task<IActionResult> PostAsync(
            [FromBody] DocumentCreationDto dto,
            [FromServices] IDocumentoService _documentoService)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _documentoService.SaveAsync(dto);
            return Created($"v1/document/{dto.Tipo}", dto);
        }

        [HttpPut("Document/{id}")]
        public async Task<IActionResult> EditAsync(
           [FromBody] DocumentUpdateDto dto,
           [FromRoute] int id,
           [FromServices] IDocumentoService _documentoService)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            await _documentoService.EditAsync(dto, id);
            return Ok();
        }

        [HttpDelete("Document/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromServices] IDocumentoService _documentoService)
        {
            if (id == 0)
                return BadRequest();

            await _documentoService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("Documents")]
        public IEnumerable<Documento> GetAll()
        {
            return _documentoService.GetAll();
        }


        [HttpGet("Document/{id}")]
        public Documento GetById(int id)
        {
            return _documentoService.GetById(id);
        }
    }
}
