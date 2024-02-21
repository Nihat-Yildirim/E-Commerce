namespace IdentityService.Domain.DTOs.ClaimDTOs
{
    public record ClaimDto
    {
        public ClaimDto()
        {
            
        }

        public ClaimDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
    }
}