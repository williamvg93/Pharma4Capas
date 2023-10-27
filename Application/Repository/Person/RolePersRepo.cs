using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Domain.Interfaces.Person;
using Persistence.Data;

namespace Application.Repository.Person;

public class RolePersRepo : GenericRepository<RolePerson>, IRolePersRepo
{
    private readonly PharmaContext _context;

    public RolePersRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}