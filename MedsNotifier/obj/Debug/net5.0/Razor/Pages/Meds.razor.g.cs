#pragma checksum "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cef693e758ddc618a60286dc6f3b8e511c43faa"
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
#line 1 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/meds")]
    public partial class Meds : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"page-title\">Meds</h2>");
#nullable restore
#line 10 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
 if (confirmBoxOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MedsNotifier.Pages.ConfirmRemovalBox>(1);
            __builder.AddAttribute(2, "ConfrimCallback", (System.Func<System.Boolean, System.Threading.Tasks.Task>)(
#nullable restore
#line 12 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                        async (flag) => await OnConfirmRemoval(flag)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 13 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "meds-page-wrapper");
#nullable restore
#line 16 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
     if (MedsList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p class=\"empty-meds\">You haven\'t started any courses yet.</p>");
#nullable restore
#line 19 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
    }

    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "meds-info");
#nullable restore
#line 24 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
             foreach (var medication in MedsList)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "meds-block-info");
            __builder.OpenElement(10, "ul");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "color", 
#nullable restore
#line 29 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                    medication.Color

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "class", "meds-title-" + (
#nullable restore
#line 29 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                         medication.Id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, " Title: ");
#nullable restore
#line 29 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(15, medication.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "meds-type");
            __builder.AddContent(19, "Type: ");
#nullable restore
#line 30 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(20, medication.MedsType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "meds-text-info");
            __builder.AddContent(24, " Description: ");
#nullable restore
#line 31 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(25, medication.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "meds-text-info");
            __builder.AddContent(29, " Doses Left: ");
#nullable restore
#line 32 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(30, medication.AmountOfDosesLeft);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "meds-text-info");
            __builder.AddContent(34, "Start: ");
#nullable restore
#line 33 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(35, medication.StartMedsDateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "meds-text-info");
            __builder.AddContent(39, "Finish: ");
#nullable restore
#line 34 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(40, medication.FinishMedsDateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "li");
            __builder.AddAttribute(43, "class", "info-message");
#nullable restore
#line 35 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(44, medication?.InfoMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "wrap-circles");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "circle" + " per-" + (
#nullable restore
#line 38 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                GetPercent(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "inner");
#nullable restore
#line 39 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(52, GetPercent(medication));

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "ul");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "meds-additional-text-info");
            __builder.AddContent(58, " Last time you took meds: ");
#nullable restore
#line 43 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(59, medication.LastTimeMedsTaken.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "li");
            __builder.AddAttribute(62, "class", "meds-additional-text-info");
            __builder.AddContent(63, "Daily amount of doses: ");
#nullable restore
#line 44 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(64, medication.DosesPerDayAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "li");
            __builder.AddAttribute(67, "class", "meds-additional-text-info");
            __builder.AddContent(68, "Single Dosage: ");
#nullable restore
#line 45 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(69, medication.SingleDosage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "class", "meds-additional-text-info");
            __builder.AddContent(73, "Total Dosage: ");
#nullable restore
#line 46 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(74, medication.TotalDosage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "class", "meds-submit-button");
            __builder.AddAttribute(78, "type", "submit");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                   () => OnTakeMeds(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "Take meds!");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "class", "meds-delete-button");
            __builder.AddAttribute(84, "type", "submit");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                   () => { medsToDelete = medication; confirmBoxOpen = true;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Delete course");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(87, "style");
            __builder.AddMarkupContent(88, "\r\n        .circle.per-");
#nullable restore
#line 54 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(89, GetPercent(medication));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "\r\n        {\r\n            background-image: conic-gradient(aquamarine ");
#nullable restore
#line 56 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(91, GetPercent(medication));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(92, "%, #b0b0b0 0);\r\n        }\r\n        .meds-page-wrapper .meds-info .meds-block-info .meds-title-");
#nullable restore
#line 58 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(93, medication.Id.ToString());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, " {\r\n            font-style: italic;\r\n            font-size: 30px;\r\n            margin-bottom: 5px;\r\n            color: ");
#nullable restore
#line 62 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
__builder.AddContent(95, medication.Color);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, ";\r\n        }\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 65 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 68 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(97);
            __builder.AddAttribute(98, "class", "submit-button");
            __builder.AddAttribute(99, "href", "meds/add");
            __builder.AddAttribute(100, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 69 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(102, " Press here to start new course!");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
       
    [Inject]
    NavigationManager NavigationManager { get; set; }
    [Inject]
    public IDiaryService DiaryService { get; set; }
    [Inject]
    public IMedsService MedsService { get; set; }
    [Inject]
    public AuthenticationStateProvider AuthProvider { get; set; }

    [Parameter]
    public IEnumerable<MedsModel> MedsList { get; set; }

    protected ClaimsPrincipal user { get; set; }
    protected DateTime lastTimeMedsTaken { get; set; }
    private bool confirmBoxOpen = false;
    private bool confirm = false;
    protected MedsModel medsToDelete { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var state = await AuthProvider.GetAuthenticationStateAsync();
        user = state.User;
    }

    protected override async Task OnParametersSetAsync()
    {
        if (user.Identity.IsAuthenticated) MedsList = await MedsService.GetUserMedicineChest(user);
    }

    protected string GetPercent(MedsModel meds) => MedsService.GetCourseProgressProcentage(meds).ToString();


    protected async Task OnDeleteMeds(MedsModel meds)
    {
        await MedsService.DeleteMedsAsync(user, meds);
        NavigationManager.NavigateTo("/meds", true);
    }

    protected async Task OnTakeMeds(MedsModel meds)
    {
        if (meds.AmountOfDosesLeft == 0)
        {
            meds.InfoMessage = "You have finished this course. You can delete it if you don't wanna track it anymore!";
            return;
        }

        await MedsService.TakeMeds(user, meds);
        meds.AmountOfDosesLeft -= 1;
        meds.LastTimeMedsTaken = DateTime.Now;

        await DiaryService.AddDiaryEntryAsync(user, DiaryService.CreateDiaryEntry(meds));
    }

    protected async Task OnConfirmRemoval(bool flag)
    {
        confirm = flag;
        StateHasChanged();

        if(confirm) await OnDeleteMeds(medsToDelete);

        confirmBoxOpen = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
