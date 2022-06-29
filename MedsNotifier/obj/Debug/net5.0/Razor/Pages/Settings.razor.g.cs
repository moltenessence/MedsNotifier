#pragma checksum "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0fe54861b6aed46fd282f58524c86e005fcd53"
// <auto-generated/>
#pragma warning disable 1591
namespace MedsNotifier.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using MedsNotifier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\MedsNotifier\MedsNotifier\_Imports.razor"
using MedsNotifier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
using MedsNotifier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"page-title\">Account Settings</h2>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "basic-info");
#nullable restore
#line 40 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
     if (showDataUpdateMessage)
    { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p>The data was updated!</p>");
#nullable restore
#line 43 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\MedsNotifier\MedsNotifier\Pages\Settings.razor"
       

    protected ClaimsPrincipal user { get; set; }
    protected User User { get; set; }
    private bool showDataUpdateMessage = false;

    protected override async Task OnInitializedAsync()
    {
        var state = await AuthProvider.GetAuthenticationStateAsync();
        user = state.User;
    }

    protected override async Task OnParametersSetAsync()
    {
        if (user.Identity.IsAuthenticated)
        {
            User = await AccountService.GetUserAsync(user);
        }
    }

    private async Task HandleSubmit()
    {
        await AccountService.UpdateUserDataAsync(User);

        showDataUpdateMessage = true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdentityService IdentityService { get; set; }
    }
}
#pragma warning restore 1591
