using MedsNotifier.Data.Models;
using MedsNotifier.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedsNotifier.Data.DataAccess
{
    public interface IMongoRepository
    {
        Task ChangeRefreshTokenStateAsync(RefreshToken refreshToken);
        Task DeleteMedsAsync(MedicineChest medicineChest, MedsModel meds);
        Task<User> FindUserByEmailAsync(string email);
        Task<List<User>> GetAllUsersAsync();
        Task<RefreshToken> GetRefreshTokenAsync(string token);
        Task InsertMedsAsync(MedsModel meds);
        Task InsertMedsToChestAsync(MedicineChest medicineChest, MedsModel meds);
        Task InsertRefreshToken(RefreshToken refreshToken);
        Task InsertUserAsync(User user);
        Task UpdateMedsDataAsync(MedicineChest medicineChest, MedsModel meds);
        Task UpdateUserDataAsync(User user);
        Task DeleteRefreshTokenAsync(RefreshToken refreshToken);
        Task<User> FindUserByIdAsync(Guid Id);
        Task<User> AuthenticateAsync(LoginViewModel model);
    }
}