#pragma checksum "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "790ca7d412ac96c8b6806ba3118cfd180e331e2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__main_menuPartial), @"mvc.1.0.view", @"/Views/Shared/_main-menuPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_main-menuPartial.cshtml", typeof(AspNetCore.Views_Shared__main_menuPartial))]
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
#line 1 "C:\Users\Naib\Desktop\SkyShopeCore\Views\_ViewImports.cshtml"
using skyshopCore;

#line default
#line hidden
#line 2 "C:\Users\Naib\Desktop\SkyShopeCore\Views\_ViewImports.cshtml"
using skyshopCore.Models;

#line default
#line hidden
#line 3 "C:\Users\Naib\Desktop\SkyShopeCore\Views\_ViewImports.cshtml"
using skyshopCore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790ca7d412ac96c8b6806ba3118cfd180e331e2a", @"/Views/Shared/_main-menuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a9a2c0f428f08d32cd0d73189d93318015ec06", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__main_menuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mainCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 18, true);
            WriteLiteral("                  ");
            EndContext();
            BeginContext(52, 528, true);
            WriteLiteral(@"                  <ul class=""main-menu menu"">
                  <li class=""menu-item menu-item-has-children dropdown""><a href=""/"">Home</a>
                  </li>
                  <li class=""menu-item menu-item-has-children has-mega-menu""><a href=""#"">Category</a>
                    <div class=""mega-menu"">
                      <div class=""mega-wrap"">
                           <div class=""col-3"">
                            <div class=""mega-column"">
                          <ul class=""mega-item mega-features"">
");
            EndContext();
#line 11 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                              foreach (var Mcat in Model)
                        {

#line default
#line hidden
            BeginContext(666, 59, true);
            WriteLiteral("                          <li><a class=\"Main-link\" data-id=");
            EndContext();
            BeginContext(726, 7, false);
#line 13 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                                                      Write(Mcat.Id);

#line default
#line hidden
            EndContext();
            BeginContext(733, 24, true);
            WriteLiteral(" style=\"cursor:pointer\">");
            EndContext();
            BeginContext(758, 9, false);
#line 13 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                                                                                      Write(Mcat.name);

#line default
#line hidden
            EndContext();
            BeginContext(767, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 14 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(805, 100, true);
            WriteLiteral("                          </ul>\r\n                        </div>\r\n                           </div>\r\n");
            EndContext();
#line 18 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                         foreach (var cat in Model)
                        {

#line default
#line hidden
            BeginContext(985, 110, true);
            WriteLiteral("                          <div class=\" col-9 custom-column-block  custom-column-none categoryMenu\" data-catId=");
            EndContext();
            BeginContext(1096, 6, false);
#line 20 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                                                                                                         Write(cat.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 48, true);
            WriteLiteral(">\r\n                          <div class=\"row\">\r\n");
            EndContext();
#line 22 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                           foreach (var item in cat.categories)
                          {


#line default
#line hidden
            BeginContext(1246, 113, true);
            WriteLiteral("                          <div class=\"mega-column col-3\" i=>\r\n                          <h4 class=\"mega-heading\">");
            EndContext();
            BeginContext(1360, 9, false);
#line 26 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                                              Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1369, 57, true);
            WriteLiteral("</h4>\r\n                          <ul class=\"mega-item\">\r\n");
            EndContext();
#line 28 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                             foreach (var subCat in item.subcategories)
                            {

#line default
#line hidden
            BeginContext(1530, 33, true);
            WriteLiteral("                             <li>");
            EndContext();
            BeginContext(1563, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "790ca7d412ac96c8b6806ba3118cfd180e331e2a8203", async() => {
                BeginContext(1638, 11, false);
#line 30 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                                                                                                      Write(subCat.name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                                                                                 WriteLiteral(subCat.name);

#line default
#line hidden
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
            EndContext();
            BeginContext(1653, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 31 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1691, 65, true);
            WriteLiteral("                          </ul>\r\n                        </div>\r\n");
            EndContext();
#line 34 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                          }

#line default
#line hidden
            BeginContext(1785, 69, true);
            WriteLiteral("                           </div>\r\n                          </div>\r\n");
            EndContext();
#line 37 "C:\Users\Naib\Desktop\SkyShopeCore\Views\Shared\_main-menuPartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(1881, 1033, true);
            WriteLiteral(@"                      </div>
                    </div>
                  </li>
                  <li class=""menu-item menu-item-has-children dropdown""><a href=""/blog"">News</a>
                  </li>
                  <li class=""menu-item menu-item-has-children dropdown""><a href=""/contact"">Contact</a>
                  </li>
                  </ul>


                  <script>
                        $("".Main-link"").hover((e)=>{
                        var mId=$(e.target).attr(""data-id"");      
                        var child= $("".categoryMenu"");
                        for(var i=0;i<child.length;i++){
                        var cId=$(child[i]).attr(""data-catId"");
                        if(mId==cId){
                        $(child[i]).css({""display"":""block""});
                         }
                        else{
                        $(child[i]).css({""display"":""none""});
                            }
                         }
                        });
                  </");
            WriteLiteral("script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mainCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
