using System.ComponentModel.DataAnnotations;

namespace ApiPiagetDois.Models
{
    public class Escola : Base 
    {
  

        [Required(ErrorMessage = "Informe o nome")]
        public string? Nome { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Formato Email Invalido")]
        public string? Telefone { get; set; }
        public string? Email { get; set; }

    }
}