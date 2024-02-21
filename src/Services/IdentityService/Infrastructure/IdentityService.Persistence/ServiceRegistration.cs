using IdentityService.Persistence.EntityFramework.Context;
using IdentityService.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<IdentityServiceDbContext>(options => options.UseSqlServer(ConnectionStringHelper.GetSqlServerConnectionString()));
        }
    }
}