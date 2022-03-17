using Microsoft.IdentityModel.Tokens;

namespace MedsNotifier.JwtOptions
{
    public interface ITokenOptions
    {
        TokenValidationParameters TokenValidationParameters { get; }
        public SymmetricSecurityKey GetSymmetricSecurityKey();
        int Lifetime { get; }
    }
}