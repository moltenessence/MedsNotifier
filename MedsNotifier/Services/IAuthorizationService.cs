using MedsNotifier.Data.Models.ResultModels;
using MedsNotifier.Data.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MedsNotifier.Services
{
    public interface IAuthorizationService
    {
        Task<LoginResult> Authenticate(LoginViewModel loginViewModel);
        Task<RegistrationResult> Register(RegisterViewModel registerViewModel);
    }
}