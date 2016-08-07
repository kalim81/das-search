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

WriteLiteral(">\r\n    <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n            Find a training provider\r\n        </h1>\r\n        <p");

WriteLiteral(" class=\"lede\"");

WriteLiteral(">\r\n            For <strong>");

            
            #line 12 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>:\r\n        </p>\r\n    </hgroup>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n    \r\n                <form");

WriteAttribute("action", Tuple.Create(" action=\"", 458), Tuple.Create("\"", 481)
            
            #line 19 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create("", 467), Tuple.Create<System.Object, System.Int32>(Model.PostUrl
            
            #line default
            #line hidden
, 467), false)
);

WriteLiteral(" class=\"postcode-form search-box\"");

WriteLiteral(" method=\"get\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 557), Tuple.Create("\"", 636)
, Tuple.Create(Tuple.Create("", 565), Tuple.Create("form-elements", 565), true)
            
            #line 21 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create("  ", 578), Tuple.Create<System.Object, System.Int32>(Model.HasError || Model.WrongPostcode ? " error" : ""
            
            #line default
            #line hidden
, 580), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"heading-group\"");

WriteLiteral(">\r\n                            <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                                Enter a postcode\r\n                            " +
"</h2>\r\n                            <p>for example: \'SW1A 2AA\'</p>\r\n             " +
"           </div>\r\n\r\n                        <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" for=\"search-box\"");

WriteLiteral(">\r\n                            Enter the full postcode of your apprentice’s workp" +
"lace\r\n\r\n");

            
            #line 32 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                             if (@Model.HasError)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral(">\r\n                                    Sorry, postcode search not working, please" +
" try again later\r\n                                </span>\r\n");

            
            #line 37 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral(">\r\n                                    You must enter a full and valid postcode\r\n" +
"                                </span>\r\n");

            
            #line 43 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </label>\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"apprenticeshipid\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1859), Tuple.Create("\"", 1890)
            
            #line 46 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                              , Tuple.Create(Tuple.Create("", 1867), Tuple.Create<System.Object, System.Int32>(Model.ApprenticeshipId
            
            #line default
            #line hidden
, 1867), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1988), Tuple.Create("\"", 2014)
            
            #line 47 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                      , Tuple.Create(Tuple.Create("", 1996), Tuple.Create<System.Object, System.Int32>(Model.SearchTerms
            
            #line default
            #line hidden
, 1996), false)
);

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" name=\"PostCode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2082), Tuple.Create("\"", 2105)
            
            #line 48 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create("", 2090), Tuple.Create<System.Object, System.Int32>(Model.PostCode
            
            #line default
            #line hidden
, 2090), false)
);

WriteLiteral(" id=\"search-box\"");

WriteLiteral(" class=\"text-box form-control postcode-search-box\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                </" +
"form>\r\n            \r\n                <br />\r\n\r\n                <div");

WriteLiteral(" class=\"notice\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"icon icon-important\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">Warning</span>\r\n                    </i>\r\n                    <strong");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">\r\n                        Training providers are currently adding their details " +
"to this service so some may be missing from your search results.\r\n              " +
"      </strong>\r\n                </div>\r\n\r\n        </div>\r\n    </div>\r\n</main>");

        }
    }
}
#pragma warning restore 1591
