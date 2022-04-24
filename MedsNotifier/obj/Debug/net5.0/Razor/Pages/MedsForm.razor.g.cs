#pragma checksum "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f78a4e0c7ac1873601bf2ab1ba7d4350d9cc321"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "meds-form-box");
            __builder.AddMarkupContent(2, "<h3>New meds course</h3>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                      medication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                  HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContext", true);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((login) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "p");
                __builder2.AddContent(13, 
#nullable restore
#line 15 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
            message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "input-fields");
                __builder2.AddMarkupContent(17, "\r\n            Name ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "name");
                __builder2.AddAttribute(20, "class", "text-field");
                __builder2.AddAttribute(21, "placeholder", "Name");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                         medication.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.Name = __value, medication.Name))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => medication.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            Description ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "description");
                __builder2.AddAttribute(28, "class", "text-field");
                __builder2.AddAttribute(29, "placeholder", "Description");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                                              medication.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.Description = __value, medication.Description))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => medication.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.AddMarkupContent(34, "<label for=\"type\">Type</label>");
                __Blazor.MedsNotifier.Pages.MedsForm.TypeInference.CreateInputSelect_0(__builder2, 35, 36, "text-field", 37, 
#nullable restore
#line 19 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                       medication.MedsType

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.MedsType = __value, medication.MedsType)), 39, () => medication.MedsType, 40, (__builder3) => {
#nullable restore
#line 20 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                 foreach (var type in Enum.GetValues(typeof(MedsType)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(41, "option");
                    __builder3.AddAttribute(42, "value", 
#nullable restore
#line 22 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                    type

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(43, 
#nullable restore
#line 22 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                           type

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenComponent<Smart.Blazor.ColorPicker>(45);
                __builder2.AddAttribute(46, "Value", "#DB3A15");
                __builder2.AddAttribute(47, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "DisplayMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Smart.Blazor.ColorDisplayMode>(
#nullable restore
#line 25 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                      ColorDisplayMode.Palette

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Smart.Blazor.Event>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Smart.Blazor.Event>(this, 
#nullable restore
#line 25 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                                          OnChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.AddMarkupContent(51, "<button class=\"submit-button\" type=\"submit\">Start!</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
       
    private MedsModel medication = new();
    private string message;

    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public IMedsService MedsService { get; set; }
    [Inject]
    public AuthenticationStateProvider AuthProvider { get; set; }

    protected ClaimsPrincipal user;

    private async Task HandleSubmit()
    {
        await MedsService.AddMedsToUserChest(user, medication);
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (!firstRender) message = "";
    }
    protected override async Task OnInitializedAsync()
    {
        var state = await AuthProvider.GetAuthenticationStateAsync();
        var user = state.User;
    }
    private void OnChange(Event ev)
    {
        ColorPickerChangeEventDetail detail = ev["Detail"];
        medication.Color = detail.Value;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MedsNotifier.Pages.MedsForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
