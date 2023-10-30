using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPharma.Dtos.Get.UserAuthen;

namespace ApiPharma.Services;

public interface IUserService
{
    Task<String> RegisterAsync(RegisterDto model);
    Task<DataUserDto> GetTokenAsync(LoginDto model);
    Task<string> AddRoleAsync(AddRoleDto model);
    Task<DataUserDto> RefreshTokenAsync(string refreshToken);
}
