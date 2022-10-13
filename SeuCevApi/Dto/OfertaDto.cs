using System.ComponentModel.DataAnnotations;

namespace SeuCevApi.Dto
{
    public class OfertaDto
    {
        public class OfferCreationDto
        {
            [Required]
            public string Titulo { get; set; }

            [Required]
            public string Descricao { get; set; }

            [Required]
            public int Quantidade { get; set; }

            [Required]
            public int Alcance { get; set; }
        }

        public class OfferUpdateDto
        {
            [Required]
            public string Titulo { get; set; }

            [Required]
            public string Descricao { get; set; }

            [Required]
            public int Quantidade { get; set; }

            [Required]
            public int Alcance { get; set; }

            [Required]
            public bool Ativo { get; set; }
        }
    }
}
