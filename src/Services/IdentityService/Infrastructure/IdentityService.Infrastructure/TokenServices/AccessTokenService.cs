using IdentityService.Application.TokenServices;
using IdentityService.Domain.Tokens;
using IdentityService.Domain.Tokens.Options;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using IdentityService.Infrastructure.Helpers.OptionsHelpers;
using IdentityService.Infrastructure.Helpers.EncryptionHelpers;
using Claim = System.Security.Claims.Claim;
using IdentityService.Infrastructure.Extensions;

namespace IdentityService.Infrastructure.TokenServices
{
    public sealed class AccessTokenService : IAccessTokenService
    {
        private readonly AccessTokenOptions _options;
        private DateTime _accessTokenExpiration;
        public AccessTokenService()
        {
            _options = AccessTokenOptionsHelper.GetAccessTokenOptions();
        }

        public AccessToken CreateAccessToken(User user, Role role)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_options.AccessTokenExpirationMinute);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_options.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(user, role, signingCredentials);
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new()
            {
                IssuedDate = DateTime.Now,
                ExpiresDate = _accessTokenExpiration,
                Token = token,
            };
        }

        private JwtSecurityToken CreateJwtSecurityToken(User user, Role role, SigningCredentials signingCredentials)
        {
            JwtSecurityToken jwt = new(
                issuer: _options.Issuer,
                audience: _options.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, role),
                signingCredentials: signingCredentials
                );

            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, Role role)
        {
            List<Claim> claims = new();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddName(user.Name + " " + user.LastName);
            claims.AddEmail(user.Email);
            claims.AddRole(role.Name);
            claims.AddRoleClaims(role.Claims);
            return claims;
        }
    }
}