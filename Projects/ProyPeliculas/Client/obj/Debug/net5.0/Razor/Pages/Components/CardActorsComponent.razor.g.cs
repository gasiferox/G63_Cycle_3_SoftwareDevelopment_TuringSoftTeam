#pragma checksum "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79cf0b501ecd5760abd72522fff4af892cbc3dac"
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
    public partial class CardActorsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row mb-3");
#nullable restore
#line 5 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
             foreach (var actor in Actors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-4");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card flex-md-row mb-4 box-shadow h-md-300");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body d-flex flex-column align-items-start");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 11 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
                                           actor.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "alt", "img-thumbnail card-img-top");
            __builder.AddAttribute(19, "height", "300px");
            __builder.AddAttribute(20, "width", "200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.OpenElement(24, "h6");
            __builder.AddAttribute(25, "class", "card-title");
            __builder.AddContent(26, 
#nullable restore
#line 13 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
                                                            actor.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 13 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
                                                                        actor.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "class", "text-muted");
            __builder.AddContent(32, 
#nullable restore
#line 15 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
                                         actor.Birthday

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n                                        <br>\r\n                                        ");
            __builder.AddContent(34, 
#nullable restore
#line 17 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
                                         actor.PlaceOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n                                        <br>\r\n                                        ");
            __builder.OpenElement(36, "small");
            __builder.AddContent(37, 
#nullable restore
#line 19 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
                                                actor.ArtisticName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                        <br>\r\n                                        ");
            __builder.OpenElement(39, "small");
            __builder.AddContent(40, 
#nullable restore
#line 21 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
                                                actor.CareerTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.AddMarkupContent(42, "<div><a href=\"http://\"><span class=\"oi oi-pencil\" aria-hidden=\"true\"></span></a></div>\r\n                                ");
            __builder.AddMarkupContent(43, "<div><a href=\"http://\"><span class=\"oi oi-zoom-in\" aria-hidden=\"true\"></span></a></div>\r\n                                ");
            __builder.AddMarkupContent(44, "<div><a href=\"http://\"><span class=\"oi oi-delete\" aria-hidden=\"true\"></span></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.AddMarkupContent(46, "<p>More info</p>\r\n        ");
            __builder.AddMarkupContent(47, "<p class=\"lead\"><a class=\"btn btn-primary btn-lg\" href=\"Jumbo action link\" role=\"button\">Jumbo action name</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Components\CardActorsComponent.razor"
      
    [Parameter] public List<Actor> Actors { get; set; }

    void ActorDelete()
    {
        Console.WriteLine("Eliminando actor");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
