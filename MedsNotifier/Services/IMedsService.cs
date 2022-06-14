using MedsNotifier.Data.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public interface IMedsService
    {
        Task AddMedsToUserChest(ClaimsPrincipal claimsPrincipal, MedsModel meds);
        Task<IList<MedsModel>> GetUserMedicineChest(ClaimsPrincipal claimsPrincipal);
        public int CountTotalDosage(MedsModel medication);
        public int GetCourseProgressProcentage(MedsModel medication);
        public int CountTotalAmountOfDoses(MedsModel medication);
        public int CountAmountOfDosesLeft(MedsModel medication);
        public Task TakeMeds(ClaimsPrincipal claimsPrincipal, MedsModel meds);
        public Task DeleteMedsAsync(ClaimsPrincipal claimsPrincipal, MedsModel meds);
    }
}
