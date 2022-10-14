using System.ComponentModel.DataAnnotations;

namespace SeuCevApi.Dto
{
    public class TipoPlanoDto
    {
        public class PlanTypeCreationDto
        {
            [Required]
            public string Descricao { get; set; }
        }

        public class PlanTypeUpdateDto
        {
            [Required]
            public string Descricao { get; set; }
            public bool Ativo { get; set; }
        }
    }
}
