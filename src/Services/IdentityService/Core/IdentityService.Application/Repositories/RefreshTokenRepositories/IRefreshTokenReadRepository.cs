using IdentityService.Domain.Entities;
using ServiceCorePackages.ServiceCore.Application.Repositories;

namespace IdentityService.Application.Repositories.RefreshTokenRepositories
{
    public interface IRefreshTokenReadRepository : IReadRepository<RefreshToken>
    {
    }
}