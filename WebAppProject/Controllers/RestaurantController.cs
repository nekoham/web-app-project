using Microsoft.AspNetCore.Mvc;
using WebAppProject.Data;

namespace WebAppProject.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public RestaurantController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.Restaurants.ToList();
            return View(data);
        }
    }
}
