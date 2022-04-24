using MedsNotifier.Data.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public interface IMedsService
    {
        Task AddMedsToUserChest(ClaimsPrincipal claimsPrincipal, MedsModel meds);
        Task<IEnumerable<MedsModel>> GetUserMedicineChest(ClaimsPrincipal claimsPrincipal);
        public int CountTotalDosage(MedsModel medication);
        public double GetCourseProgressProcentage(MedsModel medication);
    }
}