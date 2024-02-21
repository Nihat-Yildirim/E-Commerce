namespace IdentityService.Domain.Tokens
{
    public record Token
    {
        public Token()
        {

        }

        public Token(AccessToken accessToken, RefreshToken refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public AccessToken AccessToken { get; set; } = null!;
        public RefreshToken RefreshToken { get; set; } = null!;
    }
}