using IdentityService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceCorePackages.ServiceCore.Domain.Entity;
using System.Reflection;

namespace IdentityService.Persistence.EntityFramework.Context
{
    public class IdentityServiceDbContext : DbContext
    {
        public IdentityServiceDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedDate = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Entity.UpdatedDate = DateTime.Now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<RoleClaim> RoleClaims { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}