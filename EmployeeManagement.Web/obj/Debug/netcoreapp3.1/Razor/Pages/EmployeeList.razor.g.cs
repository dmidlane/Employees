#pragma checksum "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c7b6363df5b92b250f273724ac21c39eb45bdf"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
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
#nullable restore
#line 4 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>\r\n");
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, "Selected Employee Count: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                              SelectedEmployeesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "id", "showFooter");
            __builder.AddAttribute(8, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                              ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.AddMarkupContent(11, "<label for=\"showFooter\">Show Footer</label>\r\n\r\n");
#nullable restore
#line 12 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 15 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-deck");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 19 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
         foreach (var employee in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenComponent<EmployeeManagement.Web.Pages.DisplayEmployee>(18);
            __builder.AddAttribute(19, "Employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EmployeeManagement.Models.Employee>(
#nullable restore
#line 21 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                       employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                             ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "OnEmployeeSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 22 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                 EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "OnEmployeeDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 23 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                EmployeeDeleted

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 25 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 27 "C:\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591