#pragma checksum "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43c04fdc845a9c06e7cacc68d6cac21de7c29357"
// <auto-generated/>
#pragma warning disable 1591
namespace AgendaBeleza.Pages
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
#line 2 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor"
using DadosAcesso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor"
using DadosAcesso.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Bem-vindo a agenda da Beleza</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>A sua agenda de beleza na palma da sua mão!</p>\r\n\r\n");
            __builder.AddMarkupContent(2, "<section>\r\n    <div class=\"div-cadastre-se\">\r\n        <h4>Cadastre-se</h4>\r\n        <p>Aqui você faz seu cadastro no Agenda Beleza e fica por dentro das nossas novidades!</p>\r\n    </div>\r\n</section>\r\n\r\n<br><br><br><br><br>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor"
                 _agendar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor"
                                           Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "login");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<label>Usuário:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "usuario");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor"
                                              Usuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario = __value, Usuario))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "<br>\r\n        ");
                __builder2.AddMarkupContent(18, "<label>Senha:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "senha");
                __builder2.AddAttribute(21, "type", "password");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor"
                                            Senha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Senha = __value, Senha))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Senha));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "<br>\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(26, "<button type=\"submit\">Fazer Agendamento</button>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(29, @"<style>
    .div-cadastre-se {
        background: purple;
        color: white;
        border-radius: 5px;
        border: 1px solid gray;
        text-align: center;
        width: 150px;
        height: 150px;
        font-size: 15px;
    }

    .login{
        border: 2px solid blue;
        text-align: center;
        width: 300px;
        height: 300px;
       margin-left: 500px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Temp\C#\AgendaBeleza\AgendaBeleza\AgendaBeleza\Pages\Index.razor"
      
    private InsereAgendamentoModels _agendar = new InsereAgendamentoModels();
    private string Usuario { get; set; }
    private string Senha { get; set; }

    private void Submit()
    {
        //_agendar
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAgendamentoDados _db { get; set; }
    }
}
#pragma warning restore 1591
