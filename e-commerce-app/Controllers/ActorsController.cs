using e_commerce_app.Data;
using e_commerce_app.Data.Services;
using e_commerce_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_app.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService context)
        {
            _service = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get:Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var acrtorDetails = await _service.GetByIdAsync(id);

            if (acrtorDetails == null)
            {
                return View("Not Found");
            }
            return View(acrtorDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var acrtorDetails = await _service.GetByIdAsync(id);

            if (acrtorDetails == null)
            {
                return View("Not Found");
            }
            return View(acrtorDetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }


    }
}
