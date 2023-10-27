using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.UserAuthen;

namespace Domain.Interfaces.UserAuthen;

public interface IUserRepo : IGenericRepository<User>
{
    Task<User> GetByUsernameAsync(string username);
    Task<User> GetByRefreshTokenAsync(string username);
}