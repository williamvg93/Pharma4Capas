using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Inventory;
using Domain.Interfaces.Inventory;
using Persistence.Data;

namespace Application.Repository.Inventory;

public class InvenManaRepo : GenericRepository<InventoryManagement>, IInventoryManagRepo
{
    private readonly PharmaContext _context;

    public InvenManaRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}