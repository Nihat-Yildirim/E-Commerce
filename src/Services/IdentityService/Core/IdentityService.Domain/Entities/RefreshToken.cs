using ServiceCorePackages.ServiceCore.Domain.Entity;

namespace IdentityService.Domain.Entities
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; } = null!;
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiresDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public User User { get; set; } = null!;
    }
}