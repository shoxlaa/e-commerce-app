using e_commerce_app.Data.Base;
using e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actor_Movies)
                .ThenInclude(a=> a.Actor)
                .FirstOrDefaultAsync( n=> n.Id== id);
            return await movieDetails; 
        }
    }
}
