using IdentityService.Application.Repositories.ClaimRepositories;
using IdentityService.Domain.Entities;
using IdentityService.Persistence.EntityFramework.Context;
using ServiceCorePackages.ServiceCore.Persistence.Repositories;

namespace IdentityService.Persistence.EntityFramework.Repositories.ClaimRepositories
{
    public sealed class ClaimReadRepository : BaseReadRepository<Claim, IdentityServiceDbContext>, IClaimReadRepository
    {
        public ClaimReadRepository(IdentityServiceDbContext context) : base(context)
        {
        }
    }
}