#pragma checksum "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d11c573af6871f5820a59782e0d87dbb7edfcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d11c573af6871f5820a59782e0d87dbb7edfcd", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92e2ba627270339132bff3ddc82f3cdb3fe61485", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 95px; height: 95px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("showImg(this.src)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddtoCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button btn-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Add to Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-wishlist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddtoWishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("product_addtocart_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
   ViewData["Title"] = "Details";
    var format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-main\">\r\n    <div class=\"product-view\">\r\n        <div class=\"product-essential\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9d11c573af6871f5820a59782e0d87dbb7edfcd8407", async() => {
                WriteLiteral("\r\n                <input name=\"form_key\" value=\"6UbXroakyQlbfQzK\" type=\"hidden\">\r\n                <div class=\"product-img-box col-lg-4 col-sm-5 col-xs-12\">\r\n");
#nullable restore
#line 11 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                       string[] arrListStr = Model.ProductImage.Split(" "); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"product-image\">\r\n                        <div class=\"product-full big-img\"> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9d11c573af6871f5820a59782e0d87dbb7edfcd9237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 664, "~/images/", 664, 9, true);
#nullable restore
#line 13 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 673, arrListStr[0], 673, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" </div>
                        <div class=""more-views"">
                            <div class=""slider-items-products"">
                                <div id=""gallery_01"" class=""product-flexslider hidden-buttons product-img-thumb"">
                                    <div class=""slider-items slider-width-col4 block-content"">
                                        <div class=""more-views-items"">
");
#nullable restore
#line 19 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                             for (int i = 0; i < arrListStr.Length - 1; i++)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<a class=\"small-img\">\r\n                                                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9d11c573af6871f5820a59782e0d87dbb7edfcd11729", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1373, "~/images/", 1373, 9, true);
#nullable restore
#line 21 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 1382, arrListStr[i], 1382, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </a>");
#nullable restore
#line 22 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- end: more-images -->
                </div>
                <div class=""product-shop col-lg-8 col-sm-7 col-xs-12"">
                    <div class=""product-name"">
                        <h1>");
#nullable restore
#line 33 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    </div>\r\n                    <div class=\"price-block\">\r\n                        <div class=\"price-box\">\r\n                            <p");
                BeginWriteAttribute("class", " class=\"", 2127, "\"", 2135, 0);
                EndWriteAttribute();
                WriteLiteral("> <span class=\"price-label\"></span> \r\n                            <span class=\"price\">Price: ");
#nullable restore
#line 38 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                                  Write(String.Format(format, "{0:c0}", @Model.OutPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span> \r\n                            </p>\r\n");
#nullable restore
#line 40 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                             if (Model.ProductQuantity != 0) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"availability in-stock pull-right\"><span>Available</span></p>\r\n");
#nullable restore
#line 42 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                            }
                            else { 

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"unavailability in-stock pull-right\" ><i class=\"fas fa-ban\"></i><span>Unavailable</span></p>\r\n");
#nullable restore
#line 45 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""short-description"">
                        <div class=""short-description"">
                            <div class=""product-type"">
                               
                                <h2><b>Type:</b> ");
#nullable restore
#line 52 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                            Write(Model.ProductTypeNavigation.Tilte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            </div>\r\n                            <div class=\"product-color\">\r\n                               <h2><b>Color:</b>");
#nullable restore
#line 55 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                           Write(Model.ProductColorNavigation.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            </div>\r\n                            <div class=\"product-brand\">\r\n                                \r\n                                    <h2><b>Water Environment:</b> ");
#nullable restore
#line 59 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                                             Write(Model.ProductBrandNavigation.Tilte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n                            </div>\r\n                            <div class=\"product-size\">\r\n                              \r\n                                    <h2><b>Size:</b> ");
#nullable restore
#line 64 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                                Write(Model.ProductSizeNavigation.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n                            </div>\r\n                            <h2><strong>Product Description </strong></h2>\r\n                            <p>");
#nullable restore
#line 68 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                          Write(Model.ProductDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                        
                    </div>
                    <div class=""add-to-box"">
                        <div class=""add-to-cart"">
                            <div class=""pull-left"">
                                <div class=""custom pull-left"">
                                    <button onClick=""var result = document.getElementById('qty'); var qty = result.value; if( !isNaN( qty ) &amp;&amp; qty &gt; 0 ) result.value--;return false;"" class=""reduced items-count"" type=""button""><i class=""fa fa-minus"">&nbsp;</i></button>
                                    <input type=""text"" class=""input-text qty"" title=""Qty"" value=""1"" maxlength=""12"" id=""qty"" name=""qty"">
                                    <button onClick=""var result = document.getElementById('qty'); var qty = result.value; if( !isNaN( qty )) result.value++;return false;"" class=""increase items-count"" type=""button""><i class=""fa fa-plus"">&nbsp;</i></button>
                                </div>
    ");
                WriteLiteral("                        </div>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9d11c573af6871f5820a59782e0d87dbb7edfcd20114", async() => {
                    WriteLiteral("Add to Cart</span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"email-addto-box\">\r\n                            <ul class=\"add-to-links\">\r\n                                <li> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9d11c573af6871f5820a59782e0d87dbb7edfcd23097", async() => {
                    WriteLiteral("<span>Add to Wishlist</span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\Laptop\OneDrive\Documents\GitHub\AOS-Aquarium-Online-Shop\Views\Products\Details.cshtml"
                                                                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    let bigImg = document.querySelector(\'.big-img img\');\r\n    function showImg(pic) {\r\n        bigImg.src = pic;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
