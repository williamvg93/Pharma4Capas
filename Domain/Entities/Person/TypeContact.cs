using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.Person;

public class TypeContact : BaseEntity
{
    public string Name { get; set; }

    /*   Relationship whit Person -> Many to Many    */
    public ICollection<PersonContact> PersonContacts { get; set; }

    /* -------------------------------------------- */
}
