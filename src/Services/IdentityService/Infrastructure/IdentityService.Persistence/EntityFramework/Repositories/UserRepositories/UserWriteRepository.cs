using IdentityService.Application.Repositories.UserRepositories;
using IdentityService.Domain.Entities;
using IdentityService.Persistence.EntityFramework.Context;
using ServiceCorePackages.ServiceCore.Persistence.Repositories;

namespace IdentityService.Persistence.EntityFramework.Repositories.UserRepositories
{
    public sealed class UserWriteRepository : BaseWriteRepository<User, IdentityServiceDbContext>, IUserWriteRepository
    {
        public UserWriteRepository(IdentityServiceDbContext context) : base(context)
        {
        }
    }
}