using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PJJulioCesarOrso.Models
{
    public class Psicologo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento.")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Informe a especialidade.")]
        [Display(Name = "Especialidade")]
        public string? Specialty { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}