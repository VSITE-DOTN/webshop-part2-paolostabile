﻿using WebShop.Shared;
using WebShop.Shared.Models;

namespace WebShop.Server.Services.AuthService;

public interface IAuthService
{
    Task<ServiceResponse<int>> Register(User user, string password);
    Task<bool> UserExists(string email);
}
