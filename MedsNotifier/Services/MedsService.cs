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
        public async Task<IList<MedsModel>> GetUserMedicineChest(ClaimsPrincipal claimsPrincipal)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);

            return  user!=null ? user.Meds : null;
        }

        public async Task AddMedsToUserChest(ClaimsPrincipal claimsPrincipal, MedsModel meds)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);
            _ = await mongoRepository.InsertMedsToUserChestAsync(user, meds);
        }

        public async Task DeleteMedsAsync(ClaimsPrincipal claimsPrincipal, MedsModel meds)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);

            await mongoRepository.DeleteMedsFromUserChestAsync(user, meds);
        }

        public int GetCourseProgressProcentage(MedsModel medication) {

            var totalAmount = medication.TotalAmountOfDoses;
            var amountLeft = (double)CountAmountOfDosesLeft(medication);
             
            var result = ((totalAmount - amountLeft) / totalAmount) * 100;

            return (int)result;
        
        }

        public async Task TakeMeds(ClaimsPrincipal claimsPrincipal, MedsModel meds)
        {
            var user = await accountService.GetUserAsync(claimsPrincipal);
            var currentMeds = user.Meds.FirstOrDefault(m => m.Id == meds.Id);

            if (currentMeds != null && currentMeds.AmountOfDosesLeft > 0)
            {
                currentMeds.AmountOfDosesLeft -= 1;

                currentMeds.LastTimeMedsTaken = DateTime.Now;

                await mongoRepository.UpdateMedsDataAsync(user, currentMeds);
            }
        }

        public MedsModel CreateMedicationFromForm(MedsModel medication) => new MedsModel()
        {
            Description = medication.Description,
            DosesPerDayAmount = medication.DosesPerDayAmount,
            SingleDosage = medication.SingleDosage,
            Name = medication.Name,
            MedsType = medication.MedsType,
            Color = medication.Color,
            TotalDosage = CountTotalDosage(medication),
            TotalAmountOfDoses = CountTotalAmountOfDoses(medication),
            AmountOfDosesLeft = CountTotalAmountOfDoses(medication),
            FinishMedsDateTime = medication.FinishMedsDateTime,
            StartMedsDateTime = medication.StartMedsDateTime,
            LastTimeMedsTaken = new()
        };

        private int CountCourseDaysAmount(MedsModel medication) => medication.FinishMedsDateTime.DayOfYear - medication.StartMedsDateTime.DayOfYear;
        private int CountCourseDaysAmountLeft(MedsModel medication) => medication.FinishMedsDateTime.DayOfYear - DateTime.Now.DayOfYear;
        public int CountTotalDosage(MedsModel medication) => (medication.DosesPerDayAmount * medication.SingleDosage) * CountCourseDaysAmount(medication);
        public int CountTotalAmountOfDoses(MedsModel medication) => medication.DosesPerDayAmount * CountCourseDaysAmount(medication);
        public int CountAmountOfDosesLeft(MedsModel medication) => medication.AmountOfDosesLeft;
    }
}
