using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models.ViewModels
{
    public class ErrorViewModel
    {
        public IEnumerable<IdentityError> Errors { get; set; }
        public ErrorViewModel(IEnumerable<IdentityError> errors)
        {
            Errors = errors;
        }
    }
}
