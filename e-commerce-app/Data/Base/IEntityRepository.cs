namespace e_commerce_app.Data.Base
{
    public interface IEntityRepository<T> where T : class, IEntityBase, new()
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task AddAsync(T value);
        public Task  UpdateAsync(int id, T value);
        public Task DeleteAsync(int id);
    }
}
