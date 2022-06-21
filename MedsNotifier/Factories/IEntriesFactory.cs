using MedsNotifier.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Factories
{
    interface IEntriesFactory
    {
        public DiaryEntry CreateDiaryEntry(MedsModel meds);
    }
}
