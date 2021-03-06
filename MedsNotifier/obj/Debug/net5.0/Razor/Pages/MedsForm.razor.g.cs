#pragma checksum "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea8340878812c2bc804b5134e57ea6c18681526"
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
#line 4 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
using Smart.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
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
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                      medication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                  HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContext", true);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((medsform) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "p");
#nullable restore
#line 15 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
__builder2.AddContent(13, message);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "input-fields");
                __builder2.AddMarkupContent(17, "\r\n            Name ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "name");
                __builder2.AddAttribute(20, "class", "text-field");
                __builder2.AddAttribute(21, "placeholder", "Name");
                __builder2.AddAttribute(22, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                         medication.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.Name = __value, medication.Name))));
                __builder2.AddAttribute(24, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => medication.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            Description ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "description");
                __builder2.AddAttribute(28, "class", "text-field");
                __builder2.AddAttribute(29, "placeholder", "Description");
                __builder2.AddAttribute(30, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                                              medication.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.Description = __value, medication.Description))));
                __builder2.AddAttribute(32, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => medication.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.AddMarkupContent(34, "<label for=\"type\">Type</label>");
                __Blazor.MedsNotifier.Pages.MedsForm.TypeInference.CreateInputSelect_0(__builder2, 35, 36, "text-field", 37, 
#nullable restore
#line 19 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                       medication.MedsType

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.MedsType = __value, medication.MedsType)), 39, () => medication.MedsType, 40, (__builder3) => {
#nullable restore
#line 20 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                 foreach (var type in Enum.GetValues(typeof(MedsType)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(41, "option");
                    __builder3.AddAttribute(42, "value", 
#nullable restore
#line 22 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                    type

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 22 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
__builder3.AddContent(43, type);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 23 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(44, "\r\n            Single Dosage");
                __Blazor.MedsNotifier.Pages.MedsForm.TypeInference.CreateInputNumber_1(__builder2, 45, 46, "single-dosage", 47, "text-field", 48, "Single Dosage", 49, 
#nullable restore
#line 25 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                                                     medication.SingleDosage

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.SingleDosage = __value, medication.SingleDosage)), 51, () => medication.SingleDosage);
                __builder2.AddMarkupContent(52, "\r\n            Amount Of Doses Per A Day");
                __Blazor.MedsNotifier.Pages.MedsForm.TypeInference.CreateInputNumber_2(__builder2, 53, 54, "daily-dosage-amount", 55, "text-field", 56, "Amount Of Daily Doses", 57, 
#nullable restore
#line 26 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                                                                               medication.DosesPerDayAmount

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => medication.DosesPerDayAmount = __value, medication.DosesPerDayAmount)), 59, () => medication.DosesPerDayAmount);
                __builder2.AddMarkupContent(60, "\r\n            Choose the date when your course finishes");
                __builder2.OpenComponent<Smart.Blazor.Calendar>(61);
                __builder2.AddAttribute(62, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Smart.Blazor.Event>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Smart.Blazor.Event>(this, 
#nullable restore
#line 27 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                                      OnCalendarChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n            Medication color");
                __builder2.OpenComponent<Smart.Blazor.ColorPicker>(64);
                __builder2.AddAttribute(65, "Editable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Smart.Blazor.Event>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Smart.Blazor.Event>(this, 
#nullable restore
#line 28 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
                                                                   OnColorChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.AddMarkupContent(68, "<button class=\"submit-button\" type=\"submit\">Start!</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\MedsNotifier\MedsNotifier\Pages\MedsForm.razor"
       
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

        var createdMeds = MedsService.CreateMedicationFromForm(medication);

        var state = await AuthProvider.GetAuthenticationStateAsync();
        var user = state.User;

        await MedsService.AddMedsToUserChest(user, createdMeds);

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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
