#pragma checksum "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c6d5056223627df1be3e68a1b7bd4c33728b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
#line 1 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/_ViewImports.cshtml"
using DataAnnotationInMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/_ViewImports.cshtml"
using DataAnnotationInMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c6d5056223627df1be3e68a1b7bd4c33728b25", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e410a77d87bd5530485d1485fd2778ed86c149", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAnnotationInMVC.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
  
ViewBag.Title = "Create Employee";
Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Create Employee</h2>\n\n");
#nullable restore
#line 10 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n  <hr />\n  ");
#nullable restore
#line 16 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 18 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 20 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 21 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 26 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 28 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 29 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 34 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.Age, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 36 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.Age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 37 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.Age, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 42 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.DateOfBirth, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 44 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 45 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 50 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 52 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 53 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 58 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.Mobile, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 60 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.Mobile, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 61 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.Mobile, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 66 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.PostalCode, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 68 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.PostalCode, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 69 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.PostalCode, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 74 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.EmailId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 76 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.EmailId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 77 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.EmailId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 82 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 84 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 85 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 90 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 92 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 93 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 98 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.ConfirmPassword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 100 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.ConfirmPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 101 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    ");
#nullable restore
#line 106 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
Write(Html.LabelFor(model => model.URL, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"col-md-10\">\n      ");
#nullable restore
#line 108 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.EditorFor(model => model.URL, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 109 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
 Write(Html.ValidationMessageFor(model => model.URL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n\n  <div class=\"form-group\">\n    <div class=\"col-md-offset-2 col-md-10\">\n      <input type=\"submit\" value=\"Create\" class=\"btn btn-danger\" />\n    </div>\n  </div>\n</div>\n");
#nullable restore
#line 119 "/home/abhishek/netsol/git/training/dotnet/DataAnnotationInMVC/Views/Employee/Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAnnotationInMVC.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
