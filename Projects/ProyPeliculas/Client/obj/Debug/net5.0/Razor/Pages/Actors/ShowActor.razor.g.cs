#pragma checksum "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Actors\ShowActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e47ead81e50b653493a896e78f04bf4a8da443"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeliculas.Client.Pages.Actors
{
    #line hidden
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
#line 2 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Actors\ShowActor.razor"
using ProyPeliculas.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Actors\ShowActor.razor"
using ProyPeliculas.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Actors\ShowActor.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors")]
    public partial class ShowActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProyPeliculas.Client.Pages.Components.CardActorsComponent>(0);
            __builder.AddAttribute(1, "Actors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProyPeliculas.Shared.Entity.Actor>>(
#nullable restore
#line 7 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Actors\ShowActor.razor"
                             Actors

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\ProysCicloIII\G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam\Projects\ProyPeliculas\Client\Pages\Actors\ShowActor.razor"
       
    private List<Actor> Actors;
    protected override void OnInitialized()
    {
        Actors = actor.GetActors();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceActor actor { get; set; }
    }
}
#pragma warning restore 1591
