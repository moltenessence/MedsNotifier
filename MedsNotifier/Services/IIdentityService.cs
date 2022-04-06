using MedsNotifier.Data;
using System.Collections.Generic;
using System.Security.Claims;

namespace MedsNotifier.Services
{
    public interface IIdentityService
    {
        ClaimsIdentity GetIdentity(User user);
        IEnumerable<Claim> GetUserClaims(User user);
        void SetUserClaims(User user);
    }
}