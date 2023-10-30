using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Location;

public class DepartConfig : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        /* Assign Table name */
        builder.ToTable("department");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);

        /* Assign Colums */
        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);

        /* Assign Foreign Key */
        builder.HasOne(fk => fk.Countries)
        .WithMany(fk => fk.Departments)
        .HasForeignKey(fk => fk.IdCountryFk);
    }
}