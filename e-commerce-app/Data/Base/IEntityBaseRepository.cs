using System.Linq.Expressions;

namespace e_commerce_app.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        public Task<T> GetByIdAsync(int id);
        public Task AddAsync(T value);
        public Task  UpdateAsync(int id, T value);
        public Task DeleteAsync(int id);
    }
}
