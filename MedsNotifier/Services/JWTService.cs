using MedsNotifier.Data;
using MedsNotifier.Data.Models;
using MedsNotifier.Data.Models.RequestModels;
using MedsNotifier.Data.Models.ResultModels;
using MedsNotifier.JwtOptions;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MedsNotifier.Data.DataAccess;

namespace MedsNotifier.Services
{
    public class JWTService : IJWTService
    {
        private readonly ITokenOptions tokenOptions;
        private readonly IIdentityService identityService;
        private readonly ILogger<JWTService> logger;
        private readonly IMongoRepository mongoRepository;
        public JWTService(ITokenOptions TokenOptions, IIdentityService IdentityService, ILogger<JWTService> Logger, IMongoRepository MongoRepostitory)
        {
            tokenOptions = TokenOptions;
            identityService = IdentityService;
            logger = Logger;
            mongoRepository = MongoRepostitory;
        }
        public string GenerateJWTToken(User user)
        {
            var identity = GetIdentity(user);

            var creationDate = DateTime.UtcNow;
            var securityKey = tokenOptions.GetSymmetricSecurityKey();
            var jwt = new JwtSecurityToken(issuer: tokenOptions.TokenValidationParameters.ValidIssuer,
                                           notBefore: creationDate,
                                           expires: DateTime.Now.AddMinutes(tokenOptions.Lifetime),
                                           claims: identity.Claims,
                                           signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }


        public RefreshToken GenerateRefreshJWTToken(User user)
        {
            var refreshToken = new RefreshToken()
            {
                UserId = user.Id.ToString(),
                AddedDate = DateTime.Now,
                IsUsed = false,
                ExpiryDate = DateTime.UtcNow.AddMonths(6),
                Token = RandomString(35) + Guid.NewGuid()
            };

            return refreshToken;
        }
        public bool CheckIfTokenExpired(string token)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenInVerification = jwtTokenHandler.ValidateToken(token, tokenOptions.TokenValidationParameters, out var validatedToken);

                var utcExpiryDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
                var expiryDate = UnixTimeStampToDateTime(utcExpiryDate);

                if (expiryDate <= DateTime.UtcNow) return true;

                return false;
            }
            catch (Exception ex)
            {
                logger.LogInformation($"{ex.Message}");
                return true;
            }

        }
        public async Task<UpdateTokenResult> GenerateNewTokenPairAsync(UpdateTokenRequest updateTokenRequest)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenValidationResult = ValidateToken(updateTokenRequest.Token);

                var storedToken = await mongoRepository.GetRefreshTokenAsync(updateTokenRequest.UserId);
                if(storedToken.ExpiryDate < DateTime.UtcNow)
                {
                    logger.LogInformation($"The refresh token {storedToken.UserId}:{storedToken.Token} is expired. It will be deleted");
                    await mongoRepository.DeleteRefreshTokenAsync(storedToken);

                    return new UpdateTokenResult { Succeed = false };
                }

                if (storedToken.IsUsed)
                {
                    logger.LogInformation($"The refresh token {storedToken.UserId}:{storedToken.Token} has already been used. It will be deleted");
                    await mongoRepository.DeleteRefreshTokenAsync(storedToken);

                    return new UpdateTokenResult { Succeed = false };
                }

                storedToken.IsUsed = true;
                await mongoRepository.ChangeRefreshTokenStateAsync(storedToken);

                var user = await mongoRepository.FindUserByIdAsync(Guid.Parse(storedToken.UserId));

                var token = GenerateJWTToken(user);
                var refreshToken = GenerateRefreshJWTToken(user);

                return new UpdateTokenResult
                {
                    Succeed = true,
                    Token = token,
                    RefreshToken = refreshToken
                };

            }
            catch(NullReferenceException)
            {

                logger.LogInformation($"The refresh token doesn't exist");
                return new UpdateTokenResult { Succeed = false };
            }
            catch (Exception ex)
            {
                logger.LogInformation($"Something went wrong:{ex.Message}");
                return new UpdateTokenResult { Succeed = false };
            }
        }
        private TokenValidationResult ValidateToken(string token)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenInVerification = jwtTokenHandler.ValidateToken(token, tokenOptions.TokenValidationParameters, out var validatedToken);
                if (validatedToken is JwtSecurityToken jwtSecurityToken) return new TokenValidationResult
                {
                    IsValid = true,
                    SecurityToken = validatedToken,
                    TokenType = "Bearer"
                };
                return new TokenValidationResult { IsValid = false };
            }

            catch (Exception ex)
            {
                logger.LogInformation($"Token isn't valid : {ex.Message}");

                return new TokenValidationResult { IsValid = false, Exception = ex };
            }
        }
        private ClaimsIdentity GetIdentity(User user) => identityService.GetIdentity(user);
        private string RandomString(int length)
        {
            var random = new Random();
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(characters, length).Select(x => x[random.Next(x.Length)]).ToArray());
        }
        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            var dateTimeVal = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(unixTimeStamp).ToUniversalTime();

            return dateTimeVal;
        }

    }
}
