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
        public IdentityService()
        {
        }
        public void SetUserClaims(User user)
        {
            List<Claim> claims;

            claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("Age", user.Age?.ToString()),
                new Claim("Weight", user.Weight?.ToString()),
                new Claim("Height",user.Height.ToString())
            };

            user.Claims = claims;

        }

        public IEnumerable<Claim> GetUserClaims(User user) => user.Claims;
        public ClaimsIdentity GetIdentity(User user) => new ClaimsIdentity(GetUserClaims(user), "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
    }
}
