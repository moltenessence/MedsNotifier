#pragma checksum "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541b719bd95992e22f68251441320300cd148bb5"
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
#line 1 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
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
            __builder.AddMarkupContent(0, "<h2 class=\"page-title\">Meds</h2>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "meds-page-wrapper");
#nullable restore
#line 12 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
     if (MedsList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"empty-list\"><img min-height=\"400\" min-width=\"380\" src=\"https://sun9-6.userapi.com/s/v1/ig2/Lv_1ccUqPtCfwqFSvYCOLOURQw-pOzUmIZ7kafQGsgu2LScy9ojGuFQjqGvDz1oDUM8W_vAti-dInm0AAnWm74Az.jpg?size=800x600&quality=96&type=album\" alt></div>");
#nullable restore
#line 17 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
    }

    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "meds-info");
#nullable restore
#line 22 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
     foreach (var medication in MedsList)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "meds-block-info");
            __builder.OpenElement(8, "ul");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "color", 
#nullable restore
#line 27 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                            medication.Color

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "class", "meds-name");
            __builder.AddContent(12, " Title: ");
            __builder.AddContent(13, 
#nullable restore
#line 27 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                         medication.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "meds-type");
            __builder.AddContent(17, "Type: ");
            __builder.AddContent(18, 
#nullable restore
#line 28 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                             medication.MedsType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "meds-text-info");
            __builder.AddContent(22, " Description: ");
            __builder.AddContent(23, 
#nullable restore
#line 29 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                          medication.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "meds-text-info");
            __builder.AddContent(27, " Doses Left: ");
            __builder.AddContent(28, 
#nullable restore
#line 30 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                         medication.AmountOfDosesLeft

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "meds-text-info");
            __builder.AddContent(32, "Start: ");
            __builder.AddContent(33, 
#nullable restore
#line 31 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                   medication.StartMedsDateTime.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "meds-text-info");
            __builder.AddContent(37, "Finish: ");
            __builder.AddContent(38, 
#nullable restore
#line 32 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                    medication.FinishMedsDateTime.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "wrap-circles");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "circle" + " per-" + (
#nullable restore
#line 35 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                        GetPercent(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "inner");
            __builder.AddContent(46, 
#nullable restore
#line 36 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                        GetPercent(medication)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(47, "%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "ul");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "meds-additional-text-info");
            __builder.AddContent(52, " Last time you took meds: ");
            __builder.AddContent(53, 
#nullable restore
#line 40 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                 medication.LastTimeMedsTaken.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "li");
            __builder.AddAttribute(56, "class", "meds-additional-text-info");
            __builder.AddContent(57, "Daily amount of doses: ");
            __builder.AddContent(58, 
#nullable restore
#line 41 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                              medication.DosesPerDayAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "li");
            __builder.AddAttribute(61, "class", "meds-additional-text-info");
            __builder.AddContent(62, "Single Dosage: ");
            __builder.AddContent(63, 
#nullable restore
#line 42 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                      medication.SingleDosage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "li");
            __builder.AddAttribute(66, "class", "meds-additional-text-info");
            __builder.AddContent(67, "Total Dosage: ");
            __builder.AddContent(68, 
#nullable restore
#line 43 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                     medication.TotalDosage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "meds-submit-button");
            __builder.AddAttribute(72, "type", "submit");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                           () => OnTakeMeds(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Take meds!");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "class", "meds-delete-button");
            __builder.AddAttribute(78, "type", "submit");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                           () => OnDeleteMeds(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "Delete course");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(81, 
#nullable restore
#line 48 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
         infoMessage

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(82, "style");
            __builder.AddMarkupContent(83, "\r\n        .circle.per-");
            __builder.AddContent(84, 
#nullable restore
#line 51 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                     GetPercent(medication)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, "\r\n        {\r\n            background-image: conic-gradient(aquamarine ");
            __builder.AddContent(86, 
#nullable restore
#line 53 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                         GetPercent(medication)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(87, "%, #b0b0b0 0);\r\n        }\r\n        ");
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(88);
            __builder.AddAttribute(89, "class", "submit-button");
            __builder.AddAttribute(90, "href", "meds/add");
            __builder.AddAttribute(91, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 60 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(93, " Press here to start new course!");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Meds.razor"
       
    [Inject]
    public IMedsService MedsService { get; set; }
    [Inject]
    public AuthenticationStateProvider AuthProvider { get; set; }

    protected IEnumerable<MedsModel> MedsList { get; set; }
    protected ClaimsPrincipal user { get; set; }
    protected string infoMessage { get; set; } = "";
    protected DateTime lastTimeMedsTaken { get; set; }

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
    }

    protected async Task OnTakeMeds(MedsModel meds)
    {
        if (meds.AmountOfDosesLeft == 0)
        {
            infoMessage = "You have finished this course. You can delete it if you don't wanna track it anymore!";
            return;
        }

        await MedsService.TakeMeds(user, meds);
        meds.AmountOfDosesLeft -= 1;
        meds.LastTimeMedsTaken = DateTime.Now;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
