using e_commerce_app.Data;
using e_commerce_app.Data.Services;
using e_commerce_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _context;
        public MoviesController(IMoviesService context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.GetAllAsync(n=> n.Cinema);
            return View(data);
        }

        public async Task <IActionResult> Details(int id)
        {
            var data = await _context.GetMovieByIdAsync(id);    
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
