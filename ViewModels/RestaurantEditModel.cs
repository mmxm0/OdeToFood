using OdeToFood.Models;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(120)]
        public string Nome { get; set; }
        public CousineType Culinaria { get; set; }
    }
    
}
