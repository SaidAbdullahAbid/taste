#pragma checksum "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c7b9c589b61f887077f59cf39a818132393ea55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Taste.Pages.Customer.Home.Pages_Customer_Home_Index), @"mvc.1.0.razor-page", @"/Pages/Customer/Home/Index.cshtml")]
namespace Taste.Pages.Customer.Home
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
#line 1 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\_ViewImports.cshtml"
using Taste;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\_ViewImports.cshtml"
using Taste.DataAccess;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7b9c589b61f887077f59cf39a818132393ea55", @"/Pages/Customer/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a2d30feb8178202974d5495adc0a215ffc91cd", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Customer_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
 foreach (var category in Model.Categories)
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
     if (Model.menuItems.Where(m => m.CategoryId == category.Id).Count() > 0)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"container pb-3 backgroundWhite\">\r\n\t\t\t<div class=\"col-12\">\r\n\t\t\t\t<div class=\"row \">\r\n\t\t\t\t\t<h2 class=\"text-success pl-1\"> <b>");
#nullable restore
#line 12 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></h2>\r\n\t\t\t\t\t<div class=\"col-12\">\r\n\t\t\t\t\t\t<div class=\"row my-3\">\r\n");
#nullable restore
#line 15 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
                             foreach (var menuItem in Model.menuItems.Where(m => m.CategoryId == category.Id))
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<divc class=\"col-lg-3 col-xl-3 col-md-6 pb-4\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"card text-center\">\r\n\t\t\t\t\t\t\t\t\t\t<img class=\"card-img-top rounded\"");
            BeginWriteAttribute("src", " src=\"", 647, "\"", 668, 1);
#nullable restore
#line 19 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
WriteAttributeValue("", 653, menuItem.Image, 653, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height: 200px\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t<h2 class=\"card-title\">");
#nullable restore
#line 21 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
                                                              Write(menuItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
										</div>
										<ul class=""list-group list-group-flush"">
											<li class=""list-group-item"">
												<div class=""row"">
													<div class=""col-6 "">
														<span class=""p-1 text-white"" style=""background-color:#e99002; border-radius: 5px;"">
														");
#nullable restore
#line 28 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
                                                   Write(menuItem.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-6 fw-bold\">");
#nullable restore
#line 31 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
                                                                          Write(menuItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"card-footer\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c7b9c589b61f887077f59cf39a818132393ea557491", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
                                                                                                      WriteLiteral(menuItem.Id);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</divc>\r\n");
#nullable restore
#line 40 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 46 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Abid\Desktop\ANGULAR And ASPNET\Taste\Taste\Pages\Customer\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Taste.Pages.Customer.Home.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Taste.Pages.Customer.Home.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Taste.Pages.Customer.Home.IndexModel>)PageContext?.ViewData;
        public Taste.Pages.Customer.Home.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
