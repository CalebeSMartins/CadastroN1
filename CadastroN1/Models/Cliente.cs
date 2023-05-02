using System.ComponentModel.DataAnnotations;

namespace CadastroN1.Models
{
    public class Cliente
    {
        [Key]
        public int IdClient { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Datacadastro { get; set; }
    }
}
