#pragma checksum "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "973e15b58e5e2f17080a96a159e0fcf998b0be79"
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
using MedsNotifier.Factories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
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
#line 13 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
     if (MedsList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p class=\"empty-meds\">You haven\'t started any courses yet.</p>");
#nullable restore
#line 16 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
    }

    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "meds-info");
#nullable restore
#line 21 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
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
#line 26 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                    medication.Color

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "class", "meds-title-" + (
#nullable restore
#line 26 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                         medication.Id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, " Title: ");
            __builder.AddContent(13, 
#nullable restore
#line 26 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                                            medication.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "meds-type");
            __builder.AddContent(17, "Type: ");
            __builder.AddContent(18, 
#nullable restore
#line 27 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                     medication.MedsType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "meds-text-info");
            __builder.AddContent(22, " Description: ");
            __builder.AddContent(23, 
#nullable restore
#line 28 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                  medication.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "meds-text-info");
            __builder.AddContent(27, " Doses Left: ");
            __builder.AddContent(28, 
#nullable restore
#line 29 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                 medication.AmountOfDosesLeft

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "meds-text-info");
            __builder.AddContent(32, "Start: ");
            __builder.AddContent(33, 
#nullable restore
#line 30 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                           medication.StartMedsDateTime.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "meds-text-info");
            __builder.AddContent(37, "Finish: ");
            __builder.AddContent(38, 
#nullable restore
#line 31 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                            medication.FinishMedsDateTime.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "info-message");
            __builder.AddContent(42, 
#nullable restore
#line 32 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                   medication?.InfoMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "wrap-circles");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "circle" + " per-" + (
#nullable restore
#line 35 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                GetPercent(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "inner");
            __builder.AddContent(50, 
#nullable restore
#line 36 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                GetPercent(medication)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, "%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "ul");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "meds-additional-text-info");
            __builder.AddContent(56, " Last time you took meds: ");
            __builder.AddContent(57, 
#nullable restore
#line 40 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                         medication.LastTimeMedsTaken.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "li");
            __builder.AddAttribute(60, "class", "meds-additional-text-info");
            __builder.AddContent(61, "Daily amount of doses: ");
            __builder.AddContent(62, 
#nullable restore
#line 41 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                      medication.DosesPerDayAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "li");
            __builder.AddAttribute(65, "class", "meds-additional-text-info");
            __builder.AddContent(66, "Single Dosage: ");
            __builder.AddContent(67, 
#nullable restore
#line 42 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                              medication.SingleDosage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "li");
            __builder.AddAttribute(70, "class", "meds-additional-text-info");
            __builder.AddContent(71, "Total Dosage: ");
            __builder.AddContent(72, 
#nullable restore
#line 43 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                             medication.TotalDosage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "class", "meds-submit-button");
            __builder.AddAttribute(76, "type", "submit");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                   () => OnTakeMeds(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Take meds!");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "meds-delete-button");
            __builder.AddAttribute(82, "type", "submit");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                                   () => OnDeleteMeds(medication)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Delete course");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(85, "style");
            __builder.AddMarkupContent(86, "\r\n        .circle.per-");
            __builder.AddContent(87, 
#nullable restore
#line 51 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                     GetPercent(medication)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(88, "\r\n        {\r\n            background-image: conic-gradient(aquamarine ");
            __builder.AddContent(89, 
#nullable restore
#line 53 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                         GetPercent(medication)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "%, #b0b0b0 0);\r\n        }\r\n        .meds-page-wrapper .meds-info .meds-block-info .meds-title-");
            __builder.AddContent(91, 
#nullable restore
#line 55 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                                    medication.Id.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(92, " {\r\n            font-style: italic;\r\n            font-size: 30px;\r\n            margin-bottom: 5px;\r\n            color: ");
            __builder.AddContent(93, 
#nullable restore
#line 59 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                    medication.Color

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(94, ";\r\n        }\r\n\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 63 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 66 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(95);
            __builder.AddAttribute(96, "class", "submit-button");
            __builder.AddAttribute(97, "href", "meds/add");
            __builder.AddAttribute(98, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 67 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(100, " Press here to start new course!");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\MedsNotifier\MedsNotifier\Pages\Meds.razor"
       
    [Inject]
    NavigationManager NavigationManager { get; set; }
    [Inject]
    IEntriesFactory EntriesFactory { get; set; }
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

        await DiaryService.AddDiaryEntryAsync(user,EntriesFactory.CreateDiaryEntry(meds));


    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
