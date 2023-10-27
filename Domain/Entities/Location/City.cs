using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;

namespace Domain.Entities.Location;

public class City : BaseEntity
{
    public string Name { get; set; }
    /* --------- Foreign Keys ---------- */

    /* Foreign Key for Department */
    public int IdDepartFk { get; set; }
    public Department Department { get; set; }

    /* --------------------------------- */

    /*    Relationship whit Address -> One to Many    */
    public ICollection<Address> Addresses { get; set; }
    /* --------------------------------------------- */

}
