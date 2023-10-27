using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.UserAuthen;
using Domain.Interfaces.UserAuthen;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository.UserAuthen;

public class UserRepo : GenericRepository<User>, IUserRepo
{
    private readonly PharmaContext _context;

    public UserRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
    public async Task<User> GetByRefreshTokenAsync(string refreshToken)
    {
        return await _context.Users
            .Include(u => u.Rols)
            .Include(u => u.RefreshTokens)
            .FirstOrDefaultAsync(u => u.RefreshTokens.Any(t => t.Token == refreshToken));
    }

    public async Task<User> GetByUsernameAsync(string username)
    {
        return await _context.Users
            .Include(u => u.Rols)
            .Include(u => u.RefreshTokens)
            .FirstOrDefaultAsync(u => u.Name.ToLower() == username.ToLower());
    }
}