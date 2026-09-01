using Microsoft.OpenApi.MicrosoftExtensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ApiPiagetDois.Models
{
    /// <sumary>
    /// Classe aluno
    /// </sumary>
    public class Professor : Base
    {
        
        [Required (ErrorMessage ="Nome deve ser informado")]
        public string? ProfessorNome { get; set; }
        [Required ]
        public string? ProfessorTelefone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Formato Email Invalido")]
        public string? ProfessorEmail { get; set; }
        [Required]
        public string? ProfessorDisciplina { get; set; }

    }
}
