#pragma checksum "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35971dd341921d3af42268d93c0a5a240c5e8f1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicant_Details), @"mvc.1.0.view", @"/Views/Applicant/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35971dd341921d3af42268d93c0a5a240c5e8f1a", @"/Views/Applicant/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf5bc95cb5e82e85e2334780f4af49ff03ee4a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicant_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobSearch.Models.Applicant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; margin-left: 15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("descriptive image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Portrait_Placeholder.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("resume"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("special"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Accept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Decline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applicant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
Write(Html.DisplayFor(model => model.ApplicationUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.ApplicationUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (!String.IsNullOrEmpty(Model.ImagePath))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35971dd341921d3af42268d93c0a5a240c5e8f1a9182", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 489, "~/images/", 489, 9, true);
#nullable restore
#line 17 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
AddHtmlAttributeValue("", 498, Model.ImagePath, 498, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 19 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35971dd341921d3af42268d93c0a5a240c5e8f1a11099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 25 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            First Name\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Last Name\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 41 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (Model.ApplicationUser.LocationId == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Location:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                Add your location here!\r\n            </dd>\r\n");
#nullable restore
#line 49 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Location:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 56 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
           Write(Html.DisplayFor(modelItem => Model.ApplicationUser.Location.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 58 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (Model.Email == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Email:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                <p>Add your email here!</p>\r\n            </dd>\r\n");
#nullable restore
#line 68 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Email:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2092, "\"", 2148, 2);
            WriteAttributeValue("", 2099, "mailto:", 2099, 7, true);
#nullable restore
#line 75 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
WriteAttributeValue("", 2106, Html.DisplayFor(modelItem => Model.Email), 2106, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"contactText\"> ");
#nullable restore
#line 75 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </dd>\r\n");
#nullable restore
#line 77 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (Model.SocialLink == null)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Social Link\r\n            </dt>\r\n");
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                No social link provided\r\n            </dd>\r\n");
#nullable restore
#line 88 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"

        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Social Link\r\n            </dt>\r\n");
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2662, "\"", 2723, 2);
            WriteAttributeValue("", 2669, "http://", 2669, 7, true);
#nullable restore
#line 98 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
WriteAttributeValue("", 2676, Html.DisplayFor(modelItem => Model.SocialLink), 2676, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"contactText\">");
#nullable restore
#line 98 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
                                                                                                Write(Html.DisplayFor(modelItem => Model.SocialLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </dd>\r\n");
#nullable restore
#line 100 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (Model.Education == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Education\r\n            </dt>\r\n");
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                No education provided\r\n            </dd>\r\n");
#nullable restore
#line 111 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Education\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n\r\n                ");
#nullable restore
#line 120 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 122 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (Model.Experience == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Experience\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                No experience provided\r\n            </dd>\r\n");
#nullable restore
#line 132 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Experience\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 139 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 141 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (Model.SkillsAndCertifications == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Skills and Certifications\r\n            </dt>\r\n");
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                No skills or certifications provided\r\n            </dd>\r\n");
#nullable restore
#line 151 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Skills and Certifications\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 159 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
           Write(Html.DisplayFor(modelItem => Model.SkillsAndCertifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 161 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
         if (Model.ResumePath == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Resume Link:\r\n            </dt>\r\n");
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                No resume provided\r\n            </dd>\r\n");
#nullable restore
#line 171 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Resume Link:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35971dd341921d3af42268d93c0a5a240c5e8f1a23042", async() => {
                WriteLiteral("Resume");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4747, "~/images/", 4747, 9, true);
#nullable restore
#line 178 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
AddHtmlAttributeValue("", 4756, Html.DisplayFor(modelItem => Model.ResumePath), 4756, 47, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 183 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n\r\n");
#nullable restore
#line 187 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
 if (UserManager.GetUserAsync(User).Result.IsEmployer == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row float-right\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35971dd341921d3af42268d93c0a5a240c5e8f1a25396", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" ");
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Accept\" class=\"btn btn-success\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35971dd341921d3af42268d93c0a5a240c5e8f1a27213", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" ");
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Decline\" class=\"btn btn-danger\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 202 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
}


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 225 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
     if (UserManager.GetUserAsync(User).Result.IsEmployer == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35971dd341921d3af42268d93c0a5a240c5e8f1a29509", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 228 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 229 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
     if (UserManager.GetUserAsync(User).Result.IsEmployer == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35971dd341921d3af42268d93c0a5a240c5e8f1a31395", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 232 "C:\Users\gilde\workspace\csharp\JobSearch\Views\Applicant\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobSearch.Models.Applicant> Html { get; private set; }
    }
}
#pragma warning restore 1591
