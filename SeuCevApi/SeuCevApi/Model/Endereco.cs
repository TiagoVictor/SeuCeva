namespace SeuCevApi.Model
{
    public class Endereco : Base
    {
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
    }
}
