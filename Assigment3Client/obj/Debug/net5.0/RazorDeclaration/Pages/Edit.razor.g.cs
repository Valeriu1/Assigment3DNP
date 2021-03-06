// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Edit.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Edit.razor"
using Assigment3Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Edit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit/{Id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\sarks\RiderProjects\Assigment3\Assigment3Client\Pages\Edit.razor"
       
    [Parameter]
    public int Id { get; set; }
    
    private Adult personToEdit = new Adult();

    private Job jobToEdit = new Job();
    
    protected override async Task OnInitializedAsync()
    {
        personToEdit = await personsService.GetAsync(Id);
        jobToEdit = personToEdit.JobTitle;
    }

    private async Task Save()
    {
        personToEdit.JobTitle = jobToEdit;
        try
        {
            await  personsService.UpdateAsync(personToEdit);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        NavigationManager.NavigateTo("/Persons");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonsService personsService { get; set; }
    }
}
#pragma warning restore 1591
