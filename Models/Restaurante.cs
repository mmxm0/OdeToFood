using System.ComponentModel.DataAnnotations;
namespace OdeToFood.Models
{
    public class Restaurante
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Restaurante")]
        [Required, MaxLength(120)]
        public string Nome { get; set; }
        public CousineType Culinaria { get; set; }

    }
}
