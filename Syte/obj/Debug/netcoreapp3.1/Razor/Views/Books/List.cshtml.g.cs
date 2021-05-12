#pragma checksum "D:\UnikProject\Syte\Views\Books\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46361016764acda2acca918304a008e081c63e54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_List), @"mvc.1.0.view", @"/Views/Books/List.cshtml")]
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
#line 1 "D:\UnikProject\Syte\Views\_ViewImports.cshtml"
using Syte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UnikProject\Syte\Views\_ViewImports.cshtml"
using Syte.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\UnikProject\Syte\Views\_ViewImports.cshtml"
using Syte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46361016764acda2acca918304a008e081c63e54", @"/Views/Books/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71da6508be009ae0087c5768c8038f7bf63ab988", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46361016764acda2acca918304a008e081c63e543210", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>List</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46361016764acda2acca918304a008e081c63e544268", async() => {
                WriteLiteral("\r\n    <h1>Все книги</h1>\r\n    <h3>");
#nullable restore
#line 7 "D:\UnikProject\Syte\Views\Books\List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <div class = \"row mt-5 mb-2\">\r\n");
#nullable restore
#line 9 "D:\UnikProject\Syte\Views\Books\List.cshtml"
           
            foreach (var book in Model.AllBooks)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-lg-4\">\r\n            <img class= \"img-thumbnail\"");
                BeginWriteAttribute("src", " src=\"", 354, "\"", 371, 1);
#nullable restore
#line 13 "D:\UnikProject\Syte\Views\Books\List.cshtml"
WriteAttributeValue("", 360, book.Image, 360, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 372, "\"", 388, 1);
#nullable restore
#line 13 "D:\UnikProject\Syte\Views\Books\List.cshtml"
WriteAttributeValue("", 378, book.Name, 378, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            <h2>");
#nullable restore
#line 14 "D:\UnikProject\Syte\Views\Books\List.cshtml"
           Write(book.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <h5>");
#nullable restore
#line 15 "D:\UnikProject\Syte\Views\Books\List.cshtml"
           Write(book.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <p>");
#nullable restore
#line 16 "D:\UnikProject\Syte\Views\Books\List.cshtml"
          Write(book.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p><a class=\"btn btn-warning\" href=\"#\">Читать</a></p>\r\n        </div>\r\n");
#nullable restore
#line 19 "D:\UnikProject\Syte\Views\Books\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <script scr=\"~/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
