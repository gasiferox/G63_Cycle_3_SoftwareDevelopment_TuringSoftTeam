#pragma checksum "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8be570e415a57da596b331509bcedb032141d8"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeliculas.Client.Pages
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
#nullable restore
#line 2 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
using ProyPeliculas.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Movie DataBase</h1>\r\n\r\n");
            __builder.OpenComponent<ProyPeliculas.Client.Pages.Components.CardComponent>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "jumbotron jumbotron-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "<h1 class=\"display-3\">Base de datos de películas</h1>\r\n        ");
            __builder.AddMarkupContent(8, "<p class=\"lead\">Películas</p>\r\n        <hr class=\"my-2\">");
#nullable restore
#line 14 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
         if (Movies == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<label><small class=\"text-muted\">No se encontraron registros</small></label>");
#nullable restore
#line 17 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
             foreach (var itemMovie in Movies)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "list-group align-items-start mb-3");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col md-3");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 26 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
                                       itemMovie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "alt");
            __builder.AddAttribute(19, "height", "300px");
            __builder.AddAttribute(20, "width", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col md-9");
            __builder.OpenElement(24, "h6");
            __builder.AddAttribute(25, "class", "text-left");
            __builder.OpenElement(26, "small");
            __builder.AddAttribute(27, "class", "text-muted");
            __builder.AddContent(28, 
#nullable restore
#line 29 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
                                                                             itemMovie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "blockquote");
            __builder.AddAttribute(31, "class", "blockquote text-left");
            __builder.OpenElement(32, "small");
            __builder.AddContent(33, 
#nullable restore
#line 30 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
                                                                             itemMovie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<p>More info</p>\r\n        ");
            __builder.AddMarkupContent(35, "<p class=\"lead\"><a class=\"btn btn-primary btn-lg\" href=\"Jumbo action link\" role=\"button\">Jumbo action name</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Index.razor"
            


    public List<Movie> Movies { get { return GetMovies(); } }
    private List<Movie> GetMovies()
    {
        return new List<Movie>()
        {
            new Movie(){Name="Archer", Sinopsis="Trama de la película...", Image="/img/movies/poster_archer.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Back to the future", Sinopsis="Trama de la película...", Image="/img/movies/poster_backToTheFuture.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Joker", Sinopsis="Trama de la película...", Image="/img/movies/poster_joker.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Wolverine I", Sinopsis="Trama de la película...", Image="/img/movies/poster_wolverine.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Wolverine II", Sinopsis="Trama de la película...", Image="/img/movies/poster_wolverine_2.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="World War Z", Sinopsis="Trama de la película...", Image="/img/movies/poster_worldWarZ.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Antman", Sinopsis="Trama de la película...", Image="/img/movies/poster_antman.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="After", Sinopsis="Trama de la película...", Image="/img/movies/poster_after.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Star Trek", Sinopsis="Trama de la película...", Image="/img/movies/poster_starTrek.jpeg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()},
            new Movie(){Name="Suicide Squad", Sinopsis="Trama de la película...", Image="/img/movies/poster_suicideSquad.jpg", Premier=new DateTime(2021, 10, 15), Category=Category.Accion, Casting=new Casting()}
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
