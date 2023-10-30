using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.UserAuthen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.UserAuthen;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Name)
        .HasColumnName("userName")
        .HasColumnType("varchar")
        .HasMaxLength(50);


        builder.Property(p => p.Password)
       .HasColumnName("password")
       .HasColumnType("varchar")
       .HasMaxLength(255)
       .IsRequired();

        builder.Property(p => p.Email)
        .HasColumnName("email")
        .HasColumnType("varchar")
        .HasMaxLength(100)
        .IsRequired();

        builder.HasMany(r => r.Rols)
        .WithMany(u => u.Users)
        .UsingEntity<UserRol>(
            j => j
            .HasOne(r => r.Rol)
            .WithMany(ur => ur.UserRols)
            .HasForeignKey(fk => fk.RolIdFk),

            j => j
            .HasOne(u => u.User)
            .WithMany(ur => ur.UserRols)
            .HasForeignKey(fk => fk.UserIdFk),

            j =>
            {
                j.ToTable("userRol");
                j.HasKey(t => new { t.UserIdFk, t.RolIdFk });
            }
        );

        builder.HasMany(p => p.RefreshTokens)
        .WithOne(p => p.User)
        .HasForeignKey(p => p.UserIdFk);
    }
}