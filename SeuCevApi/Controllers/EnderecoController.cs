﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Dto;
using SeuCevApi.Model;
using SeuCevApi.Service.Interface;
using static SeuCevApi.Dto.EnderecoDto;

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
        public async Task<IActionResult> Save(AddresCreationDto dto)
        {
            await _enderecoService.Save(dto);
            return NoContent();
        }

        [HttpPost("EditaEndereco")]
        public async Task<IActionResult> Edit(AddresCreationDto dto)
        {
            await _enderecoService.Edit(dto);
            return NoContent();
        }

        [HttpPost("DeletaEndereco")]
        public async Task<IActionResult> Delete(AddresCreationDto dto)
        {
            await _enderecoService.Delete(dto);
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
