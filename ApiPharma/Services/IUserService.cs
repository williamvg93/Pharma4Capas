using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPharma.Services;

public interface IUserService
{

    Task<String> RegisterAsync();

}
