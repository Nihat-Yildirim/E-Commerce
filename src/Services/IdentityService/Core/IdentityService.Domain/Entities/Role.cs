using ServiceCorePackages.ServiceCore.Domain.Entity;

namespace IdentityService.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? DeletedDate { get; set; }

        public ICollection<User>? Users { get; set; }
        public ICollection<RoleClaim>? RoleClaims { get; set; }
    }
}