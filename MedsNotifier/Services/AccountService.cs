using MedsNotifier.Data;
using MedsNotifier.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public class AccountService : IAccountService
    {

        private readonly IMongoRepository mongoRepository;
        private readonly IIdentityService identityService;

        public AccountService(IMongoRepository MongoRepository, IIdentityService IdentityService)
        {
            mongoRepository = MongoRepository;
            identityService = IdentityService;
        }

        public async Task<User> GetUserAsync(ClaimsPrincipal claimsPrincipal)
        {
            var email = identityService.GetClaimValue(claimsPrincipal, ClaimTypes.Email);

            var user = await mongoRepository.FindUserByEmailAsync(email);
   
            return user;
        }
    }
}
