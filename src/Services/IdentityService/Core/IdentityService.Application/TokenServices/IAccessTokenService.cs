using IdentityService.Domain.Tokens;

namespace IdentityService.Application.TokenServices
{
    public interface IAccessTokenService
    {
        AccessToken CreateAccessToken(User user, Role role);
    }

    public record User
    {
        public User()
        {

        }

        public User(Guid id, string name, string lastName, string email)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }

    public record Role
    {
        public Role()
        {

        }

        public Role(string name, List<string> claims)
        {
            Name = name;
            Claims = claims;
        }

        public string Name { get; set; } = null!;
        public List<string> Claims { get; set; }
    }
}