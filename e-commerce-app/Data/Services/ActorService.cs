using e_commerce_app.Data.Base;
using e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>,IActorsService
    {
        public ActorService(AppDbContext context): base(context) 
        {
        }
    }
}
