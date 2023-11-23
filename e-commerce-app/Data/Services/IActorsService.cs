using e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Data.Services
{
    public interface IActorsService
    {
        public  Task<IEnumerable<Actor>> GetAll();
        public Actor GetById(int id);
        public void Add(Actor actor);
        public Actor Update(int id, Actor actor);
        public void Delete(int id);
    }

    public class ActorService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>>GetAll()
        {
            return  await _context.Actors.ToListAsync();
              
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
