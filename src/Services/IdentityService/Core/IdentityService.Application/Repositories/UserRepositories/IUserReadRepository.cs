using IdentityService.Domain.Entities;
using ServiceCorePackages.ServiceCore.Application.Repositories;

namespace IdentityService.Application.Repositories.UserRepositories
{
    public interface IUserReadRepository : IReadRepository<User>
    {
    }
}