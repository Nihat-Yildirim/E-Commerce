using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using ServiceCorePackages.ServiceCore.Application.Repositories;
using ServiceCorePackages.ServiceCore.Domain.Entity;

namespace ServiceCorePackages.ServiceCore.Persistence.Repositories
{
    public abstract class BaseWriteRepository<TEntity, TContext> : IWriteRepository<TEntity>
         where TEntity : BaseEntity, new()
         where TContext : DbContext
    {
        public BaseWriteRepository(TContext context)
        {
            Table = context.Set<TEntity>();
        }

        public DbSet<TEntity> Table { get; }

        public async Task<bool> AddAsync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(entity);

            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<TEntity> entities)
        {
            await Table.AddRangeAsync(entities);

            return true;
        }

        public bool Remove(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(entity);

            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveByIdAsync(Guid id)
        {
            var deletedEntity = await Table.FindAsync(id);

            return Remove(deletedEntity);
        }

        public bool RemoveRange(List<TEntity> entities)
        {
            Table.RemoveRange(entities);

            return true;
        }

        public bool Update(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = Table.Update(entity);

            return entityEntry.State == EntityState.Modified;
        }

        public bool UpdateRange(List<TEntity> entities)
        {
            Table.UpdateRange(entities);

            return true;
        }
    }
}