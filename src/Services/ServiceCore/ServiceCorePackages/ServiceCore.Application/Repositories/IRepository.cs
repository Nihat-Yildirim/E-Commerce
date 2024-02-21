using Microsoft.EntityFrameworkCore;
using ServiceCorePackages.ServiceCore.Domain.Entity;

namespace ServiceCorePackages.ServiceCore.Application.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        public DbSet<TEntity> Table { get; }
    }
}