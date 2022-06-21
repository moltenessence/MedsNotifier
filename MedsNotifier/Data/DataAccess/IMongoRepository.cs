using MedsNotifier.Data.Models;
using MedsNotifier.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedsNotifier.Data.DataAccess
{
    public interface IMongoRepository
    {
        Task<User> AuthenticateAsync(LoginViewModel model);
        Task ChangeRefreshTokenStateAsync(RefreshToken refreshToken);
        Task<Task> DeleteMedsFromUserChestAsync(User user, MedsModel meds);
        Task DeleteRefreshTokenAsync(RefreshToken refreshToken);
        Task<User> FindUserByEmailAsync(string email);
        Task<User> FindUserByIdAsync(Guid Id);
        Task<List<User>> GetAllUsersAsync();
        Task<RefreshToken> GetRefreshTokenAsync(string userId);
        Task InsertMedsAsync(MedsModel meds);
        Task<Task> InsertMedsToUserChestAsync(User user, MedsModel meds);
        Task InsertRefreshToken(RefreshToken refreshToken);
        Task InsertUserAsync(User user);
        Task UpdateMedsDataAsync(User user, MedsModel meds);
        Task UpdateUserDataAsync(User user);
        Task InsertEntryToUserDiaryAsync(User user, DiaryEntry entry);
        Task DeleteEntryFromUserDiaryAsync(User user, DiaryEntry entry);
    }
}