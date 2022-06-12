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
        private readonly MedsService medsService;
        private readonly Mock<IMongoRepository> mongoRepoMock = new Mock<IMongoRepository>();
        private readonly Mock<IAccountService> accountServiceMock = new Mock<IAccountService>();
        private readonly Mock<IAuthorizationService> authServiceMock = new Mock<IAuthorizationService>();
        public MedsServiceTests()
        {
            medsService = new MedsService(mongoRepoMock.Object, accountServiceMock.Object);
        }

       
    }
}
