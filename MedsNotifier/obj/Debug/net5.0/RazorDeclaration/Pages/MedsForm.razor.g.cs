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
#line 4 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using Smart.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/meds/add")]
    public partial class MedsForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
       
    private MedsModel medication = new();
    private string message;

    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public IMedsService MedsService { get; set; }
    [Inject]
    public AuthenticationStateProvider AuthProvider { get; set; }

    private async Task HandleSubmit()
    {
        medication.StartMedsDateTime = DateTime.Now;
        medication.TotalDosage = MedsService.CountTotalDosage(medication);
        medication.AmountOfDosesLeft = MedsService.CountTotalAmountOfDoses(medication);

        var state = await AuthProvider.GetAuthenticationStateAsync();
        var user = state.User;

        await MedsService.AddMedsToUserChest(user, medication);

        NavigationManager.NavigateTo("meds", true);
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (!firstRender) message = "";
    }

    private void OnColorChange(Event ev)
    {
        ColorPickerChangeEventDetail detail = ev["Detail"];
        medication.Color = detail.Value;
    }
    private void OnCalendarChange(Event ev)
    {
        CalendarChangeEventDetail eventCallback = ev["Detail"];
        var dates = eventCallback.Value;

        var selectedDate = dates.ToList().FirstOrDefault();

        DateTime finishMedsDayTime;
        DateTime.TryParse(selectedDate, out finishMedsDayTime);
        medication.FinishMedsDateTime = finishMedsDayTime;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
