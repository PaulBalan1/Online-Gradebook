#pragma checksum "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33ff8a388c4e65064c02e48520b91c6691def285"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\Login.razor"
using WebApplication.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", true);
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, "<div class=\"imgcontainer\">\r\n                <img src=\"/Media/logo.png\" alt=\"Avatar\" class=\"avatar\">\r\n            </div>\r\n\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "container");
                __builder2.AddAttribute(9, "style", "margin-top: 3em");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row");
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-4 center-horiz blue-border");
                __builder2.AddAttribute(16, "style", "padding: 1em");
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.AddMarkupContent(18, "<label for=\"id\">\r\n                            <b>Identification Number</b>\r\n                        </label>\r\n                        ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "placeholder", "Enter ID");
                __builder2.AddAttribute(22, "name", "id");
                __builder2.AddAttribute(23, "required", true);
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\Login.razor"
                                                                                         username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.AddMarkupContent(27, "<label for=\"psw\">\r\n                            <b>Password</b>\r\n                        </label>\r\n                        ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "password");
                __builder2.AddAttribute(30, "placeholder", "Enter Password");
                __builder2.AddAttribute(31, "name", "psw");
                __builder2.AddAttribute(32, "required", true);
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\Login.razor"
                                                                                                    password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "style", "color:red");
                __builder2.AddContent(38, 
#nullable restore
#line 25 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\Login.razor"
                                                errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "class", "btn-primary");
                __builder2.AddAttribute(42, "type", "submit");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\Login.razor"
                                                                            PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Login");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n\r\n<link rel=\"stylesheet\" href=\"css/login.css\">\r\n<link rel=\"stylesheet\" href=\"css/overallTheme.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\Login.razor"
 
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo(CustomAuthenticationStateProvider.NavigateToWindow());
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591