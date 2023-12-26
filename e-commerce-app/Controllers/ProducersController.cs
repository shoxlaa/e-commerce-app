using e_commerce_app.Data;
using e_commerce_app.Data.Services;
using e_commerce_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data =  await _service.GetAllAsync();
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }
        public async Task<IActionResult> Create ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
