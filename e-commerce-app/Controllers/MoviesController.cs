using e_commerce_app.Data;
using e_commerce_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Movies.Include(n=> n.Cinema).ToListAsync();
            return View(data);
        }

        //public async Task<IActionResult> Create()
        //{
        //    return View();
        //}
        //[HttpPost]

        //public async Task<IActionResult> Create([Bind("Name,Description,Price,StartDate,EndDate,MovieCategory,ImageURL")]Movie movie)
        //{
        //    return View();
        //}
        
    }
}
