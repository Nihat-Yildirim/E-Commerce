using Microsoft.IdentityModel.Tokens;

namespace IdentityService.Infrastructure.Helpers.EncryptionHelpers
{
    public static class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
            => new(securityKey, SecurityAlgorithms.HmacSha512Signature);
    }
}