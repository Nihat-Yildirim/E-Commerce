namespace IdentityService.Domain.Tokens.Options
{
    public record RefreshTokenOptions
    {
        public int RefreshTokenExpirationHour { get; set; }
    }
}