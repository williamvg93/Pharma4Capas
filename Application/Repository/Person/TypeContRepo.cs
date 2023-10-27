using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Domain.Interfaces.Person;
using Persistence.Data;


namespace Application.Repository.Person;

public class TypeContRepo : GenericRepository<TypeContact>, ITypeContRepo
{
    private readonly PharmaContext _context;

    public TypeContRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}