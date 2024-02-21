namespace IdentityService.Domain.Tokens
{
    public abstract class BaseToken
    {
        public string Token { get; set; } = null!;
        public DateTime ExpiresDate { get; set; }
        public DateTime IssuedDate { get; set; }
    }
}