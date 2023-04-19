using Microsoft.EntityFrameworkCore;
using WebAppProject.Models;

namespace BasicASPTutorial.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}