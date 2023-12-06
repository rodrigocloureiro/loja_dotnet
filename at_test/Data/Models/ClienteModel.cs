using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace at_test.Data.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, insira o seu nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por favor, insira o seu CPF")]
        //[MinLength(11, ErrorMessage = "O CPF deve ter pelo menos 11 caracteres"), MaxLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres")]
        [MaxLength(11, ErrorMessage = "O CPF deve ter no máximo 11 caracteres")]
        //[RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "O CPF deve seguir o formato 000.000.000-00")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Por favor, informe o CPF com os 11 dígitos e sem pontuação")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Por favor, insira a sua data de nascimento")]
        public DateTime DataNascimento { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
    }
}
