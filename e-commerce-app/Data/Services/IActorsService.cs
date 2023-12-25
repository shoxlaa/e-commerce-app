using e_commerce_app.Models;

namespace e_commerce_app.Data.Services
{
    public interface IActorsService
    {
        public  Task<IEnumerable<Actor>> GetAllAsync();
        public Task<Actor> GetByIdAsync(int id);
        public void AddAsync(Actor actor);
        public  Task<Actor> UpdateAsync(int id, Actor actor);
        public Task DeleteAsync(int id);
    }
}
