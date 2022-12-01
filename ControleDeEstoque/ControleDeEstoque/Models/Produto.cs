using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoque.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a descrição do produto")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Informe a quantidade do produto")]
        [Min(0, ErrorMessage = "O valor deve ser maior ou igual a 0")]
        public int Quantidade { get; set; }
    }
}
