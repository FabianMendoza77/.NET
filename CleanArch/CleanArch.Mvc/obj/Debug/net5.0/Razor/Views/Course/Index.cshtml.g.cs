#pragma checksum "E:\.NET\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8d7f46c99a285f11df453ae75b974b0e965923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "E:\.NET\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NET\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8d7f46c99a285f11df453ae75b974b0e965923", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"027205748dfe4dbb887f431c275ff0eb9bf51e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CleanArch.Application.ViewModels.CourseViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <div class=\"container body-content\" >\n        <div class=\"row course-content\">\n");
#nullable restore
#line 5 "E:\.NET\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
             foreach (var course in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"course-image-container\">\n                    <div class=\"course-image\"");
            BeginWriteAttribute("style", " style=\"", 308, "\"", 354, 3);
            WriteAttributeValue("", 316, "background-image:url(", 316, 21, true);
#nullable restore
#line 8 "E:\.NET\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
WriteAttributeValue("", 337, course.ImageUrl, 337, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 353, ")", 353, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n                </div>\n");
            WriteLiteral("                <span>");
#nullable restore
#line 12 "E:\.NET\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
                 Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 13 "E:\.NET\CleanArch\CleanArch.Mvc\Views\Course\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CleanArch.Application.ViewModels.CourseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
