using Microsoft.EntityFrameworkCore;
using ServiceCorePackages.ServiceCore.Application.Repositories;
using ServiceCorePackages.ServiceCore.Domain.Entity;
using System.Linq.Expressions;

namespace ServiceCorePackages.ServiceCore.Persistence.Repositories
{
    public abstract class BaseReadRepository<TEntity, TContext> : IReadRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext
    {
        public BaseReadRepository(TContext context)
        {
            Table = context.Set<TEntity>();
        }

        public DbSet<TEntity> Table { get; }

        public IQueryable<TEntity> GetAll(bool tracing = true)
        {
            var query = Table;

            if (!tracing)
                return query.AsNoTracking();

            return query;
        }

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter, bool tracing = true)
        {
            var query = Table.Where(filter).AsQueryable();

            if (!tracing)
                return query.AsNoTracking();

            return query;
        }

        public async Task<TEntity> GetByIdAsync(Guid id, bool tracing = true)
        {
            var query = Table.AsQueryable();

            if (!tracing)
                query = query.AsNoTracking();

            return await query.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter, bool tracing = true)
        {
            var query = Table.AsQueryable();

            if (!tracing)
                query = query.AsNoTracking();

            return await query.SingleOrDefaultAsync(filter);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await Table.AnyAsync(filter);
        }
    }
}