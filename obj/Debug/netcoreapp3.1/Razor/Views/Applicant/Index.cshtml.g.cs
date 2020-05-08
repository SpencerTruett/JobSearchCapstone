#pragma checksum "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a676b3d44ae648222f269ded84878b3083c38f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicant_Index), @"mvc.1.0.view", @"/Views/Applicant/Index.cshtml")]
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
#line 1 "C:\Users\gilde\workspace\csharp\JobSearch\Views\_ViewImports.cshtml"
using JobSearch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gilde\workspace\csharp\JobSearch\Views\_ViewImports.cshtml"
using JobSearch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a676b3d44ae648222f269ded84878b3083c38f2f", @"/Views/Applicant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf5bc95cb5e82e85e2334780f4af49ff03ee4a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobSearch.Models.ViewModels.ApplicantJobViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Job Statuses</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 15 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Job.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Company Name\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Job.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                 foreach (var item in Model.Jobs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 31 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                       Write(Html.ActionLink(item.Position, "Details", "Job", new { id = item.Id }, new { area = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 34 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                       Write(Html.ActionLink(item.Company.CompanyName, "Details", "Company", new { id = item.Id }, new { area = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 37 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            WriteLiteral("                            ");
#nullable restore
#line 40 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobSearch.Models.ViewModels.ApplicantJobViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
