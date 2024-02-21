using Microsoft.Extensions.Configuration;

namespace IdentityService.Persistence.Helpers
{
    public static class ConnectionStringHelper
    {
        public static string GetSqlServerConnectionString()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/IdentityService.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("SQLServer")!;
        }
    }
}