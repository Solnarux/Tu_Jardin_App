#pragma checksum "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf229768b33374037119659082e353e7bb3b1b89"
// <auto-generated/>
#pragma warning disable 1591
namespace Tu_Jardin_App.Client.Pages.Logros
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/logros/{id:int}/vida")]
    public partial class Vida : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/plantasusuario.css\" rel=\"stylesheet\">\r\n<link href=\"/css/logro.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page-background-class");
#nullable restore
#line 8 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
     if (planta.Achievements == null)
    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div class=\"usuariocard\"><h4> Loading... </h4></div>");
#nullable restore
#line 14 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"

    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "usuariocard");
            __builder.AddMarkupContent(6, "<h4> Vida </h4>\r\n            <img src=\"/images/logros/vida.png\" class=\"imagen\">\r\n            ");
            __builder.AddMarkupContent(7, "<p class=\"info\">XP: <u>150</u></p>\r\n            ");
            __builder.AddMarkupContent(8, "<p class=\"info\">Aplica fertilizantes que ayuden a tu cultivo</p>\r\n\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "center");
#nullable restore
#line 25 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                 if (!planta.Achievements.Vida)
                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/logros/" + (
#nullable restore
#line 28 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                                      planta.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn btn-success");
            __builder.AddAttribute(14, "style", "width: 20vw");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                                                                                                       ()=>HandleCompletition(planta.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, " Completar ");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/logros/" + (
#nullable restore
#line 32 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                                      planta.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "btn btn-outline-success");
            __builder.AddAttribute(20, "style", "width: 20vw");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                                                                                                               ()=>HandleIncompletition(planta.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, " Completado ");
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<br>\r\n                <br>\r\n                ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "/logros/" + (
#nullable restore
#line 36 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
                                  planta.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddAttribute(27, "style", "width: 20vw");
            __builder.AddContent(28, " Volver ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\laura\Desktop\Jardin\Tu_Jardin_App\Client\Pages\Logros\Vida.razor"
       

    [CascadingParameter]
    public Task<AuthenticationState> _authstate { get; set; }

    [Parameter]
    public int id { get; set; }

    public AuthenticationState authstate { get; set; }

    User user = new User();

    Plant planta = new Plant();

    protected override async Task OnInitializedAsync()
    {
        authstate = await _authstate;

        user = await PlantService.GetUser(authstate.User.Identity.Name);

        planta = await PlantService.GetPlant(id);
    }

    async void HandleCompletition(int id)
    {

        planta.Achievements.Vida = true;
        user.Points += 150;

        await PlantService.UpdateUser(user, user.Email);

        await PlantService.UpdateAchieve(planta.Achievements, planta.AchievementsId);

    }

    async void HandleIncompletition(int id)
    {
        planta.Achievements.Vida = false;
        user.Points -= 150;

        await PlantService.UpdateUser(user, user.Email);

        await PlantService.UpdateAchieve(planta.Achievements, planta.AchievementsId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService PlantService { get; set; }
    }
}
#pragma warning restore 1591
