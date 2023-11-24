using e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Data.Services
{
    public interface IActorsService
    {
        public  Task<IEnumerable<Actor>> GetAllAsync();
        public Task<Actor> GetByIdAsync(int id);
        public void AddAsync(Actor actor);
        public  Task<Actor> UpdateAsync(int id, Actor actor);
        public void DeleteAsync(int id);
    }

    public class ActorService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>>GetAllAsync()
        {
            return  await _context.Actors.ToListAsync();
              
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId ==id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor); 
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
