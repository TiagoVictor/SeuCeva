namespace SeuCevApi.Model
{
    public class Cliente : Base
    {
        public Cliente()
        {
            Documentos = new HashSet<Documento>();
            Enderecos = new HashSet<Endereco>();
        }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
