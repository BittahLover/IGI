// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication2.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using WebApplication2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using WebApplication2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\_Imports.razor"
using WebApplication2.Client.Models;

#line default
#line hidden
#nullable disable
    public partial class DishDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\University\third-year\IGI\lab1\WEB_953502_Vecherinsky\WebApplication2\Client\Components\DishDetails.razor"
       
    [Parameter]
    public DetailsViewModel Dish { get; set; }
    [Parameter]
    public EventCallback<DetailsViewModel> DishChanged { get; set; }
    string imageSrc
    {
        get
        {
            return $"images/{Dish.Image}";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591