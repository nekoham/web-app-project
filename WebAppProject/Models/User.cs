using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set;}
        public string Password { get; set;}
        public string Email { get; set;}
        public int Rating { get; set;}
    }
}
