using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedLibraryManagementSystem.Repositories
{
    public class GenericRepository<T> :
        IGenericRepository<T>
        where T : class
    {
        protected readonly LibraryDbContext _context;

        protected readonly DbSet<T> _dbSet;

        public GenericRepository(
            LibraryDbContext context)
        {
            _context = context;

            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity =
                await _dbSet.FindAsync(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);

                await _context.SaveChangesAsync();
            }
        }
    }
}