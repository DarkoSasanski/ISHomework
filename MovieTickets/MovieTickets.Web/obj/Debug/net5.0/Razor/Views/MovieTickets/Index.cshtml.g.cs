#pragma checksum "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1870b99892b6f73e195ce3a867e754db839f7e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieTickets_Index), @"mvc.1.0.view", @"/Views/MovieTickets/Index.cshtml")]
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
#line 1 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\_ViewImports.cshtml"
using MovieTickets.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\_ViewImports.cshtml"
using MovieTickets.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
using MovieTickets.Domain.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1870b99892b6f73e195ce3a867e754db839f7e1", @"/Views/MovieTickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5aa6305600ac1cb7925ce33fad4e78dfbbe87d0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MovieTickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieTickets.Domain.Domain.MovieTicket>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportTickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTicketToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Tickets</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1870b99892b6f73e195ce3a867e754db839f7e17234", async() => {
                WriteLiteral("Add New Ticket");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1870b99892b6f73e195ce3a867e754db839f7e18605", async() => {
                WriteLiteral(@"

            <div class=""row"">
                <input type=""date"" name=""filter"" class=""form-control col-md-9""/>
                <div class=""col-md-1""></div>
                <button type=""submit"" class=""btn btn-outline-primary col-md-2"">Filter</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
 if(User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3\">\r\n    <div class=\"col-md-2\">\r\n\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1870b99892b6f73e195ce3a867e754db839f7e110994", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 42 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
           Write(Html.DropDownList("genre", Enum.GetValues(typeof(MovieGenre)).Cast<MovieGenre>().Select(m => new SelectListItem
                {
                Text = m.ToString(),
                Value = ((int)m).ToString()
                }).Prepend(new SelectListItem { Text = "All", Value = "All" }), new { @class = "form-control col-md-9" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-1\"></div>\r\n                <button type=\"submit\" class=\"btn btn-outline-primary col-md-2\">Export</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>\r\n");
#nullable restore
#line 54 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-4\">\r\n");
#nullable restore
#line 57 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
     if(Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"text-center\">\r\n            No movies added\r\n        </h3>\r\n");
#nullable restore
#line 62 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
     for(int i=0; i<Model.Count; i++)
    {
        var curr = Model[i];
        if(i%3==0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 69 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card\" style=\"height:35rem; width:18rem\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1945, "\"", 1973, 1);
#nullable restore
#line 72 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
WriteAttributeValue("", 1951, curr.Movie.MovieImage, 1951, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" style=\"height:15rem\">\r\n                <div class=\"card-body\">\r\n                    <h2 class=\"card-title\">");
#nullable restore
#line 74 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
                                      Write(curr.Movie.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 75 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
                                    Write(curr.Movie.MovieDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h3>$");
#nullable restore
#line 76 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
                    Write(curr.TicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1870b99892b6f73e195ce3a867e754db839f7e117103", async() => {
                WriteLiteral("Add to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
                                                      WriteLiteral(curr.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1870b99892b6f73e195ce3a867e754db839f7e119454", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
                                           WriteLiteral(curr.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 84 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
        if (i % 3 == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 87 "C:\Users\DARKO\Desktop\FINKI\VI semestar\Integrirani sistemi\ISProba\MovieTicketsWebApplication\MovieTickets\MovieTickets.Web\Views\MovieTickets\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieTickets.Domain.Domain.MovieTicket>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
