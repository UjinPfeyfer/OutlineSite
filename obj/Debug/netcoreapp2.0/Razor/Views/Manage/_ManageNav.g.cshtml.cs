#pragma checksum "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02e491b8d627d99fc33e7f06c5f10c44ea486e5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__ManageNav), @"mvc.1.0.view", @"/Views/Manage/_ManageNav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_ManageNav.cshtml", typeof(AspNetCore.Views_Manage__ManageNav))]
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
#line 1 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\_ViewImports.cshtml"
using Challenge24;

#line default
#line hidden
#line 3 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\_ViewImports.cshtml"
using Challenge24.Models;

#line default
#line hidden
#line 4 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\_ViewImports.cshtml"
using Challenge24.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\_ViewImports.cshtml"
using Challenge24.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
using Challenge24.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02e491b8d627d99fc33e7f06c5f10c44ea486e5a", @"/Views/Manage/_ManageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c82cf9061ee018e8c755620c631024bbfbca4d1", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"921ed29cb3064b9ce7a32006dbe8d2231d2c561d", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__ManageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TwoFactorAuthentication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
            BeginContext(192, 49, true);
            WriteLiteral("\r\n<ul class=\"nav nav-pills nav-stacked\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 241, "\"", 291, 1);
#line 8 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 249, ManageNavPages.IndexNavClass(ViewContext), 249, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(292, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(293, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9d991dcb857485ebfe2cbb9d83ca6a3", async() => {
                BeginContext(315, 7, true);
                WriteLiteral("Profile");
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
            BeginContext(326, 14, true);
            WriteLiteral("</li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 340, "\"", 399, 1);
#line 9 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 348, ManageNavPages.ChangePasswordNavClass(ViewContext), 348, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(400, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(401, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95432803439a474bba162ea6e6baf611", async() => {
                BeginContext(432, 8, true);
                WriteLiteral("Password");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(444, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 10 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
     if (hasExternalLogins)
    {

#line default
#line hidden
            BeginContext(487, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 498, "\"", 557, 1);
#line 12 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 506, ManageNavPages.ExternalLoginsNavClass(ViewContext), 506, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(558, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(559, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48872ed7cbab47deac20bb27cd26ef88", async() => {
                BeginContext(590, 15, true);
                WriteLiteral("External logins");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(609, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 13 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
    }

#line default
#line hidden
            BeginContext(623, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 630, "\"", 698, 1);
#line 14 "C:\Users\Евгений\source\repos\Challenge24\Challenge24\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 638, ManageNavPages.TwoFactorAuthenticationNavClass(ViewContext), 638, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(699, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(700, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "becf780432954058aa25d014288c996e", async() => {
                BeginContext(740, 25, true);
                WriteLiteral("Two-factor authentication");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(769, 16, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
