#pragma checksum "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0371d4c62944c0b5e599be2679eae4b0d59f1c8"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Tribal.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>EmployeeManagement.Web</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "class", "nav-item px-3");
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
                __builder2.AddAttribute(24, "class", "nav-link");
                __builder2.AddAttribute(25, "href", "");
                __builder2.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n                        <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "/editemployee");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                                                             HandleClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 18 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n                        <span class=\"oi oi-file\" aria-hidden=\"true\"></span> Create\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "li");
                __builder2.AddAttribute(44, "class", "nav-item px-3");
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
                __builder2.AddAttribute(47, "class", "nav-link");
                __builder2.AddAttribute(48, "href", "/identity/account/logout");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                                                                        HandleClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 23 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                                                                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                        <span class=\"oi oi-power-standby\" aria-hidden=\"true\"></span> Log out\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
            }
            ));
            __builder.AddAttribute(55, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "nav-item px-3");
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
                __builder2.AddAttribute(61, "class", "nav-link");
                __builder2.AddAttribute(62, "href", "/identity/account/login");
                __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                                                                       HandleClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 30 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
                                                                                                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n                        <span class=\"oi oi-lock-locked\" aria-hidden=\"true\"></span> Log in\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Shared\NavMenu.razor"

    private void HandleClick()
    {
        // force a server reload so that the pageheader property is refreshed
        NavigationManager.NavigateTo("editemployee", true);
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
