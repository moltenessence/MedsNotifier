using MedsNotifier.Data;
using MedsNotifier.Data.Models;
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
    public class JWTService
    {
		private readonly ITokenOptions tokenOptions;
        private readonly IdentityService identityService;
		public JWTService(ITokenOptions TokenOptions, IdentityService IdentityService)
        {
			tokenOptions = TokenOptions;
            identityService = IdentityService;
        }
        public string GenerateGWTToken(User user)
        {
            var identity = GetIdentity(user);

            var creationDate = DateTime.UtcNow;
            var securityKey = tokenOptions.GetSymmetricSecurityKey();
            var jwt = new JwtSecurityToken(issuer: tokenOptions.TokenValidationParameters.ValidIssuer,
                                           notBefore: creationDate,
                                           expires: DateTime.Now.AddMinutes(tokenOptions.Lifetime),
                                           claims: identity.Claims,
                                           signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        public RefreshToken GenerateRefreshJWTToken(User user)
        {
            var refreshToken = new RefreshToken()
            {
                UserId = user.Id,
                AddedDate = DateTime.UtcNow,
                IsUsed = false,
                ExpiryDate = DateTime.UtcNow.AddMonths(6),
                Token = RandomString(35) + Guid.NewGuid()
            };

            return refreshToken;
        }

        private ClaimsIdentity GetIdentity(User user) => identityService.GetIdentity(user);
        private string RandomString(int length)
        {
            var random = new Random();
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(characters, length).Select(x => x[random.Next(x.Length)]).ToArray());
        }

    }
}
