#pragma checksum "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "938a8f34a074c6b0d0d3d509b313c948d2f7192c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
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
#line 1 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\_ViewImports.cshtml"
using NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\_ViewImports.cshtml"
using NetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
using static NetCore.Controllers.EmployeeTestController;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"938a8f34a074c6b0d0d3d509b313c948d2f7192c", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c593e2973db2472dd8ea7ea162ebc292929aa7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Adı Soyadı</th>\r\n        <th>Sil</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\n           <td>");
#nullable restore
#line 20 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
          Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 21 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 463, "\"", 507, 2);
            WriteAttributeValue("", 470, "/EmployeeTest/DeleteEmployee/", 470, 29, true);
#nullable restore
#line 22 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 499, item.ID, 499, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 572, "\"", 614, 2);
            WriteAttributeValue("", 579, "/EmployeeTest/EditEmployee/", 579, 27, true);
#nullable restore
#line 23 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 606, item.ID, 606, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n       </tr>\n");
#nullable restore
#line 25 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\EmployeeTest\Index.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/EmployeeTest/AddEmployee/\" class=\"btn btn-outline-primary\">Yeni Çalışan Ekle</a>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
