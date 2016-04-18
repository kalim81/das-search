﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Eds.Das.Web.Views.Provider
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Sfa.Eds.Das.Web;
    
    #line 1 "..\..\Views\Provider\StandardResults.cshtml"
    using Sfa.Eds.Das.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/StandardResults.cshtml")]
    public partial class StandardResults : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.ProviderStandardSearchResultViewModel>
    {
        public StandardResults()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Provider\StandardResults.cshtml"
  
    ViewBag.Title = "Provider Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Provider\StandardResults.cshtml"
Write(Html.ActionLink("Back to Standard", "Standard", "Apprenticeship", new { @id = @Model.StandardId }, new { @class = "link-back" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" id=\"provider-results\"");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n\r\n            </div" +
">\r\n            <p>\r\n");

            
            #line 22 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Provider\StandardResults.cshtml"
                  
                    Html.RenderPartial("_StandardSearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\r\n");

            
            #line 26 "..\..\Views\Provider\StandardResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Provider\StandardResults.cshtml"
              
                Html.RenderPartial("_StandardProviderInformation");
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");

            
            #line 36 "..\..\Views\Provider\StandardResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function() {    \r\n            SearchAndShor" +
"tlist.analytics.pushEvent(\"Provider Search\", \"No results\", \"Search\");\r\n        }" +
"\r\n    </script> \r\n");

            
            #line 43 "..\..\Views\Provider\StandardResults.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
