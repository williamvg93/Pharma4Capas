using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Management;
using Domain.Interfaces.Management;
using Persistence.Data;

namespace Application.Repository.Management;

public class PayMethRepo : GenericRepository<PaymentMethod>, IPayMethRepo
{
    private readonly PharmaContext _context;

    public PayMethRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}