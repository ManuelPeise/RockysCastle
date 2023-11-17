using Data.Entities.Interfaces;

namespace Logic.Shared.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity?> GetById(Guid id);

        Task Insert(TEntity entity);

        Task Update(Guid id, TEntity entity);

        Task Delete(Guid id);
    }
}
