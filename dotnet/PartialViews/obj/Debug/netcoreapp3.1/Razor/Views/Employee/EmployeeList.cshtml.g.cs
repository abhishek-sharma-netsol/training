#pragma checksum "/home/abhishek/abhishek-netsol/git/training/dotnet/PartialViews/Views/Employee/EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3131970962a954a04a7c390e8b690b1d504a1c88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeList), @"mvc.1.0.view", @"/Views/Employee/EmployeeList.cshtml")]
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
#line 1 "/home/abhishek/abhishek-netsol/git/training/dotnet/PartialViews/Views/_ViewImports.cshtml"
using PartialViews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/abhishek/abhishek-netsol/git/training/dotnet/PartialViews/Views/_ViewImports.cshtml"
using PartialViews.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3131970962a954a04a7c390e8b690b1d504a1c88", @"/Views/Employee/EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88014eac6917b23d6104b27010c28e2e72f59319", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<b>Employee List</b>\r\n<br>\r\n<br>\r\n<div class=\"container\">\r\n  ");
#nullable restore
#line 7 "/home/abhishek/abhishek-netsol/git/training/dotnet/PartialViews/Views/Employee/EmployeeList.cshtml"
Write(Html.Partial("_Employees", Model.Employees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<!--<!DOCTYPE html>-->\r\n\r\n<!--<html>-->\r\n\r\n<!--<head>-->\r\n<!--  <meta name=\"viewport\" content=\"width=device-width\" />-->\r\n<!--  <title>EmployeeList</title>-->\r\n<!--</head>-->\r\n\r\n<!--<body>-->\r\n<!--</body>-->\r\n\r\n<!--</html>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
