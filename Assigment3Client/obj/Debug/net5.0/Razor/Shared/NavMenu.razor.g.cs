#pragma checksum "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7c36ca4e27362b44df96e1a48cc8ba02b99e1c"
// <auto-generated/>
#pragma warning disable 1591
namespace Assigment3Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Assigment3Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\_Imports.razor"
using Assigment3Client.Shared;

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
            __builder.AddAttribute(2, "b-uduo9p9db3");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-uduo9p9db3>Assigment 3</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-uduo9p9db3");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-uduo9p9db3></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-uduo9p9db3");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-uduo9p9db3");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-uduo9p9db3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-uduo9p9db3></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-uduo9p9db3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "Persons");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-spreadsheet\" aria-hidden=\"true\" b-uduo9p9db3></span> Persons\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(36);
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(38, "li");
                __builder2.AddAttribute(39, "class", "nav-item px-3");
                __builder2.AddAttribute(40, "b-uduo9p9db3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "class", "nav-link");
                __builder2.AddAttribute(43, "href", "Add");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-uduo9p9db3></span> Add\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591