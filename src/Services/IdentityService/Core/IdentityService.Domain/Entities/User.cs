using ServiceCorePackages.ServiceCore.Domain.Entity;

namespace IdentityService.Domain.Entities
{
    public class User : BaseEntity
    {
        public Guid RoleId { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public DateTime BirthTime { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Role? Role { get; set; } = null!;
        public RefreshToken RefreshToken { get; set; } = null!;
    }
}