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

namespace Sfa.Eds.Das.Web.Views.Standard
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
    
    #line 1 "..\..\Views\Standard\Detail.cshtml"
    using Resources = Sfa.Eds.Das.Resources.EquivalenceLevels;
    
    #line default
    #line hidden
    using Sfa.Eds.Das.Web;
    
    #line 2 "..\..\Views\Standard\Detail.cshtml"
    using Sfa.Eds.Das.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Standard/Detail.cshtml")]
    public partial class Detail : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.StandardViewModel>
    {

#line 94 "..\..\Views\Standard\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardLevel(string item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 95 "..\..\Views\Standard\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(item))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"minLength\"");

WriteLiteralTo(__razor_helper_writer, ">Level</dt>\r\n");


#line 99 "..\..\Views\Standard\Detail.cshtml"
        var equivalence = string.Empty;
        switch (int.Parse(@item))
        {
            case 1:
                equivalence = @Resources.FirstLevel;
                break;
            case 2:
                equivalence = @Resources.SecondLevel;
                break;
            case 3:
                equivalence = @Resources.ThirdLevel;
                break;
            case 4:
                equivalence = @Resources.FourthLevel;
                break;
            case 5:
                equivalence = @Resources.FifthLevel;
                break;
            case 6:
                equivalence = @Resources.SixthLevel;
                break;
            case 7:
                equivalence = @Resources.SeventhLevel;
                break;
            case 8:
                equivalence = @Resources.EighthLevel;
            break;
        default:
            break;

        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"minLength\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 130 "..\..\Views\Standard\Detail.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " (equivalent to ");


#line 130 "..\..\Views\Standard\Detail.cshtml"
                     WriteTo(__razor_helper_writer, equivalence);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ")</dd>\r\n");


#line 131 "..\..\Views\Standard\Detail.cshtml"

    }


#line default
#line hidden
});

#line 133 "..\..\Views\Standard\Detail.cshtml"
}
#line default
#line hidden

#line 136 "..\..\Views\Standard\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 137 "..\..\Views\Standard\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 141 "..\..\Views\Standard\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd>");


#line 142 "..\..\Views\Standard\Detail.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 143 "..\..\Views\Standard\Detail.cshtml"

    }


#line default
#line hidden
});

#line 145 "..\..\Views\Standard\Detail.cshtml"
}
#line default
#line hidden

#line 147 "..\..\Views\Standard\Detail.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 148 "..\..\Views\Standard\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(title))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li>\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 5554), Tuple.Create("\"", 5568)

#line 152 "..\..\Views\Standard\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5561), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 5561), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 153 "..\..\Views\Standard\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </a>\r\n                <p>\r\n                    PDF, 268KB, 2 pa" +
"ges\r\n                </p>\r\n            </li>\r\n");


#line 159 "..\..\Views\Standard\Detail.cshtml"
    }


#line default
#line hidden
});

#line 160 "..\..\Views\Standard\Detail.cshtml"
}
#line default
#line hidden

        public Detail()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Standard\Detail.cshtml"
  
    ViewBag.Title = "Standard - " + @Model.Title;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Standard\Detail.cshtml"
   Write(Html.RenderAIfExists(@Model.SearchResultLink?.Title, @Model.SearchResultLink?.Url, "link-back"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"heading-secondary\"");

WriteLiteral(">Apprenticeship standard and assessment plan</span>\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..\Views\Standard\Detail.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n");

            
            #line 23 "..\..\Views\Standard\Detail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Standard\Detail.cshtml"
                 if (!string.IsNullOrEmpty(@Model.IntroductoryTextHtml))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"standard-result-summary\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 26 "..\..\Views\Standard\Detail.cshtml"
                   Write(Html.Raw(@Model.IntroductoryTextHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 28 "..\..\Views\Standard\Detail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n");

            
            #line 33 "..\..\Views\Standard\Detail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Standard\Detail.cshtml"
             using (Html.BeginForm("SearchResults", "Provider", FormMethod.Get, new { @class = "search-box" }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                    <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(">\r\n\r\n                        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Find training providers</h2>\r\n                        <form");

WriteLiteral(" action=\"/g-cloud/search\"");

WriteLiteral(" method=\"get\"");

WriteLiteral(" class=\"search-box\"");

WriteLiteral(">\r\n                            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1459), Tuple.Create("\"", 1512)
, Tuple.Create(Tuple.Create("", 1467), Tuple.Create("form-group", 1467), true)
            
            #line 40 "..\..\Views\Standard\Detail.cshtml"
, Tuple.Create(Tuple.Create(" ", 1477), Tuple.Create<System.Object, System.Int32>(@Model.HasError ? " error" : ""
            
            #line default
            #line hidden
, 1478), false)
);

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" for=\"postcode\"");

WriteLiteral(">\r\n                                    Enter postcode");

WriteLiteral("\r\n                                    <p>\r\n");

            
            #line 44 "..\..\Views\Standard\Detail.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Standard\Detail.cshtml"
                                          
                                            Html.RenderPartial("_BlankFieldErrorMessage");
                                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </p>\r\n                                </lab" +
"el>\r\n                                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"standardid\"");

WriteLiteral(" name=\"standardid\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2088), Tuple.Create("\"", 2113)
            
            #line 49 "..\..\Views\Standard\Detail.cshtml"
                                            , Tuple.Create(Tuple.Create("", 2096), Tuple.Create<System.Object, System.Int32>(Model.StandardId
            
            #line default
            #line hidden
, 2096), false)
);

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"postcode\"");

WriteLiteral(" name=\"PostCode\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(">\r\n                            </div>\r\n                            <input");

WriteLiteral(" class=\"button margin-top-x2\"");

WriteLiteral(" id=\"submit-keywords\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n                        </form>\r\n\r\n                    </aside>\r\n           " +
"     </div>\r\n");

            
            #line 57 "..\..\Views\Standard\Detail.cshtml"
             }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <section>\r\n            <header>\r\n" +
"                <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                    Summary of apprenticeship standard\r\n                </h2>\r" +
"\n            </header>\r\n            <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 69 "..\..\Views\Standard\Detail.cshtml"
           Write(GetStandardProperty("Overview of role", Model.OverviewOfRoleHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 70 "..\..\Views\Standard\Detail.cshtml"
           Write(GetStandardLevel(@Model.NotionalEndLevel.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 71 "..\..\Views\Standard\Detail.cshtml"
           Write(GetStandardProperty("Typical length", @Model.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 72 "..\..\Views\Standard\Detail.cshtml"
           Write(GetStandardProperty("Entry requirements", Model.EntryRequirementsHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 73 "..\..\Views\Standard\Detail.cshtml"
           Write(GetStandardProperty("What apprentices will learn", Model.WhatApprenticesWillLearnHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 74 "..\..\Views\Standard\Detail.cshtml"
           Write(GetStandardProperty("Qualifications", Model.QualificationsHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 75 "..\..\Views\Standard\Detail.cshtml"
           Write(GetStandardProperty("Professional registration", Model.ProfessionalRegistrationHtml, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dl>\r\n");

            
            #line 77 "..\..\Views\Standard\Detail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\Standard\Detail.cshtml"
             if (!string.IsNullOrEmpty($"{Model.AssessmentPlanPdfUrlTitle}{Model.StandardPdfUrlTitle}"))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"panel-indent panel-indent-info\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                        Documents\r\n                    </h2>\r\n                " +
"    <ul>\r\n");

WriteLiteral("                        ");

            
            #line 84 "..\..\Views\Standard\Detail.cshtml"
                   Write(GetDocumentItem(@Model.StandardPdfUrl, @Model.StandardPdfUrlTitle));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 85 "..\..\Views\Standard\Detail.cshtml"
                   Write(GetDocumentItem(@Model.AssessmentPlanPdfUrl, @Model.AssessmentPlanPdfUrlTitle));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n");

            
            #line 88 "..\..\Views\Standard\Detail.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </section>\r\n\r\n</main>\r\n\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
