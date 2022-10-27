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
        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$",ErrorMessage = "Somente números de 1 a 5" )]
        public int Avaliacao { get; set; }
    }
}
