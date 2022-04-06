using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models.ResultModels
{
    public class RegistrationResult
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
