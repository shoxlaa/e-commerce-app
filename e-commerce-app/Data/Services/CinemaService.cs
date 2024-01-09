using e_commerce_app.Data.Base;
using e_commerce_app.Models;

namespace e_commerce_app.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        private readonly AppDbContext _context;

        public CinemaService(AppDbContext context) : base(context)
        {
        }
    }
}
