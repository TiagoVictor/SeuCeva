namespace SeuCevApi.Dto
{
    public class OfertaDto : BaseDto
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int Alcance { get; set; }
    }
}
