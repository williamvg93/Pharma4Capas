using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.Location;
public class Country : BaseEntity
{
    public string Name { get; set; }

    /*    Relationship whit Department -> One to Many    */
    public ICollection<Department> Departments { get; set; }
    /* --------------------------------------------- */
}
