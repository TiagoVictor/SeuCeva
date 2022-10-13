using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.DocumentoDto;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentoController : ControllerBase
    {
        private readonly IDocumentoService _documentoService;

        public DocumentoController(IDocumentoService documentoService)
        {
            _documentoService = documentoService;
        }

        [HttpPost("SalvaDocumento")]
        public async Task<IActionResult> Save(DocumentCreationDto dto)
        {
            await _documentoService.Save(dto);
            return NoContent();
        }

        [HttpPost("EditaDocumento")]
        public async Task<IActionResult> Edit(DocumentCreationDto dto)
        {
            await _documentoService.Edit(dto);
            return NoContent();
        }

        [HttpPost("ExcluiDocumento")]
        public async Task<IActionResult> Delete(DocumentCreationDto dto)
        {
            await _documentoService.Delete(dto);
            return NoContent();
        }

        [HttpGet("RecuperaTodosDocumentos")]
        public IEnumerable<Documento> RecuperaTodos()
        {
            return _documentoService.GetAll();
        }


        [HttpGet("RecuperaDocumentoPorId")]
        public Documento RecuperaPorId(int id)
        {
            return _documentoService.GetById(id);
        }
    }
}
