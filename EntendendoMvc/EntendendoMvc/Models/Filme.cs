using System.ComponentModel.DataAnnotations;

namespace EntendendoMvc.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public decimal Valor { get; set; }
    }
}
