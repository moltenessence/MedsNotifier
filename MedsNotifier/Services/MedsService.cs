using MedsNotifier.Data;
using MedsNotifier.Data.Models;
using MedsNotifier.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace MedsNotifier.Services
{
    public class MedsService : IMedsService
    {
        private readonly IMongoRepository mongoRepository;
        private readonly IAccountService accountService;
        public MedsService(IMongoRepository MongoRepository, IAccountService AccountService)
        {
            mongoRepository = MongoRepository;
            accountService = AccountService;
        }
        public async Task<IEnumerable<MedsModel>> GetUserMedicineChest(ClaimsPrincipal claimsPrincipal)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);
            return user.Meds;
        }

        public async Task AddMedsToUserChest(ClaimsPrincipal claimsPrincipal, MedsModel meds)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);
            _ = await mongoRepository.InsertMedsToUserChestAsync(user, meds);
        }

        public double GetCourseProgressProcentage(MedsModel medication)
        {

            var totalTime = medication.FinishMedsDateTime.Ticks - medication.StartMedsDateTime.Ticks;


            return ((double)DateTime.Now.Ticks / (double)totalTime) * 100;
        }
    }
}
