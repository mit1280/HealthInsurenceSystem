#pragma checksum "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3502325b4ad3fddb2083710e99504a24e83f59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agent_Sold), @"mvc.1.0.view", @"/Views/Agent/Sold.cshtml")]
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
#line 1 "D:\GitHub\HIS\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\HIS\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3502325b4ad3fddb2083710e99504a24e83f59", @"/Views/Agent/Sold.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e2e8eff2f278ec56cd155b82857607914793b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Agent_Sold : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthInsurenceSystem.Models.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f3502325b4ad3fddb2083710e99504a24e83f594177", async() => {
                WriteLiteral("\r\n\r\n    <title>\r\n        Sold Policies Details\r\n    </title>\r\n");
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
            WriteLiteral("\r\n\r\n<div class=\"container p-3\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\"> Policies List</h2>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <br /> <br />\r\n\r\n");
#nullable restore
#line 20 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
     if (Model.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">

            <thead>
                <tr>
                    <th>
                        Customer Email
                    </th>
                    <th>
                        Policy Number
                    </th>
                    <th>
                        Ptype
                    </th>
                    <th>
                        Sold Date
                    </th>
                    <th>
                        Last Payment Date
                    </th>
                    <th>
                        Monthly Amount
                    </th>
                    <th>
                        Remaining Duration
                    </th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 52 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"15%\">");
#nullable restore
#line 55 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                                   Write(obj.Cemail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"10%\">");
#nullable restore
#line 56 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                                   Write(obj.Pnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"10%\">");
#nullable restore
#line 57 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                                   Write(obj.Ptype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"10%\">");
#nullable restore
#line 58 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                                   Write(obj.Purchaseddate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"10%\">");
#nullable restore
#line 59 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                                   Write(obj.Lastpayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"10%\">");
#nullable restore
#line 60 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                                   Write(obj.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"10%\">");
#nullable restore
#line 61 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                                   Write(obj.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f3502325b4ad3fddb2083710e99504a24e83f599017", async() => {
                WriteLiteral("Go to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No new Policy exists</p>\r\n");
#nullable restore
#line 72 "D:\GitHub\HIS\HealthInsurenceSystem\Views\Agent\Sold.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthInsurenceSystem.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
