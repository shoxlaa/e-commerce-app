using e_commerce_app.Data.Base;
using e_commerce_app.Models;

namespace e_commerce_app.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        public Task<Movie> GetMovieByIdAsync(int id);
    }
}
