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
    
    #line 3 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using FeatureToggle.Core.Fluent;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.ApplicationServices.FeatureToggles;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 1 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResultViewModel>
    {

#line 99 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 100 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage <= 1)
    {
        return;
    }

    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(previousPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4225), Tuple.Create("\"", 4236)

#line 108 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4232), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4232), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 111 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 111 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n    </a>\r\n");


#line 113 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 113 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 116 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 117 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage >= Model.LastPage || Model.ActualPage < 0)
    {
        return;
    }

    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(nextPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4866), Tuple.Create("\"", 4877)

#line 126 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4873), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4873), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 129 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 129 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n    </a>\r\n");


#line 131 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 131 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        #line 135 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<LevelAggregationViewModel> selectedLevels, string order)
    {

        var rv = new RouteValueDictionary { { "keywords", Model.SearchTerm }, { "page", page }, { "order", order }, { "take", Model.ResultsToTake } };
        var i = 0;
        foreach (var level in selectedLevels.Where(m => m.Checked))
        {
            rv.Add("SelectedLevels[" + i + "]", level.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden

#line 151 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 152 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 154 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Standard", "Apprenticeship", new { @id = item.StandardId, @keywords = Model.SearchTerm }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"tag tag-new\"");

WriteLiteralTo(__razor_helper_writer, ">New</span>\r\n    </h2>\r\n");


#line 157 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 157 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 159 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 160 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 162 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Framework", "Apprenticeship", new { @id = item.FrameworkId, @keywords = Model.SearchTerm }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </h2>\r\n");


#line 164 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 164 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 166 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetApprenticeshipDetailItem(string title, string id, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 167 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (string.IsNullOrEmpty(item))
    {
        return;
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt><b>");


#line 172 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b></dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6459), Tuple.Create("\"", 6470)

#line 173 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6467), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 6467), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 173 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 173 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 174 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 174 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 176 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string className)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 177 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.TotalResults <= 0)
    {
        return;
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6611), Tuple.Create("\"", 6643)
, Tuple.Create(Tuple.Create("", 6619), Tuple.Create("filters-block", 6619), true)

#line 183 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 6632), Tuple.Create<System.Object, System.Int32>(className

#line default
#line hidden
, 6633), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n        <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"Keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6743), Tuple.Create("\"", 6768)

#line 185 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6751), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm

#line default
#line hidden
, 6751), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"order\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6819), Tuple.Create("\"", 6843)

#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6827), Tuple.Create<System.Object, System.Int32>(Model.SortOrder

#line default
#line hidden
, 6827), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n\r\n            <fieldset");

WriteLiteralTo(__razor_helper_writer, " class=\"filters filters-accordion\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"toggler heading-small\"");

WriteLiteralTo(__razor_helper_writer, ">Apprenticeship level</h2>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"toggled-content\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <ul");

WriteLiteralTo(__razor_helper_writer, " name=\"alist22\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 192 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        

#line default
#line hidden

#line 192 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         foreach (var item in Model.AggregationLevel.OrderBy(m => m.Value))
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li>\r\n                                <input");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 7266), Tuple.Create("\"", 7285)

#line 195 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7274), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7274), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 7286), Tuple.Create("\"", 7319)
, Tuple.Create(Tuple.Create("", 7291), Tuple.Create("SelectedLevels_", 7291), true)

#line 195 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7306), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7306), false)
);

WriteLiteralTo(__razor_helper_writer, " name=\"SelectedLevels\"");

WriteLiteralTo(__razor_helper_writer, " type=\"checkbox\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 195 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                     WriteTo(__razor_helper_writer, Html.Raw(item.Checked ? "checked" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 195 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                                              WriteTo(__razor_helper_writer, Html.Raw(item.Count == 0 ? "disabled" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " />\r\n                                <label");

WriteAttributeTo(__razor_helper_writer, "for", Tuple.Create(" for=\"", 7487), Tuple.Create("\"", 7521)
, Tuple.Create(Tuple.Create("", 7493), Tuple.Create("SelectedLevels_", 7493), true)

#line 196 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7508), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7508), false)
);

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 7522), Tuple.Create("\"", 7574)

#line 196 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 , Tuple.Create(Tuple.Create("", 7530), Tuple.Create<System.Object, System.Int32>(Html.Raw(item.Count == 0 ? "disabled" : "")

#line default
#line hidden
, 7530), false)
);

WriteLiteralTo(__razor_helper_writer, ">level ");


#line 196 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                       WriteTo(__razor_helper_writer, item.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " (");


#line 196 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                    WriteTo(__razor_helper_writer, item.Count);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ")</label>\r\n                            </li>\r\n");


#line 198 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    </ul>\r\n\r\n                    <details>\r\n                     " +
"   <summary>Explain levels</summary>\r\n                        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                            <p>Apprenticeships are set at different levels of " +
"difficulty from the equivalent of GCSE (level 2) up to postgraduate (level 7)</p" +
">\r\n                            <p><a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/what-different-qualification-levels-mean/overview\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, ">More about levels</a></p>\r\n                        </div>\r\n                    <" +
"/details>\r\n                    \r\n\r\n                </div>\r\n            </fieldse" +
"t>\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n        </form>\r\n    </div>\r\n");


#line 215 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 215 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Apprenticeship\SearchResults.cshtml"
   Write(Html.ActionLink("Start a new search", "Search", "Apprenticeship", new { }, new { @class = "link-back new-apprenticeship-search" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n    <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n            Search results\r\n        </h1>\r\n");

            
            #line 18 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Apprenticeship\SearchResults.cshtml"
              
                Html.RenderPartial("_SearchResultMessage");
            
            
            #line default
            #line hidden
WriteLiteral("\r\n    </hgroup>\r\n\r\n");

            
            #line 23 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Apprenticeship\SearchResults.cshtml"
     if(Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>You can:</p>\r\n");

WriteLiteral("        <ul");

WriteLiteral(" class=\"list-bullet\"");

WriteLiteral(">\r\n            <li>");

            
            #line 27 "..\..\Views\Apprenticeship\SearchResults.cshtml"
           Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship", new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        </ul>\r\n");

            
            #line 29 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n");

            
            #line 33 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Apprenticeship\SearchResults.cshtml"
         if (!Model.HasError && Model.TotalResults > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"editSearch\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#EditSearch\"");

WriteLiteral(">Filter results</a>\r\n                    </h2>\r\n                    <div");

WriteLiteral(" id=\"EditSearch\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 41 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 45 "..\..\Views\Apprenticeship\SearchResults.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"apprenticeship-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" method=\"GET\"");

WriteLiteral(" id=\"search-results-order\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Keywords\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1587), Tuple.Create("\"", 1612)
            
            #line 48 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1595), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 1595), false)
);

WriteLiteral("/>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1669), Tuple.Create("\"", 1694)
            
            #line 49 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1677), Tuple.Create<System.Object, System.Int32>(Model.ActualPage
            
            #line default
            #line hidden
, 1677), false)
);

WriteLiteral("/>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"take\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1751), Tuple.Create("\"", 1779)
            
            #line 50 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1759), Tuple.Create<System.Object, System.Int32>(Model.ResultsToTake
            
            #line default
            #line hidden
, 1759), false)
);

WriteLiteral("/>\r\n");

            
            #line 51 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                     foreach (var level in Model.AggregationLevel.Where(level => level.Checked))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SelectedLevels\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1971), Tuple.Create("\"", 1991)
            
            #line 53 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1979), Tuple.Create<System.Object, System.Int32>(level.Value
            
            #line default
            #line hidden
, 1979), false)
);

WriteLiteral("/>\r\n");

            
            #line 54 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-block\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"select-order\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Sort by</label>\r\n                        <select");

WriteLiteral(" name=\"order\"");

WriteLiteral(" id=\"select-order\"");

WriteLiteral(" class=\"form-control form-control-1-3\"");

WriteLiteral(">\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2294), Tuple.Create("\"", 2330)
            
            #line 58 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2305), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "1"
            
            #line default
            #line hidden
, 2305), false)
);

WriteLiteral(" value=\"1\"");

WriteLiteral(">Best match</option>\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2398), Tuple.Create("\"", 2434)
            
            #line 59 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2409), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "2"
            
            #line default
            #line hidden
, 2409), false)
);

WriteLiteral(" value=\"2\"");

WriteLiteral(">Level (high to low)</option>\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2511), Tuple.Create("\"", 2547)
            
            #line 60 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2522), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "3"
            
            #line default
            #line hidden
, 2522), false)
);

WriteLiteral(" value=\"3\"");

WriteLiteral(">Level (low to high)</option>\r\n                        </select>\r\n               " +
"         <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Sort\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Sort</button>\r\n                    </div>\r\n                </form>\r\n\r\n\r\n");

            
            #line 67 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             foreach (var item in Model.Results)
            {

            
            #line default
            #line hidden
WriteLiteral("                <article");

WriteAttribute("class", Tuple.Create(" class=\"", 2859), Tuple.Create("\"", 2907)
, Tuple.Create(Tuple.Create("", 2867), Tuple.Create("result", 2867), true)
            
            #line 69 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 2873), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 2874), false)
, Tuple.Create(Tuple.Create("", 2900), Tuple.Create("-result", 2900), true)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2908), Tuple.Create("\"", 3000)
            
            #line 69 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2913), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 2913), false)
, Tuple.Create(Tuple.Create("", 2939), Tuple.Create("-", 2939), true)
            
            #line 69 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                          , Tuple.Create(Tuple.Create("", 2940), Tuple.Create<System.Object, System.Int32>(item.StandardId != 0 ? item.StandardId : item.FrameworkId
            
            #line default
            #line hidden
, 2940), false)
);

WriteLiteral(">\r\n                    <header>\r\n");

WriteLiteral("                        ");

            
            #line 71 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    Write(item.StandardId > 0 ? GetStandardTitle(item) : GetFrameworkTitle(item));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </header>\r\n                    <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 74 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Level:", "level", item.Level));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Typical length:", "length", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </dl>\r\n                </article>\r\n");

            
            #line 78 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 82 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 85 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</main>\r\n\r\n");

            
            #line 90 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function () {\r\n            SearchAndShortli" +
"st.analytics.pushEvent(\"Apprenticeship Search\", \"No results\", \"Search\");\r\n      " +
"  }\r\n    </script>\r\n");

            
            #line 97 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
