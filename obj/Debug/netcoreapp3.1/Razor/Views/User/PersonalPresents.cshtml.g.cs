#pragma checksum "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3820e6d50df371e1e11f78f1c242e7029286c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_PersonalPresents), @"mvc.1.0.view", @"/Views/User/PersonalPresents.cshtml")]
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
#line 1 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/_ViewImports.cshtml"
using PersonalPresents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/_ViewImports.cshtml"
using PersonalPresents.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/_ViewImports.cshtml"
using PersonalPresents.Models.PresentModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/_ViewImports.cshtml"
using PersonalPresents.Models.PackageModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3820e6d50df371e1e11f78f1c242e7029286c8", @"/Views/User/PersonalPresents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90303a475590be34a1ef018ca64def32cd8b1610", @"/Views/_ViewImports.cshtml")]
    public class Views_User_PersonalPresents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewPersonalPresent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
  
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row mt-5 mb-2\"></div>\n");
#nullable restore
#line 8 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
 foreach (var item in Model.First)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\n        <h3>");
#nullable restore
#line 11 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 12 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 13 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3820e6d50df371e1e11f78f1c242e7029286c85736", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 16 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
 foreach (var item in Model.First)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\n        <h3>");
#nullable restore
#line 20 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 21 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 22 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3820e6d50df371e1e11f78f1c242e7029286c89392", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 25 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
 foreach (var item in Model.Second)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\n        <h3>");
#nullable restore
#line 29 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 30 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 31 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3820e6d50df371e1e11f78f1c242e7029286c813049", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 34 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
 foreach (var item in Model.Third)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\n        <h3>");
#nullable restore
#line 38 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 39 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 40 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3820e6d50df371e1e11f78f1c242e7029286c816706", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 43 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
 foreach (var item in Model.Fourth)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\n        <h3>");
#nullable restore
#line 47 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 48 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 49 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3820e6d50df371e1e11f78f1c242e7029286c820364", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 52 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
 foreach (var item in Model.Fifth)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\n        <h3>");
#nullable restore
#line 56 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 57 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 58 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3820e6d50df371e1e11f78f1c242e7029286c824021", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 61 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
 foreach (var item in Model.Sixth)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\n        <h3>");
#nullable restore
#line 65 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 66 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
#nullable restore
#line 67 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
      Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3820e6d50df371e1e11f78f1c242e7029286c827678", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 70 "/home/sobira/Рабочий стол/Wed-разработка/PersonalPresents/Views/User/PersonalPresents.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewPersonalPresent> Html { get; private set; }
    }
}
#pragma warning restore 1591