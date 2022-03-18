using MedsNotifier.Data.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models.ResultModels
{
    public class UpdateTokenResult : UpdateTokenRequest
    {
        public bool Succeed { get; set; }
    }
}
