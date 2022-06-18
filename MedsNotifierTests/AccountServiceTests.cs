
using MedsNotifier.Data;
using MedsNotifier.Data.DataAccess;
using MedsNotifier.Data.Models;
using MedsNotifier.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MedsNotifierTests
{
    public class AccountServiceTests
    {
        private readonly IAccountService accountService;
        private readonly Mock<IMongoRepository> mongoRepoMock = new Mock<IMongoRepository>();
        private readonly Mock<IIdentityService> identityServiceMock = new Mock<IIdentityService>();
        public AccountServiceTests()
        {
            accountService = new AccountService(mongoRepoMock.Object, identityServiceMock.Object);
        }

        [Fact]
        public async Task GetUserAsyncTest_ReturnsUser_ValidParameters()
        {
            string email = "testing@gmail.com";

            User expectedUser = new User()
            {
                Email = email,
                Age = 17,
                Gender = Gender.Male,
                Height = 180,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("mYPa$$w0rd", 10),
                Username = "test",
                Weight = 70,
                Meds = null
            };

            identityServiceMock.Setup(x => x.GetClaimValue(It.IsAny<ClaimsPrincipal>(), ClaimTypes.Email)).Returns(email);
            mongoRepoMock.Setup(x => x.FindUserByEmailAsync(email)).ReturnsAsync(expectedUser);

            var user = await accountService.GetUserAsync(It.IsAny<ClaimsPrincipal>());

            Assert.Equal(expectedUser.Id, user.Id);
        }


    }

}
