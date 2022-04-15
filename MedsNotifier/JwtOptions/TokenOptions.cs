using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedsNotifier.JwtOptions
{
    public class TokenOptions : ITokenOptions
    {
        private readonly TokenValidationParameters tokenValidationParameters;
        private const string SECURITY_KEY = "74yeuF878Ssf8945";
        public const int LIFETIME = 1;
        public TokenOptions()
        {
           tokenValidationParameters = new TokenValidationParameters
           {
               ValidateAudience = false,
               ValidateIssuer = false,
               ValidIssuer = "MedsNotifiier",
               ValidateLifetime = true,
               ValidateIssuerSigningKey = true,
               IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(SECURITY_KEY)),
               ClockSkew = TimeSpan.Zero,
           };
        }
        public TokenValidationParameters TokenValidationParameters => tokenValidationParameters;
        public int Lifetime => LIFETIME;
        public SymmetricSecurityKey GetSymmetricSecurityKey() => new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECURITY_KEY));

    }
}
