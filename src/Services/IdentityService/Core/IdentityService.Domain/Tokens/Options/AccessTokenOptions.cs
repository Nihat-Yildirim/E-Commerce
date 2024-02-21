namespace IdentityService.Domain.Tokens.Options
{
    public record AccessTokenOptions
    {
        public string Audience { get; set; } = null!;
        public string Issuer { get; set; } = null!;
        public int AccessTokenExpirationMinute { get; set; }
        public string SecurityKey { get; set; } = null!;
    }
}