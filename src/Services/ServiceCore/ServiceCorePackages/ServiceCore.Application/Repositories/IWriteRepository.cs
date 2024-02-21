using ServiceCorePackages.ServiceCore.Domain.Entity;

namespace ServiceCorePackages.ServiceCore.Application.Repositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        Task<bool> AddAsync(TEntity entity);
        Task<bool> AddRangeAsync(List<TEntity> entities);
        bool Remove(TEntity entity);
        Task<bool> RemoveByIdAsync(Guid id);
        bool RemoveRange(List<TEntity> entities);
        bool Update(TEntity entity);
        bool UpdateRange(List<TEntity> entities);
    }
}