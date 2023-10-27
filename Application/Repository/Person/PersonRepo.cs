using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Domain.Interfaces.Person;
using Persistence.Data;

namespace Application.Repository.Person;

public class PersonRepo : GenericRepository<CPerson>, IPersonRepo
{
    private readonly PharmaContext _context;

    public PersonRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}