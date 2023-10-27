using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.UserAuthen;
using Domain.Interfaces.UserAuthen;
using Persistence.Data;

namespace Application.Repository.UserAuthen;

public class RolRepo : GenericRepository<Rol>, IRolRepo
{
    private readonly PharmaContext _context;

    public RolRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}