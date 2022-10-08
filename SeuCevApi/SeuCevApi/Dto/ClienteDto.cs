namespace SeuCevApi.Dto
{
    public class ClienteDto : BaseDto
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public DocumentoDto DocumentoDto { get; set; }
        public EnderecoDto EnderecoDto { get; set; }
    }
}
