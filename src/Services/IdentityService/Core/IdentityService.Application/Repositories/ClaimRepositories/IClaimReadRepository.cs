using IdentityService.Domain.Entities;
using ServiceCorePackages.ServiceCore.Application.Repositories;

namespace IdentityService.Application.Repositories.ClaimRepositories
{
    public interface IClaimReadRepository : IReadRepository<Claim>
    {
    }
}