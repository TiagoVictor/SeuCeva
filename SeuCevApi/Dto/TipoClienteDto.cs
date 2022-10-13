using System.ComponentModel.DataAnnotations;

namespace SeuCevApi.Dto
{
    public class TipoClienteDto
    {
        public class ClientTypeCreationDto
        {
            [Required]
            public string Descricao { get; set; }
        }

        public class ClientTypeUpdate
        {
            [Required]
            public string Descricao { get; set; }

            [Required]
            public bool Ativo { get; set; }
        }
    }
}
