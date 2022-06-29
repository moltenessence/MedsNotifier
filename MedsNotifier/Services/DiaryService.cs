using MedsNotifier.Data.DataAccess;
using MedsNotifier.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public class DiaryService : IDiaryService
    {

        private readonly IMongoRepository mongoRepository;
        private readonly IAccountService accountService;
        public DiaryService(IMongoRepository MongoRepository, IAccountService AccountService)
        {
            mongoRepository = MongoRepository;
            accountService = AccountService;
        }
        public async Task<IList<DiaryEntry>> GetUserDiaryEntriesAsync(ClaimsPrincipal claimsPrincipal)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);

            return user != null ? user.Entries : null;
        }

        public async Task<IList<DiaryEntry>> GetDiaryEntriesNotBeforeThisDateAsync(ClaimsPrincipal claimsPrincipal, DateTime notBeforeDate)
        {
            var allEntries = await GetUserDiaryEntriesAsync(claimsPrincipal);

            var result = allEntries.Where(e => e.DateMedicineTaken >= notBeforeDate).ToList();

            return result;
        }

        public async Task AddDiaryEntryAsync(ClaimsPrincipal claimsPrincipal, DiaryEntry entry)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);

            await mongoRepository.InsertEntryToUserDiaryAsync(user, entry);
        }
        public async Task DeleteDiaryEntryAsync(ClaimsPrincipal claimsPrincipal, DiaryEntry entry)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);

            await mongoRepository.DeleteEntryFromUserDiaryAsync(user, entry);
        }
        public DiaryEntry CreateDiaryEntry(MedsModel meds) => new DiaryEntry()
        {
            Id = Guid.NewGuid(),
            MedicineName = meds.Name,
            DateMedicineTaken = meds.LastTimeMedsTaken
        };
    }
}
