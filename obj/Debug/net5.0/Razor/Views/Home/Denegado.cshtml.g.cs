#pragma checksum "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\Home\Denegado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308e2f74cfa335c6c8d7b3b598bcd4bb1f2f55bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Denegado), @"mvc.1.0.view", @"/Views/Home/Denegado.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\_ViewImports.cshtml"
using AppBootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\_ViewImports.cshtml"
using AppBootstrap.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308e2f74cfa335c6c8d7b3b598bcd4bb1f2f55bb", @"/Views/Home/Denegado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f427f5195ac2cfc56dc242b3d1d4ac905ae93d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Denegado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\Home\Denegado.cshtml"
  
    ViewData["Title"] = "Denegado";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2 class=""text-center m-2""> Eventos Para Ti </h2>



    <div class=""col-12 d-flex flex-column align-items-center flex-md-row flex-lg-row justify-content-md-center justify-content-lg-center align-items-md-start  align-items-lg-start"">
        <div class=""col-10 col-md-5 col-lg-3 bg-white p-3 border rounded m-4"">

            <h2 class=""text-center m-2""> ");
#nullable restore
#line 13 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\Home\Denegado.cshtml"
                                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" No esta autorizado para acceder </h2>\r\n        </div>\r\n\r\n\r\n        <div class=\"col-10 col-md-5 col-lg-7 bg-white p-3 border rounded m-4\">\r\n            //mostrar los datos de elusuario logeado\r\n            <ol>\r\n");
#nullable restore
#line 20 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\Home\Denegado.cshtml"
                 foreach (var c in User.Claims)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\Home\Denegado.cshtml"
                   Write(c.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 23 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\Home\Denegado.cshtml"
                            Write(c.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 25 "C:\Users\Usuario\Documents\SENA\NET2\AppBootstrap\Views\Home\Denegado.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ol>\r\n           \r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
