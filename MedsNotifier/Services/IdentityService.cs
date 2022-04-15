using MedsNotifier.Data;
using MedsNotifier.JwtOptions;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public class IdentityService : IIdentityService
    {
        public ClaimsIdentity GetIdentity(User user)
        {
            var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim("Age", user.Age?.ToString()),
                new Claim("Weight", user.Weight?.ToString()),
                new Claim("Height",user.Height?.ToString()),
                new Claim(ClaimTypes.Name, user.Username.ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                };

            return new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
