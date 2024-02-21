using IdentityService.Persistence.EntityFramework.Context;
using IdentityService.Persistence.EntityFramework.UnitOfWork;
using IdentityService.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceCorePackages.ServiceCore.Application.UnitOfWork;

namespace IdentityService.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<IdentityServiceDbContext>(options => options.UseSqlServer(ConnectionStringHelper.GetSqlServerConnectionString()));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}