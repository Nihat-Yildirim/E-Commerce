﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Claim = System.Security.Claims.Claim;

namespace IdentityService.Infrastructure.Extensions
{
    public static class ClaimExtensions
    {
        public static void AddEmail(this ICollection<Claim> claims, string email)
            => claims.Add(new Claim(JwtRegisteredClaimNames.Email, email));

        public static void AddName(this ICollection<Claim> claims, string name)
            => claims.Add(new Claim(ClaimTypes.Name, name));

        public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
            => claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier));

        public static void AddRole(this ICollection<Claim> claims, string role)
            => claims.Add(new Claim(ClaimTypes.Role, role));

        public static void AddRoleClaims(this ICollection<Claim> claims, List<string> _claims)
            => _claims.ForEach(claim => claims.Add(new Claim("claim", claim)));
    }
}