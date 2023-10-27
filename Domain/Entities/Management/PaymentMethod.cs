using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Inventory;

namespace Domain.Entities.Management;

public class PaymentMethod : BaseEntity
{
    public string Name { get; set; }

    /* Relationship whit Inventory Management -> Many to Many */
    public ICollection<InventoryManagement> InventoryManagements { get; set; }
    /* ----------------------------------------- */

}
