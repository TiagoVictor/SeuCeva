﻿using System.ComponentModel.DataAnnotations;
using static SeuCevApi.Dto.DocumentoDto;
using static SeuCevApi.Dto.EnderecoDto;

namespace SeuCevApi.Dto
{
    public class ClienteDto
    {
        public class ClientCreationDto
        {
            [Required]
            public string Nome { get; set; }

            [Required]
            public string SobreNome { get; set; }

            [Required]
            public string Idade { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }

            [Required]
            public DateTime DtNascimento { get; set; }

            [Required]
            public DocumentCreationDto DocumentoDto { get; set; }

            [Required]
            public AddresCreationDto EnderecoDto { get; set; }
        }

        public class ClientUpdateDto
        {
            [Required]
            public string Nome { get; set; }

            [Required]
            public string SobreNome { get; set; }

            [Required]
            public string Idade { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }

            [Required]
            public DateTime DtNascimento { get; set; }

            [Required]
            public DocumentCreationDto DocumentoDto { get; set; }

            [Required]
            public AddresCreationDto EnderecoDto { get; set; }

            [Required]
            public bool Ativo { get; set; }
        }

        public class LoginDto
        {
            public string Login { get; set; }
            public string Password { get; set; }
        }
    }
}
