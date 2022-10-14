using System.ComponentModel.DataAnnotations;

namespace SeuCevApi.Dto
{
    public class ProdutoDto
    {
        public class ProductCreationDto
        {
            [Required]
            public string Nome { get; set; }

            [Required]
            public string Descricao { get; set; }
        }

        public class ProductUpdateDto
        {
            [Required]
            public string Nome { get; set; }

            [Required]
            public string Descricao { get; set; }

            [Required]
            public bool Ativo { get; set; }
        }
    }
}
