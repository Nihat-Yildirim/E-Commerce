using IdentityService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.Persistence.EntityFramework.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VarChar")
                .HasMaxLength(125);

            builder.Property(x => x.Active)
                .HasColumnType("Bit");

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