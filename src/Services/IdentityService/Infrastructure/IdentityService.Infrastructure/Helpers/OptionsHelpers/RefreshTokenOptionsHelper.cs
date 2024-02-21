using IdentityService.Domain.Tokens.Options;
using Microsoft.Extensions.Configuration;

namespace IdentityService.Infrastructure.Helpers.OptionsHelpers
{
    public static class RefreshTokenOptionsHelper
    {
        public static RefreshTokenOptions GetRefreshTokenOptions()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/IdentityService.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection("RefreshTokenOptions").Get<RefreshTokenOptions>()!;
        }
    }
}