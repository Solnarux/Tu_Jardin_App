#pragma checksum "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Cuenta\EditarImagen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3608c6f545792fb4791fe4a052b22628490db8"
// <auto-generated/>
#pragma warning disable 1591
namespace Tu_Jardin_App.Client.Pages.Cuenta
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cuenta/edit/{email}/imagen")]
    public partial class EditarImagen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/plantas.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page-background-class");
            __builder.AddMarkupContent(3, "<h3>Escoge Imagen</h3>\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "th");
            __builder.AddAttribute(7, "class", "caja");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", "/cuenta/edit/" + (
#nullable restore
#line 10 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Cuenta\EditarImagen.razor"
                                       email

#line default
#line hidden
#nullable disable
            ) + "?Img=/images/Perfil/fAgriJoven.png");
            __builder.AddMarkupContent(10, "<img class=\"imagen\" src=\"/images/Perfil/fAgriJoven.png\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "th");
            __builder.AddAttribute(13, "class", "caja");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "/cuenta/edit/" + (
#nullable restore
#line 13 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Cuenta\EditarImagen.razor"
                                       email

#line default
#line hidden
#nullable disable
            ) + "?Img=/images/Perfil/mAgriJoven.png");
            __builder.AddMarkupContent(16, "<img class=\"imagen\" src=\"/images/Perfil/mAgriJoven.png\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "th");
            __builder.AddAttribute(19, "class", "caja");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/cuenta/edit/" + (
#nullable restore
#line 16 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Cuenta\EditarImagen.razor"
                                       email

#line default
#line hidden
#nullable disable
            ) + "?Img=/images/Perfil/fAgriMayor.png");
            __builder.AddMarkupContent(22, "<img class=\"imagen\" src=\"/images/Perfil/fAgriMayor.png\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "th");
            __builder.AddAttribute(25, "class", "caja");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/cuenta/edit/" + (
#nullable restore
#line 19 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Cuenta\EditarImagen.razor"
                                       email

#line default
#line hidden
#nullable disable
            ) + "?Img=/images/Perfil/mAgriMayor.png");
            __builder.AddMarkupContent(28, "<img class=\"imagen\" src=\"/images/Perfil/mAgriMayor.png\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "th");
            __builder.AddAttribute(31, "class", "caja");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "/cuenta/edit/" + (
#nullable restore
#line 22 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Cuenta\EditarImagen.razor"
                                       email

#line default
#line hidden
#nullable disable
            ) + "?Img=/images/Perfil/ImageUsuario.png");
            __builder.AddMarkupContent(34, "<img class=\"imagen\" src=\"/images/Perfil/ImageUsuario.png\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Cuenta\EditarImagen.razor"
       

    [Parameter]
    public string email { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
