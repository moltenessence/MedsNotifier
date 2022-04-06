using MedsNotifier.Data;
using MedsNotifier.Data.Models;
using MedsNotifier.Data.Models.RequestModels;
using MedsNotifier.Data.Models.ResultModels;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public interface IJWTService
    {
        bool CheckIfTokenExpired(string token);
        string GenerateJWTToken(User user);
        Task<UpdateTokenResult> GenerateNewTokenPairAsync(UpdateTokenRequest updateTokenRequest);
        RefreshToken GenerateRefreshJWTToken(User user);
    }
}