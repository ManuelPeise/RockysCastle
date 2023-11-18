using Data.Entities.Interfaces;

namespace Logic.Shared.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity?> GetById(Guid id);

        Task<Guid> Insert(TEntity entity);

        Task InsertRange(List<TEntity> entityCollection);

        Task Update(Guid id, TEntity entity);

        Task UpdateRange(List<TEntity> entities);

        Task Delete(Guid id);
    }
}
