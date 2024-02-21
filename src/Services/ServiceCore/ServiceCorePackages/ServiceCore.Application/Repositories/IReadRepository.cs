using ServiceCorePackages.ServiceCore.Domain.Entity;
using System.Linq.Expressions;

namespace ServiceCorePackages.ServiceCore.Application.Repositories
{
    public interface IReadRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter, bool tracing = true);
        IQueryable<TEntity> GetAll(bool tracing = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter, bool tracing = true);
        Task<TEntity> GetByIdAsync(Guid id, bool tracing = true);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
    }
}