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

namespace Sfa.Das.Sas.MetadataTool.Web.Views.Apprenticeship
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
    using MetadataTool;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Frameworks.cshtml")]
    public partial class Frameworks : System.Web.Mvc.WebViewPage<List<Sfa.Das.Sas.Core.Models.FrameworkMetaData>>
    {
        public Frameworks()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Apprenticeship\Frameworks.cshtml"
  
    ViewBag.Title = "Frameworks";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Frameworks (");

            
            #line 6 "..\..\Views\Apprenticeship\Frameworks.cshtml"
           Write(Model.Count);

            
            #line default
            #line hidden
WriteLiteral(" results)</h2>\r\n\r\n<div>\r\n");

            
            #line 9 "..\..\Views\Apprenticeship\Frameworks.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Apprenticeship\Frameworks.cshtml"
     foreach (var item in Model)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\Views\Apprenticeship\Frameworks.cshtml"
       Write(Html.ActionLink($"{@item.ApprenticeshipId}, {@item.FrameworkName}: {@item.Pathway}", "FrameworkDetails", "Apprenticeship", new { @id = item.Id }, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n");

            
            #line 14 "..\..\Views\Apprenticeship\Frameworks.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
