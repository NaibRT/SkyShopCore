#pragma checksum "/home/naib/Projects/skyshopCore/Views/Shared/_main-menuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c36c479bd9e82d22f23745402ae4a631ea31ed6"
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
#line 1 "/home/naib/Projects/skyshopCore/Views/_ViewImports.cshtml"
using skyshopCore;

#line default
#line hidden
#line 2 "/home/naib/Projects/skyshopCore/Views/_ViewImports.cshtml"
using skyshopCore.Models;

#line default
#line hidden
#line 3 "/home/naib/Projects/skyshopCore/Views/_ViewImports.cshtml"
using skyshopCore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c36c479bd9e82d22f23745402ae4a631ea31ed6", @"/Views/Shared/_main-menuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a9a2c0f428f08d32cd0d73189d93318015ec06", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__main_menuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4026, true);
            WriteLiteral(@"                <ul class=""main-menu menu"">
                  <li class=""menu-item menu-item-has-children dropdown""><a href=""/"">Home</a>
                  </li>
                  <li class=""menu-item menu-item-has-children has-mega-menu""><a href=""#"">Category</a>
                    <div class=""mega-menu"">
                      <div class=""mega-wrap"">
                        <div class=""mega-column"">
                          <ul class=""mega-item mega-features"">
                            {{#each mainCatList}}
                              <li><a href=""/product-listing"">{{this.name}}</a></li>
                            {{/each}}
                            
                          </ul>
                        </div>
                        <div class=""mega-column"">
                          <h4 class=""mega-heading"">Shoes</h4>
                          <ul class=""mega-item"">
                            <li><a href=""/product-listing"">All Shoes</a></li>
                            <li><a href=""/product-listi");
            WriteLiteral(@"ng"">Running</a></li>
                            <li><a href=""/product-listing"">Training & Gym</a></li>
                            <li><a href=""/product-listing"">Basketball</a></li>
                            <li><a href=""/product-listing"">Football</a></li>
                            <li><a href=""/product-listing"">Soccer</a></li>
                            <li><a href=""/product-listing"">Baseball</a></li>
                          </ul>
                        </div>
                        <div class=""mega-column"">
                          <h4 class=""mega-heading"">CLOTHING</h4>
                          <ul class=""mega-item"">
                            <li><a href=""/product-listing"">Compression & Nike Pro</a></li>
                            <li><a href=""/product-listing"">Tops & T-Shirts</a></li>
                            <li><a href=""/product-listing"">Polos</a></li>
                            <li><a href=""/product-listing"">Hoodies & Sweatshirts</a></li>
                            <li><a href=""/prod");
            WriteLiteral(@"uct-listing"">Jackets & Vests</a></li>
                            <li><a href=""/product-listing"">Pants & Tights</a></li>
                            <li><a href=""/product-listing"">Shorts</a></li>
                          </ul>
                        </div>
                        <div class=""mega-column"">
                          <h4 class=""mega-heading"">Accessories</h4>
                          <ul class=""mega-item"">
                            <li><a href=""/product-listing"">Compression & Nike Pro</a></li>
                            <li><a href=""product-listing.html"">Tops & T-Shirts</a></li>
                            <li><a href=""product-listing.html"">Polos</a></li>
                            <li><a href=""product-listing.html"">Hoodies & Sweatshirts</a></li>
                            <li><a href=""product-listing.html"">Jackets & Vests</a></li>
                            <li><a href=""product-listing.html"">Pants & Tights</a></li>
                            <li><a href=""product-listing.html"">Shorts</a");
            WriteLiteral(@"></li>
                          </ul>
                        </div>
                        <div class=""mega-column"">
                          <h4 class=""mega-heading"">BRAND</h4>
                          <ul class=""mega-item"">
                            <li><a href=""product-listing.html"">NIKE</a></li>
                            <li><a href=""product-listing.html"">Adidas</a></li>
                            <li><a href=""product-listing.html"">Dior</a></li>
                            <li><a href=""product-listing.html"">B&G</a></li>
                          </ul>
                        </div> 
                      </div>
                    </div>
                  </li>
                  <li class=""menu-item menu-item-has-children dropdown""><a href=""/blog"">News</a>
                  </li>
                  <li class=""menu-item menu-item-has-children dropdown""><a href=""/contact"">Contact</a>
                  </li>
                </ul>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
