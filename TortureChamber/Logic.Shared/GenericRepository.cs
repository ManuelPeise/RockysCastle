using Data.Database;
using Data.Entities.Interfaces;
using Logic.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Logic.Shared
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly AppDataContext _context;

        public GenericRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity?> Get(Func<TEntity, bool> predicate)
        {
            var all = await GetAll();

            return all.Where(predicate).FirstOrDefault();
        }
        public async Task<List<TEntity>> GetCollection(Func<TEntity, bool> predicate)
        {
            var all = await GetAll();

            return all.Where(predicate).ToList();
        }

        public async Task<TEntity?> GetById(Guid id)
        {
            return await _context.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Guid> Insert(TEntity entity)
        {
            var insertedEntity = await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return insertedEntity.Entity.Id;
        }

        public async Task InsertRange(List<TEntity> entityCollection)
        {
            await _context.Set<TEntity>().AddRangeAsync(entityCollection);

            await _context.SaveChangesAsync();
        }

        public async Task Update(Guid id, TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRange(List<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);

            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
