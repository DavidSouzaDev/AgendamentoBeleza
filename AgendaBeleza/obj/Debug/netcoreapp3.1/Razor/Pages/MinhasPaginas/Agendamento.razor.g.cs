#pragma checksum "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786b807e3ea030af12a5a5a7988f01e5d0f16b66"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Agendamento</h3>\r\n");
            __builder.AddMarkupContent(1, "<h4>Aqui você faz seu agendamento</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
 if(agendamento is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Carregando agendamentos</em></p>\r\n");
#nullable restore
#line 14 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Horário ínicio</th>\r\n                <th>Horário fim</th>\r\n                <th>Data e hora do agendamento</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
             foreach(var agendamento in agendamento)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
                         agendamento.HoraInicioAgendamento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
                         agendamento.HoraFimAgendamento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
                         agendamento.DiaHoraAgendamento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 33 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 36 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\MinhasPaginas\Agendamento.razor"
       
    private List<AgendamentoModels> agendamento;

    protected override async Task OnInitializedAsync()
    {
        agendamento = await _db.GetAgendamentos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAgendamentoDados _db { get; set; }
    }
}
#pragma warning restore 1591