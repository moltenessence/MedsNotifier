using MedsNotifier.Data;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public interface IAccountService
    {
        Task<User> GetUserAsync(ClaimsPrincipal claimsPrincipal);
    }
}