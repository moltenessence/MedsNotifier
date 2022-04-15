using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models.RequestModels
{
    public class UpdateTokenRequest
    {
        public string UserId { get; set; }
        public string Token { get; set; }
    }
}
