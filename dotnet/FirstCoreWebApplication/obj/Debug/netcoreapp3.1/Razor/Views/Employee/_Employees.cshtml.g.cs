#pragma checksum "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b9005955b5d2ec3910aa4ab1abc690c4964e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee__Employees), @"mvc.1.0.view", @"/Views/Employee/_Employees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b9005955b5d2ec3910aa4ab1abc690c4964e1a", @"/Views/Employee/_Employees.cshtml")]
    public class Views_Employee__Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n  <table>\n    <thead>\n      <tr>\n        <th scope=\"col\">#</th>\n        <th scope=\"col\">Name</th>\n        <th scope=\"col\">DOB</th>\n        <th scope=\"col\">Salary</th>\n      </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 13 "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml"
       foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\n        <th><a asp-controller=\"Employee\" asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 332, "\"", 363, 1);
#nullable restore
#line 15 "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml"
WriteAttributeValue("", 347, item.EmployeeId, 347, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml"
                                                                                       Write(item.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </th>\n        <td>");
#nullable restore
#line 16 "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml"
       Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 17 "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml"
       Write(item.EmployeeDob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 18 "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml"
       Write(item.EmployeeSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      </tr>\n");
#nullable restore
#line 20 "/home/abhishek/abhishek-netsol/git/training/dotnet/FirstCoreWebApplication/Views/Employee/_Employees.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
