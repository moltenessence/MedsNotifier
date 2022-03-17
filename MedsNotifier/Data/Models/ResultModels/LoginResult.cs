using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models.ResultModels
{
    public class LoginResult
    {
        public string Message { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public bool Succeeded { get; set; }
    }
}
