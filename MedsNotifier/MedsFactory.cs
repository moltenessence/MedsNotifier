using MedsNotifier.Data.Models;
using MedsNotifier.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier
{
    public class MedsFactory : IMedsFactory
    {
        private readonly IMedsService medsService;
        public MedsFactory(IMedsService MedsService)
        {
            medsService = MedsService;
        }

        public MedsModel CreateMedicationFromForm(MedsModel medication) => new MedsModel()
        {
            Description = medication.Description,
            DosesPerDayAmount = medication.DosesPerDayAmount,
            SingleDosage = medication.SingleDosage,
            Name = medication.Name,
            MedsType = medication.MedsType,
            Color = medication.Color,
            TotalDosage = medsService.CountTotalDosage(medication),
            TotalAmountOfDoses = medsService.CountTotalAmountOfDoses(medication),
            AmountOfDosesLeft = medsService.CountTotalAmountOfDoses(medication),
            AmountOfDosesTakenToday = 0,
            FinishMedsDateTime = medication.FinishMedsDateTime,
            StartMedsDateTime = medication.StartMedsDateTime,
            LastTimeMedsTaken = new()
        };
    };

}

