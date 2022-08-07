using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Data.Base
{
    public class EntityBaseRepository <T>: IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.ID == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var data = await _context.Set<T>().ToListAsync();

            return data;
        }


        public async Task<IEnumerable<T>> GetAllOrderBrand()
        {
            var data = await _context.Set<T>().OrderBy(n => n.Brand).ToListAsync();

            return data;
        }
        public async Task<IEnumerable<T>> GetAllOrderPrice()
        {
            var data = await _context.Set<T>().OrderBy(n => n.Price).ToListAsync();

            return data;
        }
        public async Task<IEnumerable<T>> GetAllOrderModel()
        {
            var data = await _context.Set<T>().OrderBy(n => n.ModelName).ToListAsync();

            return data;
        }


        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.ID == id);

            return result;
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}








