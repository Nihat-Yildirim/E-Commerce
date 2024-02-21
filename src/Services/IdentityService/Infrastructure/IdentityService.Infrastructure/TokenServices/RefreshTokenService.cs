using IdentityService.Application.TokenServices;
using IdentityService.Domain.Tokens;
using IdentityService.Domain.Tokens.Options;
using IdentityService.Infrastructure.Helpers.OptionsHelpers;

namespace IdentityService.Infrastructure.TokenServices
{
    public sealed class RefreshTokenService : IRefreshTokenService
    {
        private readonly RefreshTokenOptions _options;
        public RefreshTokenService()
        {
            _options = RefreshTokenOptionsHelper.GetRefreshTokenOptions();
        }

        public RefreshToken CreateRefreshToken()
        {
            return new()
            {
                Token = Guid.NewGuid().ToString(),
                IssuedDate = DateTime.Now,
                ExpiresDate = DateTime.Now.AddHours(_options.RefreshTokenExpirationHour),
            };
        }
    }
}