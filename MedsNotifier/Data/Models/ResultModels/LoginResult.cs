using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models.ResultModels
{
    public class LoginResult : RegistrationResult
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
}
