#pragma checksum "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be96d8499e1813fb715b6448d489095a0635ffe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
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
#line 1 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be96d8499e1813fb715b6448d489095a0635ffe6", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c593e2973db2472dd8ea7ea162ebc292929aa7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n        <h6 class=\"p-3 mb-0\">Bildirimler</h6>\r\n");
#nullable restore
#line 6 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml"
         foreach (var item in Model)
        {
            if (item.NotificationStatus == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"dropdown-divider\"></div>\r\n            <a class=\"dropdown-item preview-item\">\r\n                <div class=\"preview-thumbnail\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 509, "\"", 540, 1);
#nullable restore
#line 13 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 517, item.NotificationColor, 517, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 570, "\"", 606, 1);
#nullable restore
#line 14 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 578, item.NotificationTypeSymbol, 578, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    </div>\r\n                </div>\r\n                <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                    <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 18 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                                   Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 19 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                   Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 22 "C:\Users\orhan\OneDrive\Masaüstü\Yazilim\NetCore\NetCore\Views\Shared\Components\WriterNotification\Default.cshtml"
        }
       
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <h6 class=\"p-3 mb-0 text-center\">Tüm Bildirimleri Gör</h6>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
