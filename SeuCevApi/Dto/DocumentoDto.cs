using System.ComponentModel.DataAnnotations;

namespace SeuCevApi.Dto
{
    public class DocumentoDto
    {
        public class DocumentCreationDto
        {
            [Required]
            public string Tipo { get; set; }

            [Required]
            public string Numero { get; set; }

            [Required]
            public int IdCliente { get; set; }
        }

        public class DocumentUpdateDto
        {
            [Required]
            public string Tipo { get; set; }

            [Required]
            public string Numero { get; set; }

            [Required]
            public int IdCliente { get; set; }

            [Required]
            public bool Ativo { get; set; }
        }
    }
}
