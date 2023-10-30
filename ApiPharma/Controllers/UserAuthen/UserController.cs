using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPharma.Services;

namespace ApiPharma.Controllers.UserAuthen;

public class UserController : BaseController
{
    public UserController(IUserService uservice)
    {
    }
}
