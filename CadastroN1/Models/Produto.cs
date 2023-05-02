using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroN1.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        public int Disponibilidade { get; set; }
        [ForeignKey(nameof(IdCliente))]
        public int IdCliente { get; set; }

    }
}
