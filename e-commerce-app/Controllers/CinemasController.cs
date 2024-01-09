using e_commerce_app.Data;
using e_commerce_app.Data.Services;
using e_commerce_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _context;
        public CinemasController(ICinemaService context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.GetAllAsync();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await  _context.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        public async  Task<IActionResult> Edit (int id)
        {
          var editCinema =  await _context.GetByIdAsync(id); 

            if(editCinema == null) 
            {
                return View("NotFound");
            }
            return View (editCinema);
        }

        public async Task<IActionResult> Edit(int id, [Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }
            await _context.UpdateAsync(id,cinema);
            return RedirectToAction(nameof(Index));

        }

        
    }
}
