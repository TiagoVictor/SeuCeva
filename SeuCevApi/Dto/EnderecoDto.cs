using System.ComponentModel.DataAnnotations;

namespace SeuCevApi.Dto
{
    public class EnderecoDto
    {
        public class AddresCreationDto
        {
            [Required]
            public string Pais { get; set; }

            [Required]
            public string UF { get; set; }

            [Required]
            public string Cidade { get; set; }

            [Required]
            public string Rua { get; set; }

            [Required]
            public string Bairro { get; set; }

            [Required]
            public string CEP { get; set; }
        }
    }
}
