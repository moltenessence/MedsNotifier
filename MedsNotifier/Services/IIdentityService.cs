using MedsNotifier.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public interface IIdentityService
    {
        ClaimsIdentity GetIdentity(User user);
        public string GetClaimValue(ClaimsPrincipal user, string claimType);
    }
}
