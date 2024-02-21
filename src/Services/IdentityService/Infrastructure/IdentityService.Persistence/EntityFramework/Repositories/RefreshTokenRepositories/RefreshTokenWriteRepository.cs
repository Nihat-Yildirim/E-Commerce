using IdentityService.Application.Repositories.RefreshTokenRepositories;
using IdentityService.Domain.Entities;
using IdentityService.Persistence.EntityFramework.Context;
using ServiceCorePackages.ServiceCore.Persistence.Repositories;

namespace IdentityService.Persistence.EntityFramework.Repositories.RefreshTokenRepositories
{
    public sealed class RefreshTokenWriteRepository : BaseWriteRepository<RefreshToken, IdentityServiceDbContext>, IRefreshTokenWriteRepository
    {
        public RefreshTokenWriteRepository(IdentityServiceDbContext context) : base(context)
        {
        }
    }
}