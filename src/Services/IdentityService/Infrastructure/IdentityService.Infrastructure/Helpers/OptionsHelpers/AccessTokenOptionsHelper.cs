using IdentityService.Domain.Tokens.Options;
using Microsoft.Extensions.Configuration;

namespace IdentityService.Infrastructure.Helpers.OptionsHelpers
{
    public static class AccessTokenOptionsHelper
    {
        public static AccessTokenOptions GetAccessTokenOptions()
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/IdentityService.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection("AccessTokenOptions").Get<AccessTokenOptions>()!;
        }
    }
}