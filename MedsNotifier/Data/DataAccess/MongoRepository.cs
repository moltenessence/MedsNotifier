using MedsNotifier.Data.CustomModelAttributes;
using MedsNotifier.Data.Models;
using MedsNotifier.Data.Models.ViewModels;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MedsNotifier.Data.DataAccess
{
    public class MongoRepository : IMongoRepository
    {
        private readonly IMongoDbSettings mongoDbSettings;

        public MongoRepository(IMongoDbSettings dbSettings)
        {
            mongoDbSettings = dbSettings;
        }
        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(typeof(BsonCollectionAttribute), true)
                                                         .FirstOrDefault())?.CollectionName;
        }
        private IMongoCollection<T> ConnectToMongo<T>()
        {
            var client = new MongoClient(mongoDbSettings.ConnectionString);

            return client.GetDatabase(mongoDbSettings.DatabaseName).GetCollection<T>(GetCollectionName(typeof(T)));
        }

        public async Task<User> AuthenticateAsync(LoginViewModel model)
        {
            var collection = ConnectToMongo<User>();

            var userFromQuery = await FindUserByEmailAsync(model.Email);

            bool checkPassword = false;

            if (userFromQuery != null)
            checkPassword = BCrypt.Net.BCrypt.Verify(model.Password, userFromQuery.PasswordHash);

            if (checkPassword) return userFromQuery;

            return null;
        }

        public async Task<User> FindUserByEmailAsync(string email)
        {
            var collection = ConnectToMongo<User>();
            var userFromQuery = await collection.FindAsync(u => u.Email == email).Result.FirstOrDefaultAsync();

            return userFromQuery;
        }
        public async Task<User> FindUserByIdAsync(Guid Id)
        {
            var collection = ConnectToMongo<User>();

            var userFromQuery = await collection.FindAsync(u => u.Id == Id).Result.FirstOrDefaultAsync();

            return userFromQuery;
        }
        public async Task<RefreshToken> GetRefreshTokenAsync(string userId)
        {
            var collection = ConnectToMongo<RefreshToken>();
            var refreshToken = await collection.FindAsync(t => t.UserId == userId).Result.FirstOrDefaultAsync();

            return refreshToken;
        }

        public async Task DeleteRefreshTokenAsync(RefreshToken refreshToken)
        {
            var collection = ConnectToMongo<RefreshToken>();

            await collection.DeleteOneAsync(t => t.Token == refreshToken.Token);
        }

        public Task ChangeRefreshTokenStateAsync(RefreshToken refreshToken)
        {
            var collection = ConnectToMongo<RefreshToken>();

            var filter = Builders<RefreshToken>.Filter.Where(t => t.Token == refreshToken.Token);
            var update = Builders<RefreshToken>.Update.Set(t => t.IsUsed, true);
            var options = new FindOneAndUpdateOptions<RefreshToken>();

            return Task.Run(() => collection.FindOneAndUpdate(filter, update, options));
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            var collection = ConnectToMongo<User>();

            var result = await collection.FindAsync(_ => true).Result.ToListAsync();

            return result;
        }

        public Task InsertUserAsync(User user)
        {
            var collection = ConnectToMongo<User>();

            return Task.Run(() => collection.InsertOneAsync(user));
        }

        
        public async Task InsertMedsToChestAsync(MedicineChest medicineChest, MedsModel meds)
        {
            var medicineChestCollection = ConnectToMongo<MedicineChest>();
            var medsCollection = ConnectToMongo<MedsModel>();

            await medsCollection.InsertOneAsync(meds);
            medicineChest.Meds.Add(meds);

            var filter = Builders<MedicineChest>.Filter.Eq("Id", medicineChest.Id);
            await medicineChestCollection.ReplaceOneAsync(filter, medicineChest, new ReplaceOptions { IsUpsert = true });
        }
        public Task UpdateUserDataAsync(User user)
        {
            var collection = ConnectToMongo<User>();
            var filter = Builders<User>.Filter.Eq("Id", user.Id);

            return Task.Run(() => collection.ReplaceOneAsync(filter, user, new ReplaceOptions { IsUpsert = true }));
        }
        public async Task DeleteMedsAsync(MedicineChest medicineChest, MedsModel meds)
        {
            var medsCollection = ConnectToMongo<MedicineChest>();
            if (!medicineChest.Meds.Contains(meds)) return;

            await medsCollection.DeleteOneAsync(m => m.Id == meds.Id);
        }

        public Task UpdateMedsDataAsync(MedicineChest medicineChest, MedsModel meds)
        {
            var collection = ConnectToMongo<MedicineChest>();
            var medsFromChest = medicineChest.Meds.FirstOrDefault(m => m.Id == meds.Id);

            var filter = Builders<MedicineChest>.Filter.Eq("Id", medsFromChest.Id == meds.Id);

            return Task.Run(() => collection.ReplaceOneAsync(filter, medicineChest, new ReplaceOptions { IsUpsert = true }));
        }
        public Task InsertMedsAsync(MedsModel meds)
        {
            var collection = ConnectToMongo<MedsModel>();

            return Task.Run(() => collection.InsertOneAsync(meds));
        }

        public Task InsertRefreshToken(RefreshToken refreshToken)
        {
            var collection = ConnectToMongo<RefreshToken>();

            return Task.Run(() => collection.InsertOneAsync(refreshToken));
        }
    }
}
