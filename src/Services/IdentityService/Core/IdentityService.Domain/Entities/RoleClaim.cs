namespace IdentityService.Domain.Entities
{
    public class RoleClaim
    {
        public Guid RoleId { get; set; }
        public Guid ClaimId { get; set; }

        public Role Role { get; set; } = null!;
        public Claim Claim { get; set; } = null!;
    }
}