#pragma checksum "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "225948d4ec023c342b9042f3f5785ce82053f071"
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
#line 1 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
using MedsNotifier.Data.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
using MedsNotifier.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
using MedsNotifier.Data.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
using MedsNotifier.Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "auth-form-body");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "login-form-box");
            __builder.AddMarkupContent(4, "<h3 class=\"reg-header\">Register</h3>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                         registerModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                        HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "p");
                __builder2.AddContent(14, 
#nullable restore
#line 16 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "input-fields");
                __builder2.AddMarkupContent(18, "<label for=\"email\">Email</label>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "text-field");
                __builder2.AddAttribute(21, "id", "email");
                __builder2.AddAttribute(22, "placeholder", "Email");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                                                                                          registerModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Email = __value, registerModel.Email))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.AddMarkupContent(27, "<label for=\"username\">Username</label>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "text-field");
                __builder2.AddAttribute(30, "id", "username");
                __builder2.AddAttribute(31, "placeholder", "Username");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                                                                                                      registerModel.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Username = __value, registerModel.Username))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerModel.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.AddMarkupContent(36, "<label for=\"age\">Age</label> ");
                __Blazor.MedsNotifier.Pages.Register.TypeInference.CreateInputNumber_0(__builder2, 37, 38, "text-field", 39, "age", 40, "Age", 41, 
#nullable restore
#line 20 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                                                                                     registerModel.Age

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Age = __value, registerModel.Age)), 43, () => registerModel.Age);
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.AddMarkupContent(45, "<label for=\"weight\">Weight</label>");
                __Blazor.MedsNotifier.Pages.Register.TypeInference.CreateInputNumber_1(__builder2, 46, 47, "text-field", 48, "weight", 49, "Weight", 50, 
#nullable restore
#line 21 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                                                                                                registerModel.Weight

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Weight = __value, registerModel.Weight)), 52, () => registerModel.Weight);
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.AddMarkupContent(54, "<label for=\"height\">Height</label>");
                __Blazor.MedsNotifier.Pages.Register.TypeInference.CreateInputNumber_2(__builder2, 55, 56, "text-field", 57, "height", 58, "Height", 59, 
#nullable restore
#line 22 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                                                                                                registerModel.Height

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Height = __value, registerModel.Height)), 61, () => registerModel.Height);
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.AddMarkupContent(63, "<label for=\"gender\">Gender</label>");
                __Blazor.MedsNotifier.Pages.Register.TypeInference.CreateInputSelect_3(__builder2, 64, 65, "text-field", 66, 
#nullable restore
#line 23 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                                                               registerModel.Gender

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Gender = __value, registerModel.Gender)), 68, () => registerModel.Gender, 69, (__builder3) => {
#nullable restore
#line 24 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                     foreach (var gender in Enum.GetValues(typeof(Gender)))
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "value", 
#nullable restore
#line 26 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                        gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(72, 
#nullable restore
#line 26 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                 gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 27 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.AddMarkupContent(74, "<label for=\"password\">Password</label>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "class", "text-field");
                __builder2.AddAttribute(77, "id", "password");
                __builder2.AddAttribute(78, "type", "password");
                __builder2.AddAttribute(79, "placeholder", "Password");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
                                                                                                                                                      registerModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerModel.Password = __value, registerModel.Password))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n            ");
                __builder2.AddMarkupContent(84, "<button class=\"submit-button\" type=\"submit\">Register</button>\r\n            ");
                __builder2.AddMarkupContent(85, "<p class=\"warning\">Such parameters as Height, Weight, Gender and Age are optional, but they can help us to analyze your health better.</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\PC\source\repos\MedsNotifier\MedsNotifier\Pages\Register.razor"
       
    private RegisterViewModel registerModel = new();
    private string message;
    private string token = "Bearer ";

    [Inject]
    public LocalStorageService LocalStorageService { get; set; }
    [Inject]
    public IMongoRepository MongoRepository { get; set; }

    private async Task HandleSubmit()
    {
        var result = await AuthorizationService.Register(registerModel);

        if (result.Succeeded)
        {
            token += result.Token;

            await LocalStorageService.SetItem<string>("Authorization", token);
            await MongoRepository.InsertRefreshToken(result.RefreshToken);

            NavigationManager.NavigateTo("/home", true);

        }
        else message = result.Message;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (!firstRender) message = "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MedsNotifier.Services.IAuthorizationService AuthorizationService { get; set; }
    }
}
namespace __Blazor.MedsNotifier.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
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
