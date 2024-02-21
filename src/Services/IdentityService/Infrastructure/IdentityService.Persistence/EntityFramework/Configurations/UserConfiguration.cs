using IdentityService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.Persistence.EntityFramework.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VarChar")
                .HasMaxLength(25);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("VarChar")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("VarChar")
                .HasMaxLength(125);

            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasColumnType("VarBinary")
                .HasMaxLength(500);

            builder.Property(x => x.PasswordSalt)
                .IsRequired()
                .HasColumnType("VarBinary")
                .HasMaxLength(500);

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