using IdentityService.Application.Repositories.RefreshTokenRepositories;
using IdentityService.Domain.Entities;
using IdentityService.Persistence.EntityFramework.Context;
using ServiceCorePackages.ServiceCore.Persistence.Repositories;

namespace IdentityService.Persistence.EntityFramework.Repositories.RefreshTokenRepositories
{
    public sealed class RefreshTokenReadRepository : BaseReadRepository<RefreshToken, IdentityServiceDbContext>, IRefreshTokenReadRepository
    {
        public RefreshTokenReadRepository(IdentityServiceDbContext context) : base(context)
        {
        }
    }
}