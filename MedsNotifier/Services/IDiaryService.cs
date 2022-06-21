using MedsNotifier.Data.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public interface IDiaryService
    {
        Task AddDiaryEntryAsync(ClaimsPrincipal claimsPrincipal, DiaryEntry entry);
        Task DeleteDiaryEntryAsync(ClaimsPrincipal claimsPrincipal, DiaryEntry entry);
        Task<IList<DiaryEntry>> GetUserDiaryEntriesAsync(ClaimsPrincipal claimsPrincipal);
        Task<IList<DiaryEntry>> GetDiaryEntriesNotBeforeThisDateAsync(ClaimsPrincipal claimsPrincipal, DateTime notBeforeDate);
    }
}