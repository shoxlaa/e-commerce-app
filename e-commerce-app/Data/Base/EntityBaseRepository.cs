﻿using e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace e_commerce_app.Data.Base
{
    //abstract class
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context) 
        {
            _context = context;
        }
        public async Task AddAsync(T value)
        {
           await  _context.Set<T>().AddAsync(value);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id ==id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State= EntityState.Deleted; 
            await _context.SaveChangesAsync();  
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           var result = await _context.Set<T>().ToListAsync();  
            return result;  
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id ==id);
            return result;
        }

        public async Task UpdateAsync(int id, T value)
        {
            EntityEntry entityEntry = _context.Entry<T>(value);
            entityEntry.State= EntityState.Modified; 
            await _context.SaveChangesAsync();
        }
    }
}
