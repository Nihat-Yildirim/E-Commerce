using IdentityService.Application.Repositories.ClaimRepositories;
using IdentityService.Domain.Entities;
using IdentityService.Persistence.EntityFramework.Context;
using ServiceCorePackages.ServiceCore.Persistence.Repositories;

namespace IdentityService.Persistence.EntityFramework.Repositories.ClaimRepositories
{
    public sealed class ClaimWriteRepository : BaseWriteRepository<Claim, IdentityServiceDbContext>, IClaimWriteRepository
    {
        public ClaimWriteRepository(IdentityServiceDbContext context) : base(context)
        {
        }
    }
}