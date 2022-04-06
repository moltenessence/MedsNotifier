using MedsNotifier.Data;
using MedsNotifier.Data.CustomModelAttributes;
using MedsNotifier.Data.DataAccess;
using MedsNotifier.Data.Models.ResultModels;
using MedsNotifier.Data.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IIdentityService identityService;
        private readonly ILogger<JWTService> logger;
        private readonly IMongoRepository mongoRepository;
        private readonly IJWTService jWTService;
        private readonly IHttpContextAccessor context;

        public AuthorizationService(IIdentityService IdentityService, ILogger<JWTService> Logger, IMongoRepository MongoRepository, IJWTService JWTService, IHttpContextAccessor HttpContext)
        {
            identityService = IdentityService;
            logger = Logger;
            mongoRepository = MongoRepository;
            jWTService = JWTService;
            context = HttpContext;
        }

        public async Task<LoginResult> Authenticate(LoginViewModel loginViewModel)
        {
            var user = await mongoRepository.AuthenticateAsync(loginViewModel);

            try
            {
                if (user != null)
                {
                    var token = jWTService.GenerateJWTToken(user);

                    //context.HttpContext.Response.Headers.Add("Authorization", $"Bearer +{token}");
                    return new LoginResult
                    {
                        Email = user.Email,
                        Token = token,
                        RefreshToken = jWTService.GenerateRefreshJWTToken(user),
                        Succeeded = true,
                        Message = "The user signed in!"
                    };
                }
            }
            catch(Exception ex)
            {

                logger.LogInformation($"Something went wrong:{ex.Message}");
            }

            return new LoginResult
            {
                Succeeded = false,
                Message = "The login or password are incorrect."
            };
        }
        public async Task<RegistrationResult> Register(RegisterViewModel registerViewModel)
        {
            try
            {
                var user = new User
                {
                    Age = registerViewModel.Age,
                    //PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerViewModel.Password),
                    PasswordHash = registerViewModel.Password,
                    Email = registerViewModel.Email,
                    Weight = registerViewModel.Weight,
                    Height = registerViewModel.Height,
                    Username = registerViewModel.Username
                };

                var token = jWTService.GenerateJWTToken(user);
                var refreshToken = jWTService.GenerateRefreshJWTToken(user);

                await mongoRepository.InsertUserAsync(user);
                await mongoRepository.InsertRefreshToken(refreshToken);

                context.HttpContext.Response.Headers.Add("Authorization", $"Bearer +{token}");

                return new RegistrationResult
                {
                    Succeeded = true,
                    Message = $"Thank you, {user.Username}. You have created account!"
                };
            }
            catch (Exception ex)
            {
                logger.LogInformation($"Something went wrong:{ex.Message}");
                return new RegistrationResult
                {
                    Succeeded = false,
                    Message = "Oops...Something went wrong..."
                };
            }

        }
    }
}
