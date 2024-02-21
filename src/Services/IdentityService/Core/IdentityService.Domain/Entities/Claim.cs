using ServiceCorePackages.ServiceCore.Domain.Entity;

namespace IdentityService.Domain.Entities
{
    public class Claim : BaseEntity
    {
        public string Name { get; set; } = null!;
        public DateTime? DeletedDate { get; set; }

        public ICollection<RoleClaim>? RoleClaims { get; set; }
    }
}