#pragma checksum "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73bea9cfff169fcd1920b2dcd7913457f4017193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 1 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
using LastTesst.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73bea9cfff169fcd1920b2dcd7913457f4017193", @"/Views/Basket/Index.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/basket.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
  
	int totalPriceWith = 0;
	int totalPriceWithout = 0;
	for (int i = 0; i < Model.Length; i++)
	{
		totalPriceWith += Model[i].Discount_price;
		totalPriceWithout += Model[i].Price;
	}
	int result = totalPriceWithout - totalPriceWith;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("styles", async() => {
                WriteLiteral("\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73bea9cfff169fcd1920b2dcd7913457f40171934131", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<div class=\"container_basket\">\n\n\t<h1>Shopping Cart</h1>\n\n\t<div class=\"cart\">\n\t\t<div class=\"products\">\n");
#nullable restore
#line 31 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
             for (int i = 0; i < @Model.Length; i++)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"product\">\n\t\t\t\t\t\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73bea9cfff169fcd1920b2dcd7913457f40171935755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 606, "~/", 606, 2, true);
#nullable restore
#line 35 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
AddHtmlAttributeValue("", 608, Model[i].Image, 608, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\t\t\t\t\t<div class=\"product-info\">\n\t\t\t\t\t\t\n\t\t\t\t\t\t<h3 class=\"product-name\">");
#nullable restore
#line 39 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
                                            Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n\t\t\t\t\t\t<h4 class=\"product-price\">");
#nullable restore
#line 41 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
                                             Write(Model[i].Discount_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h4>\n\n\t\t\t\t\t\t<h4 class=\"product-offer\">");
#nullable restore
#line 43 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
                                             Write(Model[i].Amount_of_discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</h4>\n\n\t\t\t\t\t\t<p class=\"product-quantity\">Qnt: <input value=\"1\"");
            BeginWriteAttribute("name", " name=\"", 907, "\"", 914, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\n\t\t\t\t\t\t<p class=\"product-remove\">\n\n\t\t\t\t\t\t\t<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\n\n\t\t\t\t\t\t\t<span class=\"remove\">Remove</span>\n\n\t\t\t\t\t\t</p>\n\n\t\t\t\t\t</div>\n\n\t\t\t\t</div>\n");
#nullable restore
#line 58 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</div>\n\n\t\t<div class=\"cart-total\">\n\n\t\t\t<p>\n\n\t\t\t\t<span>Total Price</span>\n\n\t\t\t\t<span>");
#nullable restore
#line 68 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
                 Write(totalPriceWith);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</span>\n\n\t\t\t</p>\n\n\t\t\t<p>\n\n\t\t\t\t<span>Number of Items</span>\n\n\t\t\t\t<span>");
#nullable restore
#line 76 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
                 Write(Model.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n\t\t\t</p>\n\n\t\t\t<p>\n\n\t\t\t\t<span>You Save</span>\n\n\t\t\t\t<span>$ ");
#nullable restore
#line 84 "/Users/tagir/RiderProjects/LastTesst/LastTesst/Views/Basket/Index.cshtml"
                   Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n\t\t\t</p>\n\n\t\t\t<a href=\"#\">Proceed to Checkout</a>\n\n\t\t</div>\n\n\t</div>\n\n</div>\n\n\n");
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