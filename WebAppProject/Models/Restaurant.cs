using System.ComponentModel.DataAnnotations;
using WebAppProject.Data.Enums;

namespace WebAppProject.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; } 
        public RestaurantList RestaurantList { get; set; }

        //Relationships
        public Order Order { get; set; }
    }
}
