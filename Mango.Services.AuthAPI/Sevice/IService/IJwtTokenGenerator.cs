﻿using Mango.Services.AuthAPI.Models;

namespace Mango.Services.AuthAPI.Sevice.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser,IEnumerable<string>roles);
    }
}
