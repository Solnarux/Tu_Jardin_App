#pragma checksum "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87d1dcf7c674e97d177516456860eaf1a619ff1"
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
#line 1 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\_Imports.razor"
using Tu_Jardin_App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cuenta")]
    public partial class Perfil : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/plantas.css\" rel=\"stylesheet\">\r\n<link href=\"/css/perfil.css\" rel=\"stylesheet\">\r\n<meta charset=\"utf-8\">");
#nullable restore
#line 8 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
 if(user == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p> Loading... </p>");
#nullable restore
#line 11 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
            }
else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-background-class");
            __builder.AddMarkupContent(4, "<h3>Cuenta</h3>\r\n                ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content_general");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content_principal");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content_1");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content_img");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 21 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
                                          user.Img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "image_Usuario");
            __builder.AddAttribute(16, "alt", "Imagen Usuario");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n                            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content_datos");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "usuario_Nombre");
            __builder.AddContent(22, 
#nullable restore
#line 25 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
                                                              user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, " <br><br>\r\n\r\n                                ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "/cuenta/edit/" + (
#nullable restore
#line 27 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
                                                       user.Email

#line default
#line hidden
#nullable disable
            ) + "?Img=" + (
#nullable restore
#line 27 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
                                                                       user.Img

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddContent(27, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.AddMarkupContent(29, "<a href=\"/cuenta/delete\" class=\"btn btn-outline-danger\" style=\"text-align: center;\"> Eliminar </a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "content_2");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "content_items");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "item_1");
            __builder.AddMarkupContent(37, "<div class=\"img_item\"><img src=\"/images/Perfil/planta.png\" alt=\"Image_1\" class=\"imageitem\"></div>\r\n\r\n                                    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "content_info");
            __builder.AddMarkupContent(40, "<label>Plantas</label>\r\n                                        ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "href", "/plantas");
            __builder.AddAttribute(43, "class", "btn btn-outline-success");
            __builder.AddContent(44, 
#nullable restore
#line 44 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
                                                                                            user.Plants

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n                                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "item_2");
            __builder.AddMarkupContent(48, "<div class=\"img_item\"><img src=\"/images/Perfil/copa.png\" alt=\"Image_2\" class=\"imageitem\"></div>\r\n\r\n\r\n                                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "content_info");
            __builder.AddMarkupContent(51, "<label>Logros</label>\r\n                                        ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "href", "/logros");
            __builder.AddAttribute(54, "class", "btn btn-outline-success");
            __builder.AddContent(55, 
#nullable restore
#line 56 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
                                                                                           user.Points

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\solna\Source\Repos\Solnarux\Tu_Jardin_App\Tu_Jardin_App\Client\Pages\Cuenta\Perfil.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }

    public AuthenticationState authState { get; set; }

    User user = new User();

    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;

        user = await PlantService.GetUser(authState.User.Identity.Name);

    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService PlantService { get; set; }
    }
}
#pragma warning restore 1591
