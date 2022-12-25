using BlogApplication.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Data.Concrete.EFCore
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity>
        where TEntity : class
    {
        protected DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TEntity entity)
        {
           await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(int i)
        {
            return await _context.Set<TEntity>().FindAsync(i);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
           var tentity= _context.Set<TEntity>().Find(id);
            _context.Remove(tentity);
            _context.SaveChanges();
        }
    }
}
