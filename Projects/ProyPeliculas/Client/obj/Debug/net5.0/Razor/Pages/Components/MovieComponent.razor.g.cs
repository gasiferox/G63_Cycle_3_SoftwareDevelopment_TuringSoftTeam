#pragma checksum "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\MovieComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b147bfa3848ede861b57bfb4f8a0321fd7fa32"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeliculas.Client.Pages.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class MovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-right: 2%; margin-button: 10px; text-align: center;");
            __builder.OpenElement(2, "a");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 3 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\MovieComponent.razor"
                   Movie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "width", "225px");
            __builder.AddAttribute(6, "height", "300px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "style", "max-width: 225px; height: 44px; font-size: 15px; font-weight: bold;");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", "urlMovie");
            __builder.AddContent(12, 
#nullable restore
#line 5 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\MovieComponent.razor"
                                                                                                       Movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "<a class=\"btn btn-info\">Editar</a>\r\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-danger");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\MovieComponent.razor"
                                                                 ()=>DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\MovieComponent.razor"
      
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
    private string urlMovie = string.Empty;

    protected override void OnInitialized()
    {
        urlMovie = $"movie/";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
