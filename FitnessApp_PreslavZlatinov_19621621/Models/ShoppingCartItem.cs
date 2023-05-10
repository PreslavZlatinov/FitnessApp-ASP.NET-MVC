using System.ComponentModel.DataAnnotations;

namespace FitnessApp_PreslavZlatinov_19621621.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Workout Workout { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
