#pragma checksum "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b3819d4c32db03674e31d293c9fe60c06829694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_List), @"mvc.1.0.view", @"/Views/List/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/List.cshtml", typeof(AspNetCore.Views_List_List))]
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
#line 1 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web;

#line default
#line hidden
#line 2 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web.Models;

#line default
#line hidden
#line 4 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b3819d4c32db03674e31d293c9fe60c06829694", @"/Views/List/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df02d679023bc56e9cc697f1d66d605b9a4371f2", @"/Views/_ViewImports.cshtml")]
    public class Views_List_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "id-sort-normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "id-sort-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date-sort-normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date-sort-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "name-sort-normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "name-sort-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "domain-sort-normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "domain-sort-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "country-sort-normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "country-sort-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
  
    ViewData["Title"] = Localizer["List"];

#line default
#line hidden
            BeginContext(53, 198, true);
            WriteLiteral("<div class=\"container d-flex justify-content-center\">\r\n    <div class=\"wide-board\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                <h1 class=\"text-center\">");
            EndContext();
            BeginContext(252, 17, false);
#line 9 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                   Write(Localizer["List"]);

#line default
#line hidden
            EndContext();
            BeginContext(269, 196, true);
            WriteLiteral("</h1>\r\n                <hr />\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-3\">\r\n                <div class=\"form-check\">\r\n                    <label>");
            EndContext();
            BeginContext(466, 24, false);
#line 16 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                      Write(Localizer["Just online"]);

#line default
#line hidden
            EndContext();
            BeginContext(490, 187, true);
            WriteLiteral(" ?</label>\r\n                    <input type=\"checkbox\" id=\"status\" class=\"form-check-label\">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                ");
            EndContext();
            BeginContext(678, 20, false);
#line 21 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
           Write(Localizer["Sorting"]);

#line default
#line hidden
            EndContext();
            BeginContext(698, 93, true);
            WriteLiteral(":\r\n                <select id=\"sorter\" class=\"listing-select\">\r\n                    <optgroup");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 791, "\"", 815, 1);
#line 23 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
WriteAttributeValue("", 799, Localizer["Id"], 799, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(816, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(843, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c068296949265", async() => {
                BeginContext(875, 23, false);
#line 24 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                  Write(Localizer["Decreasing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(907, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(933, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969410816", async() => {
                BeginContext(963, 20, false);
#line 25 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                Write(Localizer["Growing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(992, 64, true);
            WriteLiteral("\r\n                    </optgroup>\r\n                    <optgroup");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 1056, "\"", 1082, 1);
#line 27 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
WriteAttributeValue("", 1064, Localizer["Date"], 1064, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1083, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1110, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969412822", async() => {
                BeginContext(1144, 23, false);
#line 28 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                    Write(Localizer["Decreasing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1176, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1202, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969414379", async() => {
                BeginContext(1234, 20, false);
#line 29 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                  Write(Localizer["Growing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1263, 64, true);
            WriteLiteral("\r\n                    </optgroup>\r\n                    <optgroup");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 1327, "\"", 1353, 1);
#line 31 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
WriteAttributeValue("", 1335, Localizer["Name"], 1335, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1354, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1381, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969416389", async() => {
                BeginContext(1415, 23, false);
#line 32 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                    Write(Localizer["Decreasing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1447, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1473, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969417946", async() => {
                BeginContext(1505, 20, false);
#line 33 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                  Write(Localizer["Growing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1534, 64, true);
            WriteLiteral("\r\n                    </optgroup>\r\n                    <optgroup");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 1598, "\"", 1626, 1);
#line 35 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
WriteAttributeValue("", 1606, Localizer["Domain"], 1606, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1627, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1654, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969419958", async() => {
                BeginContext(1690, 23, false);
#line 36 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                      Write(Localizer["Decreasing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1722, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1748, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969421517", async() => {
                BeginContext(1782, 20, false);
#line 37 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                    Write(Localizer["Growing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1811, 64, true);
            WriteLiteral("\r\n                    </optgroup>\r\n                    <optgroup");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 1875, "\"", 1904, 1);
#line 39 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
WriteAttributeValue("", 1883, Localizer["Country"], 1883, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1905, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1932, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969423532", async() => {
                BeginContext(1969, 23, false);
#line 40 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                       Write(Localizer["Decreasing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2001, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2027, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969425092", async() => {
                BeginContext(2062, 20, false);
#line 41 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                                                     Write(Localizer["Growing"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2091, 263, true);
            WriteLiteral(@"
                    </optgroup>
                </select>
            </div>
        </div>
        <!--List start-->
        <!--List Head start-->
        <div class=""row text-center bg-head-color mb-2 font-weight-bold"">
            <div class=""col-1"">");
            EndContext();
            BeginContext(2355, 15, false);
#line 49 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                          Write(Localizer["Id"]);

#line default
#line hidden
            EndContext();
            BeginContext(2370, 40, true);
            WriteLiteral("</div>\r\n            <div class=\"col-2\"> ");
            EndContext();
            BeginContext(2411, 17, false);
#line 50 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                           Write(Localizer["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(2428, 39, true);
            WriteLiteral("</div>\r\n            <div class=\"col-3\">");
            EndContext();
            BeginContext(2468, 19, false);
#line 51 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                          Write(Localizer["Domain"]);

#line default
#line hidden
            EndContext();
            BeginContext(2487, 39, true);
            WriteLiteral("</div>\r\n            <div class=\"col-1\">");
            EndContext();
            BeginContext(2527, 20, false);
#line 52 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                          Write(Localizer["Country"]);

#line default
#line hidden
            EndContext();
            BeginContext(2547, 40, true);
            WriteLiteral("</div>\r\n            <div class=\"col-2\"> ");
            EndContext();
            BeginContext(2588, 19, false);
#line 53 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                           Write(Localizer["Online"]);

#line default
#line hidden
            EndContext();
            BeginContext(2607, 39, true);
            WriteLiteral("</div>\r\n            <div class=\"col-3\">");
            EndContext();
            BeginContext(2647, 22, false);
#line 54 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
                          Write(Localizer["Last seen"]);

#line default
#line hidden
            EndContext();
            BeginContext(2669, 144, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <!--List Head end-->\r\n        <div class=\"row text-center\" id=\"botlist\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2813, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b3819d4c32db03674e31d293c9fe60c0682969429286", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2864, 27, true);
            WriteLiteral("\r\n<script>\r\n    var yes = \'");
            EndContext();
            BeginContext(2892, 16, false);
#line 64 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
          Write(Localizer["Yes"]);

#line default
#line hidden
            EndContext();
            BeginContext(2908, 18, true);
            WriteLiteral("\';\r\n    var no = \'");
            EndContext();
            BeginContext(2927, 15, false);
#line 65 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
         Write(Localizer["No"]);

#line default
#line hidden
            EndContext();
            BeginContext(2942, 4420, true);
            WriteLiteral(@"';
    var ListArray = [];
    $(document).ready(function () {
        BotList();
    });
    function addMinutes(date, minutes) {
        return new Date(date.getTime() + minutes * 60000);
    }
    function BotList() {
        $.ajax({
            type: 'GET',
            url: '/List/BotList',
            dataType: 'json',
            beforeSend: function () {
                $('#botlist').append(""<div class='ajax-loading'></div>"");
            },
            complete: function () {
                $('.ajax-loading').remove();
            },
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    if (addMinutes(new Date(data[i].lastLoggedInUTC), 5) > Date.now()) {
                        var status = yes;
                    } else {
                        var status = no;
                    }
                    ListArray[i] = {
                        Id: data[i].id,
                        Name: data[i].userName,
  ");
            WriteLiteral(@"                      Domain: data[i].domain,
                        Country: data[i].countryCode,
                        LastLogin: new Date(data[i].lastLoggedInUTC).toLocaleString('en-US', { weekday: 'short' }) + "" "" + new Date(data[i].lastLoggedInUTC).toLocaleString(),
                        Online: status
                    };
                }
                listing();
            }
        });
    }
    $(""#sorter"").click(function () {
        switch ($(this).val()) {
            case ""id-sort-normal"":
                ListArray.sort((a, b) => (a.Id > b.Id) ? 1 : -1);
                break;
            case ""id-sort-desc"":
                ListArray.sort((a, b) => (a.Id > b.Id) ? -1 : 1);
                break;
            case ""date-sort-normal"":
                ListArray.sort((a, b) => (a.LastLogin > b.LastLogin) ? 1 : -1);
                break;
            case ""date-sort-desc"":
                ListArray.sort((a, b) => (a.LastLogin > b.LastLogin) ? -1 : 1);
                ");
            WriteLiteral(@"break;
            case ""name-sort-normal"":
                ListArray.sort((a, b) => (a.Name > b.Name) ? 1 : -1);
                break;
            case ""name-sort-desc"":
                ListArray.sort((a, b) => (a.Name > b.Name) ? -1 : 1);
                break;
            case ""domain-sort-normal"":
                ListArray.sort((a, b) => (a.Domain > b.Domain) ? 1 : -1);
                break;
            case ""domain-sort-desc"":
                ListArray.sort((a, b) => (a.Domain > b.Domain) ? -1 : 1);
                break;
            case ""country-sort-normal"":
                ListArray.sort((a, b) => (a.Country > b.Country) ? 1 : -1);
                break;
            case ""country-sort-desc"":
                ListArray.sort((a, b) => (a.Country > b.Country) ? -1 : 1);
                break;
        }
        listing();
    });
    function listing() {
        $(""#botlist"").text("""");
        for (var i = 0; i < ListArray.length; i++) {
            if ($(""#status"").prop(""checke");
            WriteLiteral(@"d"")) {
                if (ListArray[i].Online == yes) {
                    $(""#botlist"").append(
                        ""<div class='col-1 list-line'>"" + ListArray[i].Id + ""</div>"" +
                        ""<div class='col-2 list-line'>"" + ListArray[i].Name + ""</div>"" +
                        ""<div class='col-3 list-line'>"" + ListArray[i].Domain + ""</div>"" +
                        ""<div class='col-1 list-line'>"" + ListArray[i].Country + ""</div>"" +
                        ""<div class='col-2 list-line'>"" + ListArray[i].Online + ""</div>"" +
                        ""<div class='col-3 list-line'>"" + ListArray[i].LastLogin + ""</div>""
                    );
                }

            } else {
                $(""#botlist"").append(
                    ""<div class='col-1 list-line'>"" + ListArray[i].Id + ""</div>"" +
                    ""<div class='col-2 list-line'>"" + ListArray[i].Name + ""</div>"" +
                    ""<div class='col-3 list-line'>"" + ListArray[i].Domain + ""</div>"" +
          ");
            WriteLiteral(@"          ""<div class='col-1 list-line'>"" + ListArray[i].Country + ""</div>"" +
                    ""<div class='col-2 list-line'>"" + ListArray[i].Online + ""</div>"" +
                    ""<div class='col-3 list-line'>"" + ListArray[i].LastLogin + ""</div>""
                );
            }
        }
    }
</script>


");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
