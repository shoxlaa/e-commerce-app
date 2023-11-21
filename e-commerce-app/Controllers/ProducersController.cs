using e_commerce_app.Data;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_app.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
