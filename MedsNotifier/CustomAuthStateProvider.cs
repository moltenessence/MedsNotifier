using MedsNotifier.Data.DataAccess;
using MedsNotifier.Data.Models.RequestModels;
using MedsNotifier.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text.Json;
using System.Threading.Tasks;

namespace MedsNotifier
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly LocalStorageService localStorageService;
        private readonly IJWTService jWTService;
        private readonly IMongoRepository mongoRepository; 
        public CustomAuthStateProvider(LocalStorageService LocalStorageService, IJWTService JWTService, IMongoRepository MongoRepository)
        {
            localStorageService = LocalStorageService;
            jWTService = JWTService;
            mongoRepository = MongoRepository;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string header = await localStorageService.GetItem<string>("Authorization");

            ClaimsIdentity identity = new ClaimsIdentity();

            if (header != null && header != String.Empty)
            {
                var token = header.Replace("Bearer ", String.Empty);
               
                if (!jWTService.CheckIfTokenExpired(token)) identity = new ClaimsIdentity(ParseClaimsFromJwt(header), "jwt");
                else 
                {
                    var newPairResult = await jWTService.GenerateNewTokenPairAsync(new UpdateTokenRequest
                    {
                        Token = token,
                        UserId = GetUserid(new ClaimsIdentity(ParseClaimsFromJwt(header), "jwt"))
                    });

                    if(newPairResult.Succeed)
                    {
                        await mongoRepository.InsertRefreshToken(newPairResult.RefreshToken);
                        var newHeader = "Bearer " + newPairResult.Token;
                        await localStorageService.SetItem<string>("Authorization", newHeader);

                        identity = new ClaimsIdentity(ParseClaimsFromJwt(newHeader), "jwt");
                    }
                   
                } 
            }

            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }

       private string GetUserid(ClaimsIdentity claimsIdentity)
        {
            Claim claim = claimsIdentity?.FindFirst(ClaimTypes.NameIdentifier);

            return claim?.Value;
        }
        private IEnumerable<Claim> ParseClaimsFromJwt(string token)
        {
            var payload = token.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var pairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            return pairs.Select(p => new Claim(p.Key, p.Value.ToString()));
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch(base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            return Convert.FromBase64String(base64);
        }
    }
}
