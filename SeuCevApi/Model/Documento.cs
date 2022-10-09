using System.ComponentModel.DataAnnotations.Schema;

namespace SeuCevApi.Model
{
    public class Documento : Base
    {
        public string Tipo { get; set; }
        public string Numero { get; set; }

        [ForeignKey(nameof(Cliente))]
        public long IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
