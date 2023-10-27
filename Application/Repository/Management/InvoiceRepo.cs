using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Management;
using Domain.Interfaces.Management;
using Persistence.Data;

namespace Application.Repository.Management;

public class InvoiceRepo : GenericRepository<Invoice>, IInvoiceRepo
{
    private readonly PharmaContext _context;

    public InvoiceRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}