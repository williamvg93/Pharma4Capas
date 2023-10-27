using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Inventory;

namespace Domain.Entities.Product;

public class PresentationType : BaseEntity
{
    public string Name { get; set; }

    /*    Relationship whit CInventory -> One to Many    */
    public ICollection<CInventory> Inventories { get; set; }
    /* --------------------------------------------- */
}
