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

namespace Sfa.Das.Sas.Web.Views.Start
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Start/Start.cshtml")]
    public partial class Start : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Start()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Start\Start.cshtml"
  
    ViewBag.Title = "Skills Funding Agency (SFA)";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Find apprenticeship training\r\n                </h1>\r\n     " +
"           <p");

WriteLiteral(" class=\"\"");

WriteLiteral(">For employers looking to take on apprentices.</p>\r\n            </hgroup>\r\n\r\n    " +
"        <p>You can:</p>\r\n\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n                <li>search for apprenticeship training by job role or keyword<" +
"/li>\r\n                <li>search for training providers by postcode</li>\r\n      " +
"      </ul>\r\n\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Start\Start.cshtml"
       Write(Html.ActionLink("Start", "Search", "Apprenticeship", null, new { id = "start-button", @class = "button margin-top-x2 button-start" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">What you need to know</h2>\r\n\r\n            <p>Apprentices are aged 16 and over an" +
"d combine working with learning. They can be new or current employees.</p>\r\n\r\n  " +
"          <p>If you hire an apprentice you must:</p>\r\n\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(@">
                <li>usually employ them for at least 30 hours a week</li>
                <li>pay them at least the minimum wage for apprentices</li>
                <li>offer them the same conditions and benefits as other employees working at a similar level</li>
                <li>provide experience and opportunities to help with future job progression</li>
                <li>allow them to attend training and assessment during their working hours</li>
            </ul>

        </div>
    </div>

</main>");

        }
    }
}
#pragma warning restore 1591
