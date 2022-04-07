// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MedsNotifier.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using MedsNotifier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\_Imports.razor"
using MedsNotifier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Login.razor"
using MedsNotifier.Data.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Login.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Login.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Login.razor"
           
        private LoginViewModel loginModel = new();
        private string message;
        private string token = "Bearer ";

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public LocalStorageService LocalStorageService { get; set; }

        private async Task HandleSubmit()
        {
            var result = await AuthorizationService.Authenticate(loginModel);

            if (!result.Succeeded) { message = result.Message; }
            else
            {
                token += result.Token;
                await LocalStorageService.SetItem<string>("Authorization",token);
                NavigationManager.NavigateTo("home", true);
            }
        }
        //public override
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MedsNotifier.Services.IAuthorizationService AuthorizationService { get; set; }
    }
}
#pragma warning restore 1591
