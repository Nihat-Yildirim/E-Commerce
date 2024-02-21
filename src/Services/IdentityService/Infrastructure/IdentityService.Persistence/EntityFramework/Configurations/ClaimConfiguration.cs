using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IdentityService.Domain.Entities;

namespace IdentityService.Persistence.EntityFramework.Configurations
{
    public class ClaimConfiguration : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VarChar")
                .HasMaxLength(50);

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasColumnType("DateTime2");

            builder.Property(x => x.UpdatedDate)
                .IsRequired(false)
                .HasColumnType("DateTime2");

            builder.Property(x => x.DeletedDate)
                .IsRequired(false)
                .HasColumnType("DateTime2");
        }
    }
}