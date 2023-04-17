using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; } 

        //Relationships
        public Order Order { get; set; }
    }
}
