#pragma checksum "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25264331c6ca8af6ea7b4da5527aa163f83ef9de"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AgendaBeleza.Pages.MinhasPaginas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using AgendaBeleza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\_Imports.razor"
using AgendaBeleza.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
using DadosAcesso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
using DadosAcesso.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Agendamento")]
    public partial class Agendamento : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
       
    private List<AgendamentoModels> agendamentos;
  

    protected override async Task OnInitializedAsync()
    {
        agendamentos = await _db.GetAgendamentos();       
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAgendamentoDados _db { get; set; }
    }
}
#pragma warning restore 1591
