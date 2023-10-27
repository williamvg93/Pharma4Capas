using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Location;
using Domain.Interfaces.Location;
using Persistence.Data;

namespace Application.Repository.Location;

public class CityRepo : GenericRepository<City>, ICityRepo
{
    private readonly PharmaContext _context;

    public CityRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}