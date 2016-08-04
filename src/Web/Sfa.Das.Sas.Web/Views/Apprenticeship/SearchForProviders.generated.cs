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

namespace Sfa.Das.Sas.Web.Views.Apprenticeship
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
    using Sfa.Das.Sas.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchForProviders.cshtml")]
    public partial class SearchForProviders : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderSearchViewModel>
    {
        public SearchForProviders()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
  
    ViewBag.Title = "Search for providers";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\r\n    <div>\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n            Find an apprenticeship training provider\r\n        </h1>\r\n    </div" +
">\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" class=\"lede\"");

WriteLiteral(">\r\n                    Find training providers for apprenticeship: <strong>");

            
            #line 16 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                                                                   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                </p>\r\n                <p>\r\n                    Use thi" +
"s service to find a training provider for where your apprentice will be working." +
"\r\n                </p>\r\n\r\n                <form");

WriteAttribute("action", Tuple.Create(" action=\"", 664), Tuple.Create("\"", 687)
            
            #line 22 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create("", 673), Tuple.Create<System.Object, System.Int32>(Model.PostUrl
            
            #line default
            #line hidden
, 673), false)
);

WriteLiteral(" class=\"postcode-form search-box\"");

WriteLiteral(" method=\"get\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 763), Tuple.Create("\"", 841)
, Tuple.Create(Tuple.Create("", 771), Tuple.Create("form-elements", 771), true)
            
            #line 24 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create(" ", 784), Tuple.Create<System.Object, System.Int32>(Model.HasError || Model.WrongPostcode ? " error" : ""
            
            #line default
            #line hidden
, 785), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"heading-group\"");

WriteLiteral(">\r\n                            <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                                Enter a postcode\r\n                            " +
"</h2>\r\n                            <p>eg SW1A 2AA</p>\r\n                        <" +
"/div>\r\n\r\n                        <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" for=\"search-box\"");

WriteLiteral(">\r\n                            We need <strong>full</strong> postcode to find the" +
" closest training providers to you.\r\n\r\n");

            
            #line 35 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                             if (@Model.HasError)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral(">\r\n                                    Sorry, postcode search not working, please" +
" try again later\r\n                                </span>\r\n");

            
            #line 40 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral(">\r\n                                    Invalid postcode\r\n                        " +
"        </span>\r\n");

            
            #line 46 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </label>\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"apprenticeshipid\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2059), Tuple.Create("\"", 2090)
            
            #line 49 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                              , Tuple.Create(Tuple.Create("", 2067), Tuple.Create<System.Object, System.Int32>(Model.ApprenticeshipId
            
            #line default
            #line hidden
, 2067), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2188), Tuple.Create("\"", 2214)
            
            #line 50 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                      , Tuple.Create(Tuple.Create("", 2196), Tuple.Create<System.Object, System.Int32>(Model.SearchTerms
            
            #line default
            #line hidden
, 2196), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" name=\"PostCode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2282), Tuple.Create("\"", 2305)
            
            #line 51 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create("", 2290), Tuple.Create<System.Object, System.Int32>(Model.PostCode
            
            #line default
            #line hidden
, 2290), false)
);

WriteLiteral(" id=\"search-box\"");

WriteLiteral(" class=\"text-box form-control postcode-search-box\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(">\r\n                        </div>\r\n                        <input");

WriteLiteral(" class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Find\"");

WriteLiteral(">\r\n                    </div>\r\n                </form>\r\n            \r\n           " +
"     <div");

WriteLiteral(" class=\"provider-data-warning\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"glyphicon-tag tag-label tag-warning\"");

WriteLiteral(@">Please Note</span> This is a new service. Training providers are currently entering their information. You will only see information for training providers who have updated their details so far.
                </div>

        </div>
    </div>
</main>");

        }
    }
}
#pragma warning restore 1591
