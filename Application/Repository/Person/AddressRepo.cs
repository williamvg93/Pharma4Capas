using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Domain.Interfaces.Person;
using Persistence.Data;

namespace Application.Repository.Person;

public class AddressRepo : GenericRepository<Address>, IAddressRepo
{
    private readonly PharmaContext _context;

    public AddressRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}