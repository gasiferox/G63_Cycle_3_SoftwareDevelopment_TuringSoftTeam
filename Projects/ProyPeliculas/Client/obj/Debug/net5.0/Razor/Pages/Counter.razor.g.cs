#pragma checksum "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53915c4c5013fd938e844ceb07e1f4095c94b4cc"
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
#line 1 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/_Imports.razor"
using ProyPeliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
using ProyPeliculas.Client.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, ":components\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Movie DataBase</h1>\r\n\r\n");
            __builder.OpenComponent<ProyPeliculas.Client.Pages.Components.CardComponent>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, @"<div id=""carouselExampleFade"" class=""carousel slide carousel-fade"" data-bs-ride=""carousel""><div class=""carousel-inner""><div class=""carousel-item active""><img src=""/img/banner_glass.jpg"" class=""d-block w-100""></div>
    <div class=""carousel-item""><img src=""/img/banner_catwoman.jpg"" class=""d-block w-100""></div>
    <div class=""carousel-item""><img src=""/img/banner_inception_2.jpg"" class=""d-block w-100""></div>
     <div class=""carousel-item""><img src=""/img/banner_theHobbit.jpg_2.jpg"" class=""d-block w-100""></div>
    <div class=""carousel-item""><img src=""/img/banner_worldWarZ.jpg"" class=""d-block w-100""></div>
    <div class=""carousel-item""><img src=""/img/banner_movie.jpg"" class=""d-block w-100""></div>
    <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleFade"" data-bs-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""visually-hidden"">Previous</span></button>
    <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleFade"" data-bs-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""visually-hidden"">Next</span></button></div></div>

<br>

<br>

");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row row-cols-1 row-cols-md-3 g-4 mb-3");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card mb-3 h-100");
            __builder.AddAttribute(11, "style", "width: 18rem;");
            __builder.AddMarkupContent(12, "<img src=\"/img/poster_archer.jpg\" class=\"card-img-top\" alt=\"...\" width=\"20\" height=\"380\">\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, 
#nullable restore
#line 48 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                        movie1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "card-text");
            __builder.AddContent(21, 
#nullable restore
#line 49 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                      sinopsisMovie1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<a href=\"#\" class=\"btn btn-primary\">Ver película</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card mb-3 h-100");
            __builder.AddAttribute(29, "style", "width: 18rem;");
            __builder.AddMarkupContent(30, "<img src=\"/img/poster_joker.jpg\" class=\"card-img-top\" alt=\"...\" width=\"20\" height=\"380\">\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-body");
            __builder.OpenElement(33, "h5");
            __builder.AddAttribute(34, "class", "card-title");
            __builder.AddContent(35, 
#nullable restore
#line 58 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                        movie2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "card-text");
            __builder.AddContent(39, 
#nullable restore
#line 59 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                      sinopsisMovie2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.AddMarkupContent(41, "<a href=\"#\" class=\"btn btn-primary\">Ver película</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    \r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card mb-3 h-100");
            __builder.AddAttribute(47, "style", "width: 18rem;");
            __builder.AddMarkupContent(48, "<img src=\"/img/poster_backToTheFuture.jpg\" class=\"card-img-top\" alt=\"...\" width=\"20\" height=\"380\">\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-body");
            __builder.OpenElement(51, "h5");
            __builder.AddAttribute(52, "class", "card-title");
            __builder.AddContent(53, 
#nullable restore
#line 69 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                        movie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "p");
            __builder.AddAttribute(56, "class", "card-text");
            __builder.AddContent(57, 
#nullable restore
#line 70 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                      sinopsisMovie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.AddMarkupContent(59, "<a href=\"#\" class=\"btn btn-primary\">Ver película</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card mb-3 h-100");
            __builder.AddAttribute(65, "style", "width: 18rem;");
            __builder.AddMarkupContent(66, "<img src=\"/img/poster_wolverine.jpg\" class=\"card-img-top\" alt=\"...\" width=\"20\" height=\"380\">\r\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card-body");
            __builder.OpenElement(69, "h5");
            __builder.AddAttribute(70, "class", "card-title");
            __builder.AddContent(71, 
#nullable restore
#line 80 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                        movie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "p");
            __builder.AddAttribute(74, "class", "card-text");
            __builder.AddContent(75, 
#nullable restore
#line 81 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                      sinopsisMovie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.AddMarkupContent(77, "<a href=\"#\" class=\"btn btn-primary\">Ver película</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "card mb-3 h-100");
            __builder.AddAttribute(83, "style", "width: 18rem;");
            __builder.AddMarkupContent(84, "<img src=\"/img/poster_wolverine_2.jpg\" class=\"card-img-top\" alt=\"...\" width=\"20\" height=\"380\">\r\n            ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "card-body");
            __builder.OpenElement(87, "h5");
            __builder.AddAttribute(88, "class", "card-title");
            __builder.AddContent(89, 
#nullable restore
#line 91 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                        movie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "p");
            __builder.AddAttribute(92, "class", "card-text");
            __builder.AddContent(93, 
#nullable restore
#line 92 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                      sinopsisMovie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.AddMarkupContent(95, "<a href=\"#\" class=\"btn btn-primary\">Ver película</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "card mb-3 h-100");
            __builder.AddAttribute(101, "style", "width: 18rem;");
            __builder.AddMarkupContent(102, "<img src=\"/img/poster_worldWarZ.jpg\" class=\"card-img-top\" alt=\"...\" width=\"20\" height=\"380\">\r\n            ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "card-body");
            __builder.OpenElement(105, "h5");
            __builder.AddAttribute(106, "class", "card-title");
            __builder.AddContent(107, 
#nullable restore
#line 102 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                        movie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "p");
            __builder.AddAttribute(110, "class", "card-text");
            __builder.AddContent(111, 
#nullable restore
#line 103 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                      sinopsisMovie3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                ");
            __builder.AddMarkupContent(113, "<a href=\"#\" class=\"btn btn-primary\">Ver película</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(115, "<div class=\"mb-3\"><input class=\"form-control form-control-sm\" type=\"text\" placeholder=\"Titulo de la película\"></div>\r\n\r\n");
            __builder.AddMarkupContent(116, "<div class=\"mb-3\"><input class=\"form-control form-control-sm\" type=\"text\" placeholder=\"Género\"></div>\r\n\r\n");
            __builder.AddMarkupContent(117, "<div class=\"mb-3\"><input class=\"form-control form-control-sm\" type=\"text\" placeholder=\"Titulo de la película\"></div>\r\n\r\n");
            __builder.AddMarkupContent(118, "<div class=\"mb-3\"><label for=\"formFileSm\" class=\"form-label\">Small file input example</label>\r\n  <input class=\"form-control form-control-sm\" id=\"formFileSm\" type=\"file\"></div>\r\n\r\n<br>\r\n\r\n<input type=\"file\" name id class=\"form-control form-control-sm\">\r\n\r\n");
            __builder.OpenElement(119, "div");
            __builder.OpenElement(120, "label");
            __builder.AddAttribute(121, "class", "form-label");
            __builder.AddContent(122, "Pelicula 1 - ");
            __builder.AddContent(123, 
#nullable restore
#line 136 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                            FunctionsArrowClass.functionConvertMayus(movie1)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(124, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.OpenElement(126, "label");
            __builder.AddAttribute(127, "class", "form-label");
            __builder.AddContent(128, "Pelicula 2 - ");
            __builder.AddContent(129, 
#nullable restore
#line 137 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                            FunctionsArrowClass.functionConvertMinus(movie2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(130, ".");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n\r\n");
            __builder.OpenElement(132, "div");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "class", "btn btn-info");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 142 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                            clickEventButton

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(136, "Da click");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n    ");
            __builder.OpenElement(138, "button");
            __builder.AddAttribute(139, "class", "btn btn-danger");
            __builder.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 143 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                              clickEventCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(141, "Cancelar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(143, "input");
            __builder.AddAttribute(144, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 150 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
              text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(145, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
            __builder.OpenElement(147, "p");
            __builder.AddContent(148, 
#nullable restore
#line 151 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
    text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 154 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                                  
    public string movie1 = "Archer";
    public string movie2 = "Joker";
    public string movie3 = "Back to the Future";
    public string sinopsisMovie1 = "Great movie about a girl with a bow.";
    public string sinopsisMovie2 = "Joker with a full theme movie.";
    public string sinopsisMovie3 = "BACK TO THE FUTURE";
    public string text;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "/home/maverick/Documents/01. MinTIC - Universidad de Caldas/03. Ciclo III/01. Desarrollo de Software - G63/G63_Cycle_3_SoftwareDevelopment_TuringSoftTeam/Projects/ProyPeliculas/Client/Pages/Counter.razor"
                 
    public void clickEventButton(){
        Console.WriteLine("Has dado click en el botón");
    }

    public void clickEventCancel(){
        Console.WriteLine("Cancelaste el proceso");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
