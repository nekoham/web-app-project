using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAppProject.Data;

namespace WebAppProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public OrderController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.Orders.ToList();
            return View(data);
        }
    }
}
