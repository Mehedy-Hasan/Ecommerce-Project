#pragma checksum "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9647010174f264e7335b3f70db4342078396aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
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
#line 1 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\_ViewImports.cshtml"
using HelloCoreMVCApp;

#line default
#line hidden
#line 2 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\_ViewImports.cshtml"
using HelloCoreMVCApp.Models;

#line default
#line hidden
#line 1 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\Customer\Details.cshtml"
using Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db9647010174f264e7335b3f70db4342078396aa", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"718a8991d7cb7a1b3938a32c96db56e3e8fb5649", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\Customer\Details.cshtml"
  
    Layout = "_MyLayout";

    Customer customer = ViewBag.Customer;

#line default
#line hidden
            BeginContext(120, 27, true);
            WriteLiteral("\r\n\r\n    <div>\r\n        <h4>");
            EndContext();
            BeginContext(148, 13, false);
#line 12 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\Customer\Details.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(161, 152, true);
            WriteLiteral("</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                Name\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(314, 18, false);
#line 19 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\Customer\Details.cshtml"
           Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(332, 117, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Address\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(450, 13, false);
#line 25 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\Customer\Details.cshtml"
           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(463, 78, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n\r\n\r\n\r\n \r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(542, 66, false);
#line 35 "D:\Master Details\HelloCoreMVCApp\HelloCoreMVCApp\Views\Customer\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new {/* id = Model.PrimaryKey */}));

#line default
#line hidden
            EndContext();
            BeginContext(608, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(620, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee641e0f07fd4ff58c8cdaa2b314dc71", async() => {
                BeginContext(642, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(658, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
