namespace SeuCevApi.Dto
{
    public class EnderecoDto : BaseDto
    {
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
    }
}
