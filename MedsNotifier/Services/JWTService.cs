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
    public class JWTService
    {
		private readonly ITokenOptions tokenOptions;
        private readonly IdentityService identityService;
        private readonly ILogger<JWTService> logger;
        private readonly IMongoRepository mongoRepository;
        public JWTService(ITokenOptions TokenOptions, IdentityService IdentityService, ILogger<JWTService> Logger, IMongoRepository MongoRepostitory)
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
                UserId = user.Id,
                AddedDate = DateTime.Now,
                IsUsed = false,
                ExpiryDate = DateTime.UtcNow.AddMonths(6),
                Token = RandomString(35) + Guid.NewGuid()
            };

            return refreshToken;
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
                return new TokenValidationResult { IsValid = false};
            }

            catch (Exception ex)
            {
                logger.LogInformation($"Something went wrong : {ex.Message}");

                return new TokenValidationResult { IsValid = false, Exception = ex};
            }
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
            catch(Exception ex)
            {
                logger.LogInformation($"Something went wrong : {ex.Message}");
                return false;
            }
        }
        public async Task<UpdateTokenResult> GetNewTokenPairAsync(UpdateTokenRequest updateTokenRequest)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenValidationResult = ValidateToken(updateTokenRequest.Token);

                var storedToken = await mongoRepository.GetRefreshTokenAsync(updateTokenRequest.RefreshToken.Token);

                if (storedToken == null) return new UpdateTokenResult { Succeed = false };

                if (storedToken.ExpiryDate < DateTime.Now || storedToken.IsUsed)
                {
                    await mongoRepository.DeleteRefreshTokenAsync(updateTokenRequest.RefreshToken);
                    return new UpdateTokenResult { Succeed = false };
                }

                storedToken.IsUsed = true;
                await mongoRepository.ChangeRefreshTokenStateAsync(updateTokenRequest.RefreshToken);

                var user = await mongoRepository.FindUserByIdAsync(storedToken.UserId);
                var token = GenerateJWTToken(user);

                return new UpdateTokenResult
                {
                    Succeed = true,
                    Token = token,
                    RefreshToken = GenerateRefreshJWTToken(user)
                };

            }
            catch (Exception ex)
            {
                return new UpdateTokenResult { Succeed = false };
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
