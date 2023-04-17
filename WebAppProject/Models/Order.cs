using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderItem { get; set; }

    }
}
