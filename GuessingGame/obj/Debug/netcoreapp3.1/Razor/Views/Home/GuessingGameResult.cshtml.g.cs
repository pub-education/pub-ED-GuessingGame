#pragma checksum "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963081455498815c20edeea4d67c25d4e070effc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GuessingGameResult), @"mvc.1.0.view", @"/Views/Home/GuessingGameResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963081455498815c20edeea4d67c25d4e070effc", @"/Views/Home/GuessingGameResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093a5f78029041b8ac8073ce3aaec85b35d71f23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GuessingGameResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
  
    ViewData["Title"] = "- The Guessing Game -";


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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963081455498815c20edeea4d67c25d4e070effc4572", async() => {
                WriteLiteral("\r\n                        <div>\r\n");
#nullable restore
#line 16 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                             if (ViewBag.showResult)
                            {
                                string tmpItems = (string)ViewBag.resultList;
                                string[] items = tmpItems.Split(',');
                                string[] tmps = new string[2];

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <ul>\r\n");
#nullable restore
#line 22 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                     foreach (string item in items)
                                    {
                                        //tmps = item.Split(':');

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>");
#nullable restore
#line 25 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                       Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n");
#nullable restore
#line 28 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div>\r\n                                    <label>\r\n                                        Name:<br />\r\n");
#nullable restore
#line 34 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                         if (!ViewBag.initialRun)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input id=\"name\" type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1553, "\"", 1574, 1);
#nullable restore
#line 36 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
WriteAttributeValue("", 1561, ViewBag.name, 1561, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n");
#nullable restore
#line 37 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input id=\"name\" type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1805, "\"", 1826, 1);
#nullable restore
#line 40 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
WriteAttributeValue("", 1813, ViewBag.name, 1813, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 41 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </label>
                                </div>
                                <div>
                                    <label>
                                        No. Guesses:<br />
                                        <input id=""guessCount"" name=""counter"" type=""number""");
                BeginWriteAttribute("value", " value=\"", 2196, "\"", 2220, 1);
#nullable restore
#line 47 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
WriteAttributeValue("", 2204, ViewBag.counter, 2204, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 50 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n");
#nullable restore
#line 52 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                         if (!ViewBag.showResult)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div>\r\n                                <label>\r\n                                    Guess the number:<br />\r\n                                    <input id=\"guessedNumber\" type=\"number\" name=\"guessedNumber\"");
                BeginWriteAttribute("value", " value=\"", 2695, "\"", 2723, 1);
#nullable restore
#line 57 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
WriteAttributeValue("", 2703, ViewBag.guessNumber, 2703, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 58 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                     if (!ViewBag.initialRun)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input id=\"response\" type=\"text\" name=\"response\"");
                BeginWriteAttribute("value", " value=\"", 2919, "\"", 2944, 1);
#nullable restore
#line 60 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
WriteAttributeValue("", 2927, ViewBag.response, 2927, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 61 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </label>\r\n                            </div>\r\n");
#nullable restore
#line 64 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"button-wrapper\">\r\n");
#nullable restore
#line 67 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                             if (!ViewBag.showResult)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div>\r\n                                    <button id=\"submitButton\" type=\"submit\">Enter</button>\r\n                                </div>\r\n");
#nullable restore
#line 72 "F:\Education\Lexicon\Programmering .NET\03 Backend\Code\GuessingGame\Views\Home\GuessingGameResult.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div>
                                <button onclick=""javascript: buttonClick('newGame')"" type=""button"">New Game</button>
                            </div>
                            <div>
                                <button onclick=""javascript: buttonClick('endGame')"" type=""button"">End Game</button>
                            </div>
                        </div>

                        <input id=""callButton"" type=""text"" name=""callButton""");
                BeginWriteAttribute("value", " value=\"", 3926, "\"", 3934, 0);
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                    ");
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
                    <table>
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Score</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>text</td>
                                <td>number</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

    </div>
</div>");
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
