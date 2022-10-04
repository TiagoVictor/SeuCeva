﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;

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

        public async Task<IActionResult> Save(DocumentoDto dto)
        {
            await _documentoService.Save(dto);
            return NoContent();
        }

        public async Task<IActionResult> Edit(DocumentoDto dto)
        {
            await _documentoService.Edit(dto);
            return NoContent();
        }

        public async Task<IActionResult> Delete(DocumentoDto dto)
        {
            await _documentoService.Delete(dto);
            return NoContent();
        }

        public IQueryable<Documento> GetAll()
        {
            return _documentoService.GetAll();
        }

        public Documento GetById(int id)
        {
            return _documentoService.GetById(id);
        }
    }
}
