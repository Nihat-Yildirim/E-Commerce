using IdentityService.Persistence.EntityFramework.Context;
using ServiceCorePackages.ServiceCore.Application.UnitOfWork;

namespace IdentityService.Persistence.EntityFramework.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly IdentityServiceDbContext _context;
        public UnitOfWork(IdentityServiceDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync()
            => await _context.SaveChangesAsync();
    }
}