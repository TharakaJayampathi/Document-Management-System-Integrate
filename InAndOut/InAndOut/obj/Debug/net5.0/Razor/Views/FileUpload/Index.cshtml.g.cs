#pragma checksum "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6516655d3bb46beec6a7965e1a1bcf42d164a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileUpload_Index), @"mvc.1.0.view", @"/Views/FileUpload/Index.cshtml")]
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
#line 1 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6516655d3bb46beec6a7965e1a1bcf42d164a46", @"/Views/FileUpload/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68bf42a2f6da1b0bba0ff4b16a23c8e4ecef32e", @"/Views/_ViewImports.cshtml")]
    public class Views_FileUpload_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InAndOut.Models.FileUpload>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FileUpload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Multiple Type Document Upload (Doc/ Pdf/ Pptx/ Xlsx/ Jpg/ MP4)</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6516655d3bb46beec6a7965e1a1bcf42d164a465074", async() => {
                WriteLiteral("\r\n    <p>\r\n        <input type=\"file\" name=\"fileobj\" />\r\n        <input type=\"submit\" value=\"Upload\" />\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n");
                WriteLiteral("                    Document Id\r\n                </th>\r\n                <th>\r\n");
                WriteLiteral("                    Document Name\r\n                </th>\r\n");
                WriteLiteral("                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Imgid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Imgname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <!--<td>\r\n                        <img src=\"~/Files/");
#nullable restore
#line 42 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
                                     Write(item.Imgname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" height=\"80\" width=\"120\" />-->\r\n");
                WriteLiteral("                    <!--</td>-->\r\n                    <td>\r\n");
                WriteLiteral("                        ");
#nullable restore
#line 49 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id=item.Imgid }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 50 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id=item.Imgid }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 51 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id=item.Imgid }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Tharaka Jayampathi\Desktop\Integration - Final\New folder (2)\KM-Project-Integrate\InAndOut\InAndOut\Views\FileUpload\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InAndOut.Models.FileUpload>> Html { get; private set; }
    }
}
#pragma warning restore 1591
