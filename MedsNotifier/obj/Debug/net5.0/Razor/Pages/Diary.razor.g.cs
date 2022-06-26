#pragma checksum "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2513cbd2962f6cd8c4cc0db31d7e7b792680b124"
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
#line 1 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/diary")]
    public partial class Diary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"page-title\">Diary</h2>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "basic-info");
#nullable restore
#line 10 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
     if (EntriesList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p class=\"empty-diary\">You haven\'t taken any meds yet</p>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "class", "submit-button");
            __builder.AddAttribute(6, "href", "meds");
            __builder.AddAttribute(7, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, " Click there to check out your courses!");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 14 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Medicine Name</th>\r\n                    <th>DateTime</th>\r\n                    <th>Delete</th></tr></thead>\r\n            ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 26 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
                 foreach (var entry in EntriesList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
                             entry.MedicineName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
                             entry.DateMedicineTaken.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "delete-icon");
            __builder.OpenElement(23, "ion-icon");
            __builder.AddAttribute(24, "name", "trash-outline");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
                                                                                                () => OnDeleteEntry(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\MedsNotifier\MedsNotifier\Pages\Diary.razor"
       

    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public IDiaryService DiaryService { get; set; }
    [Inject]
    public AuthenticationStateProvider AuthProvider { get; set; }

    [Parameter]
    public IEnumerable<DiaryEntry> EntriesList { get; set; }
    protected ClaimsPrincipal user { get; set; }


    protected override async Task OnInitializedAsync()
    {
        var state = await AuthProvider.GetAuthenticationStateAsync();
        user = state.User;
    }

    protected override async Task OnParametersSetAsync()
    {
        
        if (user.Identity.IsAuthenticated) EntriesList = await DiaryService.GetUserDiaryEntriesAsync(user);
    }

    protected async Task OnDeleteEntry(DiaryEntry entry)
    {
        var success = EntriesList.ToList().RemoveAll(e=>e.Id == entry.Id);

        if(success>0)  await DiaryService.DeleteDiaryEntryAsync(user, entry);

        //await InvokeAsync(() => StateHasChanged());
        NavigationManager.NavigateTo("/diary", true);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
