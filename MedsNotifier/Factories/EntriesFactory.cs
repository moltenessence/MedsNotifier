﻿using MedsNotifier.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Factories
{
    public class EntriesFactory : IEntriesFactory
    {
        public DiaryEntry CreateDiaryEntry(MedsModel meds) => new DiaryEntry()
        {
            Id = Guid.NewGuid(),
            MedicineName = meds.Name,
            DateMedicineTaken = meds.LastTimeMedsTaken
        };
    }
}
