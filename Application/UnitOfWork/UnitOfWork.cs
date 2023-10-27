using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository.Inventory;
using Domain.Interfaces.Inventory;
using Persistence.Data;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly PharmaContext _context;
    private IInventoryManagRepo _invenManag;

    public UnitOfWork(PharmaContext context)
    {
        _context = context;
    }

    public IInventoryManagRepo InvenManags
    {
        get
        {
            if (_invenManag == null)
            {
                _invenManag = new InvenManaRepo(_context);
            }
            return _invenManag;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

}