using IdentityService.Application.Repositories.ClaimRepositories;
using IdentityService.Application.Repositories.RefreshTokenRepositories;
using IdentityService.Application.Repositories.RoleRepositories;
using IdentityService.Application.Repositories.UserRepositories;
using IdentityService.Persistence.EntityFramework.Context;
using IdentityService.Persistence.EntityFramework.Repositories.ClaimRepositories;
using IdentityService.Persistence.EntityFramework.Repositories.RefreshTokenRepositories;
using IdentityService.Persistence.EntityFramework.Repositories.RoleRepositories;
using IdentityService.Persistence.EntityFramework.Repositories.UserRepositories;
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

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

            services.AddScoped<IRoleReadRepository, RoleReadRepository>();
            services.AddScoped<IRoleWriteRepository, RoleWriteRepository>();

            services.AddScoped<IRefreshTokenReadRepository, RefreshTokenReadRepository>();
            services.AddScoped<IRefreshTokenWriteRepository, RefreshTokenWriteRepository>();

            services.AddScoped<IClaimReadRepository, ClaimReadRepository>();
            services.AddScoped<IClaimWriteRepository, ClaimWriteRepository>();
        }
    }
}