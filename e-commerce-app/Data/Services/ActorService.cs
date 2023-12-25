﻿using e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Data.Services
{
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

        public async Task DeleteAsync(int id)
        {
            var result = await this.GetByIdAsync(id); 
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>>GetAllAsync()
        {
            return  await _context.Actors.ToListAsync();
              
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id ==id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
           
            var result =   _context.Actors.FirstOrDefault(n => n.Id ==id);

            result.FullName=newActor.FullName;
            result.ProfilePictureURL=newActor.ProfilePictureURL;
            result.Bio= newActor.Bio;   

           await  _context.SaveChangesAsync();
        
            return newActor;
        }
    }
}
