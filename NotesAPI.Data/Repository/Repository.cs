using Microsoft.EntityFrameworkCore;
using NotesAPI.Data.Models.Entities;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;

namespace NotesAPI.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private readonly NotesContext _context;

        public Repository(NotesContext context)
        {
            _context = context;
        }

        public virtual async Task<T> AddAsync(T entity, bool saveChanges = true)
        {
            var r = await _context.Set<T>().AddAsync(entity);
            if (saveChanges)
                await _context.SaveChangesAsync();
            return r.Entity;
        }

        public async Task DeleteAsync(T entity, bool saveChanges = true)
        {
            _context.Set<T>().Remove(entity);
            if (saveChanges)
                await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task UpdateAsync(T entity, bool saveChanges = true)
        {
            _context.Set<T>().Update(entity);
            if (saveChanges)
                await _context.SaveChangesAsync();
        }
    }
}
