using IdentityService.Domain.Tokens;

namespace IdentityService.Application.TokenServices
{
    public interface IRefreshTokenService
    {
        RefreshToken CreateRefreshToken();
    }
}