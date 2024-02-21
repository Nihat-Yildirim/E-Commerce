using IdentityService.Application.Repositories.RoleRepositories;
using IdentityService.Domain.Entities;
using IdentityService.Persistence.EntityFramework.Context;
using ServiceCorePackages.ServiceCore.Persistence.Repositories;

namespace IdentityService.Persistence.EntityFramework.Repositories.RoleRepositories
{
    public sealed class RoleWriteRepository : BaseWriteRepository<Role, IdentityServiceDbContext>, IRoleWriteRepository
    {
        public RoleWriteRepository(IdentityServiceDbContext context) : base(context)
        {
        }
    }
}