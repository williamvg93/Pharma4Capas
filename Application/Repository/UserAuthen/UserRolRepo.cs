using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.UserAuthen;
using Domain.Interfaces.UserAuthen;
using Persistence.Data;

namespace Application.Repository.UserAuthen;

public class UserRolRepo : GenericRepository<UserRol>, IUserRolRepo
{
    private readonly PharmaContext _context;

    public UserRolRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}