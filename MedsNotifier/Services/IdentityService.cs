using MedsNotifier.Data;
using MedsNotifier.JwtOptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
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
            if (user != null)
            {
                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.String),
                new Claim("Age", user.Age?.ToString(), ClaimValueTypes.String),
                new Claim("Weight", user.Weight?.ToString(), ClaimValueTypes.String),
                new Claim("Height",user.Height?.ToString(), ClaimValueTypes.String),
                new Claim(ClaimTypes.Name, user.Username.ToString(), ClaimValueTypes.String),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString(), ClaimValueTypes.String),
                new Claim(ClaimTypes.Gender, user.Gender.ToString(), ClaimValueTypes.String)
                };

                return new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            }

            return new ClaimsIdentity();
        }

        public string GetClaimValue(ClaimsPrincipal user, string claimType)
        {
           return user.Claims.ToList().FirstOrDefault(u => u.Type == claimType)?.Value;
        }
    }
}
