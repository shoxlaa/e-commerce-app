using e_commerce_app.Data.Base;
using e_commerce_app.Models;

namespace e_commerce_app.Data.Services
{
    public class ProducerService :EntityBaseRepository<Producer>,IProducersService 
    {
        private readonly AppDbContext _context;

        public ProducerService(AppDbContext context): base(context) { }
    }
}
