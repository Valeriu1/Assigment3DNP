#pragma checksum "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7c42ecddbe94eeb775a38250228ec18946ad2c"
// <auto-generated/>
#pragma warning disable 1591
namespace Assigment3Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "align", "center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card card-has-bg ");
            __builder.AddAttribute(4, "style", "background-image: url(https://i.imgur.com/PppdzrD.png); width: 25rem");
            __builder.AddMarkupContent(5, "<img class=\"card-img\" src=\"https://i.imgur.com/PppdzrD.png\" alt=\"Card image\">\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-img-overlay");
            __builder.AddMarkupContent(8, "<div class=\"card-header\"><h1>Assigment 3</h1></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(13, "h5");
                __builder2.AddAttribute(14, "class", "card-title");
                __builder2.AddContent(15, "Hello ");
                __builder2.AddContent(16, 
#nullable restore
#line 12 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Index.razor"
                                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Index.razor"
                             GoToPersons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "btn btn-outline-dark");
            __builder.AddContent(21, "See List");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Index.razor"
 
    private void GoToPersons()
    {
        NavigationManager.NavigateTo("/Persons");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591