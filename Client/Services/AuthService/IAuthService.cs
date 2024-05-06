using WebShop.Shared.Models;
using WebShop.Shared;

namespace WebShop.Client.Services.AuthService;

public interface IAuthService
{
    Task<ServiceResponse<int>> Register(UserRegister request);
}
