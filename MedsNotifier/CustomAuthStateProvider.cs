using MedsNotifier.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace MedsNotifier
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly LocalStorageService localStorageService;
        public CustomAuthStateProvider(LocalStorageService LocalStorageService)
        {
            localStorageService = LocalStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string token = await localStorageService.GetItem<string>("Authorization");
            ClaimsIdentity identity;

            if (token != null && token != String.Empty)
            {
                identity = new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt");
            }
            else identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
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
