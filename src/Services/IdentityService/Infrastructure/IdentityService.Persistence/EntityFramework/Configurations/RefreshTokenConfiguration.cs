using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IdentityService.Domain.Entities;

namespace IdentityService.Persistence.EntityFramework.Configurations
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithOne(x => x.RefreshToken)
                .HasForeignKey<RefreshToken>(x => x.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Token)
                .IsRequired()
                .HasColumnType("VarChar")
                .HasMaxLength(36);

            builder.Property(x => x.IssuedDate)
                .IsRequired()
                .HasColumnType("DateTime2");

            builder.Property(x => x.ExpiresDate)
                .IsRequired()
                .HasColumnType("DateTime2");

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