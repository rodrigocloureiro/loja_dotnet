using System.ComponentModel.DataAnnotations;

namespace at_test.Data.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [MinLength(11, ErrorMessage = "O CPF deve ter pelo menos 11 caracteres"), MaxLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres")]
        public string Cpf { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
    }
}
