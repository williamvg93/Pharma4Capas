using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Person;

public class TypePersonConfig : IEntityTypeConfiguration<TypePerson>
{
    public void Configure(EntityTypeBuilder<TypePerson> builder)
    {
        /* Assign Table name */
        builder.ToTable("typeperson");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);

        /* Assign Colums */
        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);
    }
}