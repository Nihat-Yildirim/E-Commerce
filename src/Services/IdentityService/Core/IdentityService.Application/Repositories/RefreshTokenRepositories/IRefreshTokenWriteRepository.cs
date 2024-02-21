using IdentityService.Domain.Entities;
using ServiceCorePackages.ServiceCore.Application.Repositories;

namespace IdentityService.Application.Repositories.RefreshTokenRepositories
{
    public interface IRefreshTokenWriteRepository : IWriteRepository<RefreshToken>
    {
    }
}