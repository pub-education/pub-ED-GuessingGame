#pragma checksum "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b6d019179e705f1690ebbc50bda16df20dcc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GuessingGame), @"mvc.1.0.view", @"/Views/Home/GuessingGame.cshtml")]
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
#line 1 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\_ViewImports.cshtml"
using GuessingGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\_ViewImports.cshtml"
using GuessingGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b6d019179e705f1690ebbc50bda16df20dcc28", @"/Views/Home/GuessingGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093a5f78029041b8ac8073ce3aaec85b35d71f23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GuessingGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/GuessingGame"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
   
    ViewData["Title"] = "- The Guessing Game -";
    /*string tmpItems = (string)ViewBag.topTen;
    string[] items = tmpItems.Split(',');*/
    string[] tmps = { "", "" };


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""card-wrapper"">
        <h1 class=""display-4"">The Guessing Game</h1>
        <p>Guess the secret number bewteen 1 and 100</p>
        <div id=""card-holder"">
            <div class=""cardBg""></div>
            <div class=""card"">
                <div class=""form-wrapper"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46b6d019179e705f1690ebbc50bda16df20dcc284664", async() => {
                WriteLiteral("\r\n                        <div>\r\n                            <div>\r\n                                <label>\r\n                                    Name:<br />\r\n");
#nullable restore
#line 22 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                                     if (ViewBag.name != "")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input id=\"name\" type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 914, "\"", 935, 1);
#nullable restore
#line 24 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
WriteAttributeValue("", 922, ViewBag.name, 922, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n");
#nullable restore
#line 25 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"text\"  name=\"name\" focus/>\r\n");
#nullable restore
#line 29 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </label>
                            </div>
                            <div>
                                <label>
                                    No. Guesses:<br />
                                    <input id=""guessCount"" name=""counter"" type=""number""");
                BeginWriteAttribute("value", " value=\"", 1487, "\"", 1511, 1);
#nullable restore
#line 35 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
WriteAttributeValue("", 1495, ViewBag.counter, 1495, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled />
                                </label>
                            </div>
                        </div>
                        <div>
                            <label>
                                Guess the number:<br />
                                <input id=""guessedNumber"" type=""number"" name=""guessedNumber""");
                BeginWriteAttribute("value", " value=\"", 1853, "\"", 1881, 1);
#nullable restore
#line 42 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
WriteAttributeValue("", 1861, ViewBag.guessNumber, 1861, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 43 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                                 if (!(ViewBag.message == "" || ViewBag.message == null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input id=\"response\" type=\"text\" name=\"response\"");
                BeginWriteAttribute("value", " value=\"", 2097, "\"", 2121, 1);
#nullable restore
#line 45 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
WriteAttributeValue("", 2105, ViewBag.message, 2105, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 46 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </label>
                        </div>
                        <div class=""button-wrapper"">

                            <div>
                                <button id=""submitButton"" type=""submit"">Enter</button>
                            </div>

                            <div>
                                <button onclick=""javascript: buttonClick('newGame')"" type=""button"">New Game</button>
                            </div>
                            <div>
                                <button onclick=""javascript: buttonClick('endGame')"" type=""button"">End Game</button>
                            </div>
                        </div>

                        <input id=""callButton"" type=""text"" name=""callButton"" value=""submit"" hidden />
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""scoreBoard-wrapper"">
                    <h2>Top Scores</h2>
                    <table class=""topTen-table"">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Score</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 76 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                             foreach(string item in ViewBag.topTen){
                                tmps = item.Split(':');

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 79 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                               Write(tmps[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 80 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                               Write(tmps[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 82 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGame.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
