﻿// <auto-generated />
using System;
using IdentityService.Persistence.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdentityService.Persistence.EntityFramework.Migrations
{
    [DbContext(typeof(IdentityServiceDbContext))]
    [Migration("20240221124315_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IdentityService.Domain.Entities.Claim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime>("ExpiresDate")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("VarChar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("Bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("VarChar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.RoleClaim", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClaimId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "ClaimId");

                    b.HasIndex("ClaimId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("VarChar");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VarBinary");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VarBinary");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("IdentityService.Domain.Entities.User", "User")
                        .WithOne("RefreshToken")
                        .HasForeignKey("IdentityService.Domain.Entities.RefreshToken", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.RoleClaim", b =>
                {
                    b.HasOne("IdentityService.Domain.Entities.Claim", "Claim")
                        .WithMany("RoleClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IdentityService.Domain.Entities.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Claim");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.User", b =>
                {
                    b.HasOne("IdentityService.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.Claim", b =>
                {
                    b.Navigation("RoleClaims");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.Role", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.User", b =>
                {
                    b.Navigation("RefreshToken")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
