using Microsoft.AspNetCore.Mvc;

namespace e_commerce_app.Controllers
{
    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
