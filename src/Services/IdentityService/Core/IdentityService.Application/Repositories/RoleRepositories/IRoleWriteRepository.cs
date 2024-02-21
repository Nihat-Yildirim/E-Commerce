using IdentityService.Domain.Entities;
using ServiceCorePackages.ServiceCore.Application.Repositories;

namespace IdentityService.Application.Repositories.RoleRepositories
{
    public interface IRoleWriteRepository : IWriteRepository<Role>
    {
    }
}