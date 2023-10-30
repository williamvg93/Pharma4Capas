using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Person;

public class PersContactConfig : IEntityTypeConfiguration<PersonContact>
{
    public void Configure(EntityTypeBuilder<PersonContact> builder)
    {
        /* Assign Table name */
        builder.ToTable("personcontact");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);

        /* Assign Foreign Key */
        builder.HasOne(fk => fk.People)
        .WithMany(fk => fk.PersonContacts)
        .HasForeignKey(fk => fk.IdPersonFk);

        builder.HasOne(fk => fk.TypeContacts)
        .WithMany(fk => fk.PersonContacts)
        .HasForeignKey(fk => fk.IdTypeContactFk);
    }
}