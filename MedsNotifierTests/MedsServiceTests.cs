using MedsNotifier.Data;
using MedsNotifier.Data.DataAccess;
using MedsNotifier.Data.Models;
using MedsNotifier.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Moq;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Xunit;

namespace MedsNotifierTests
{
    public class MedsServiceTests
    {
        private readonly IMedsService medsService;
        private readonly Mock<IMongoRepository> mongoRepoMock = new Mock<IMongoRepository>();
        private readonly Mock<IAccountService> accountServiceMock = new Mock<IAccountService>();
        private readonly Mock<IMedsService> medsServiceMock = new Mock<IMedsService>();

        public MedsServiceTests()
        {
            medsService = new MedsService(mongoRepoMock.Object, accountServiceMock.Object);
        }

        [Fact]
        public void GetCourseProgressProcentage_ValidAccounting_ValidParameters()
        {
            MedsModel medication = new MedsModel() {
                SingleDosage = 5,
                StartMedsDateTime = new DateTime(2022, 6, 10),
                FinishMedsDateTime = DateTime.Now.AddDays(3),
                Description = "",
                DosesPerDayAmount = 2,
                Color = "",
                MedsType = MedsType.Hormonal,
                Name = "Probio",
            };

            medication.TotalDosage = medsService.CountTotalDosage(medication);

            var totalAmount = medsService.CountTotalAmountOfDoses(medication);
            medication.AmountOfDosesLeft = totalAmount/2;

            int expectedResult = 50;
            int result = medsService.GetCourseProgressProcentage(medication);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public async Task TakeMeds_TheAmountOfDosesLeftDecrements_ValidParameters()
        {
            var amountOfDosesLeftExpected = 9;

            var user = new User() { 
                Email="testing@gmail.com",
                Age = 17,
                Gender = Gender.Male,
                Height = 180,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("mYPa$$w0rd", 10),
                Username = "test",
                Weight = 70,
                Meds = new List<MedsModel>()
            };

            MedsModel medication = new MedsModel()
            {
                SingleDosage = 5,
                StartMedsDateTime = new DateTime(2022, 6, 10),
                FinishMedsDateTime = DateTime.Now.AddDays(3),
                Description = "",
                DosesPerDayAmount = 2,
                Color = "",
                MedsType = MedsType.Hormonal,
                Name = "Probio",
            };

            user.Meds.Add(medication);

            medication.TotalDosage = medsService.CountTotalDosage(medication);
            medication.AmountOfDosesLeft = 10;

            accountServiceMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

            await medsService.TakeMeds(It.IsAny<ClaimsPrincipal>(), medication);

            mongoRepoMock.Verify(x => x.UpdateMedsDataAsync(user,It.Is<MedsModel>(m=>m.AmountOfDosesLeft == amountOfDosesLeftExpected)));
        }

        [Fact]
        public async Task GetUserMedicineChestAsync_ValidParameters()
        {
            var expectedMedsChest = new List<MedsModel>() { new MedsModel()
            {
                SingleDosage = 5,
                StartMedsDateTime = new DateTime(2022, 6, 10),
                FinishMedsDateTime = DateTime.Now.AddDays(3),
                Description = "",
                DosesPerDayAmount = 2,
                Color = "",
                MedsType = MedsType.Hormonal,
                Name = "Probio",
            } };

            var user = new User()
            {
                Email = "testing@gmail.com",
                Age = 17,
                Gender = Gender.Male,
                Height = 180,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("mYPa$$w0rd", 10),
                Username = "test",
                Weight = 70,
                Meds = expectedMedsChest
            };

            accountServiceMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

            var medsChest = await medsService.GetUserMedicineChest(It.IsAny<ClaimsPrincipal>());

            Assert.Equal(expectedMedsChest[0].Name, medsChest[0].Name);
        }

        [Fact]
        public async Task GetUserMedicineChestAsync_UserIsNull()
        {
            User user = null;

            accountServiceMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
            var medsChest = await medsService.GetUserMedicineChest(It.IsAny<ClaimsPrincipal>());

            Assert.Null(medsChest);
        }

        [Fact]
        public async Task GetUserMedicineChestAsync_MedsChestIsEmpty()
        {
            var expectedMedsChest = new List<MedsModel>() { };

            var user = new User()
            {
                Email = "testing@gmail.com",
                Age = 17,
                Gender = Gender.Male,
                Height = 180,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("mYPa$$w0rd", 10),
                Username = "test",
                Weight = 70,
                Meds = expectedMedsChest
            };

            accountServiceMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
            var medsChest = await medsService.GetUserMedicineChest(It.IsAny<ClaimsPrincipal>());

            Assert.NotNull(medsChest);
        }
        [Fact]
        public async Task DeleteMedsAsync()
        {
            var deletedMeds = new MedsModel()
            {
                SingleDosage = 5,
                StartMedsDateTime = new DateTime(2022, 6, 10),
                FinishMedsDateTime = DateTime.Now.AddDays(3),
                Description = "",
                DosesPerDayAmount = 2,
                Color = "",
                MedsType = MedsType.Hormonal,
                Name = "Probio",
            };

            var MedsChest = new List<MedsModel>() {deletedMeds};
            var expectedMedsChest = new List<MedsModel>();

            var user = new User()
            {
                Email = "testing@gmail.com",
                Age = 17,
                Gender = Gender.Male,
                Height = 180,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("mYPa$$w0rd", 10),
                Username = "test",
                Weight = 70,
                Meds = expectedMedsChest
            };

            accountServiceMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
            await medsService.DeleteMedsAsync(It.IsAny<ClaimsPrincipal>(), deletedMeds);

            var updatedMedsChest = await medsService.GetUserMedicineChest(It.IsAny<ClaimsPrincipal>());

            Assert.DoesNotContain(deletedMeds, updatedMedsChest);
        }
    }
           
}

