using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace at_test.Data.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "O nome deve ter pelo menos 2 caracteres")]
        public string Nome { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "A descrição deve ter pelo menos 5 caracteres")]
        public string Descricao { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O preço deve ser um valor positivo")]
        public decimal Preco { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade deve ser um valor positivo")]
        public int Quantidade { get; set; }
        [Required]
        public DateTime DataRegistro { get; set; }
        public string? NomeImagem { get; set; }
        [NotMapped]
        public IFormFile? Upload { get; set; }
    }
}
