namespace SeuCevApi.Model
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
