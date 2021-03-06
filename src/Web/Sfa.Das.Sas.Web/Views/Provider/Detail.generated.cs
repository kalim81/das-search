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

namespace Sfa.Das.Sas.Web.Views.Provider
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
    
    #line 7 "..\..\Views\Provider\Detail.cshtml"
    using FeatureToggle.Core.Fluent;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.ApplicationServices.FeatureToggles;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.ApplicationServices.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 1 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/Detail.cshtml")]
    public partial class Detail : System.Web.Mvc.WebViewPage<ApprenticeshipDetailsViewModel>
    {

#line 102 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult ShowTrainingLocation(string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 103 "..\..\Views\Provider\Detail.cshtml"
 
if (@Model != null)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 106 "..\..\Views\Provider\Detail.cshtml"
              WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");


#line 107 "..\..\Views\Provider\Detail.cshtml"

    if (@Model.DeliveryModes.Count == 1 && @Model.DeliveryModes.Contains("100PercentEmployer"))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                Training takes place at your location\r\n            </dd>\r\n");


#line 113 "..\..\Views\Provider\Detail.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 117 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.Location.LocationName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 117 "..\..\Views\Provider\Detail.cshtml"
               WriteTo(__razor_helper_writer, Model.Address.Address1);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 117 "..\..\Views\Provider\Detail.cshtml"
                                       WriteTo(__razor_helper_writer, Model.Address.Address2);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 117 "..\..\Views\Provider\Detail.cshtml"
                                                               WriteTo(__razor_helper_writer, Model.Address.Town);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 117 "..\..\Views\Provider\Detail.cshtml"
                                                                                   WriteTo(__razor_helper_writer, Model.Address.County);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 117 "..\..\Views\Provider\Detail.cshtml"
                                                                                                         WriteTo(__razor_helper_writer, Model.Address.Postcode);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </dd>\r\n");


#line 119 "..\..\Views\Provider\Detail.cshtml"
    }
}


#line default
#line hidden
});

#line 121 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 123 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 124 "..\..\Views\Provider\Detail.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"phone-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 127 "..\..\Views\Provider\Detail.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 5329), Tuple.Create("\"", 5337)

#line 128 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5334), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 5334), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"phone\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 128 "..\..\Views\Provider\Detail.cshtml"
     WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 129 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 130 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 132 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetEmailPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 133 "..\..\Views\Provider\Detail.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"email-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 136 "..\..\Views\Provider\Detail.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 5589), Tuple.Create("\"", 5597)

#line 137 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5594), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 5594), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"email\"");

WriteLiteralTo(__razor_helper_writer, "><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 5615), Tuple.Create("\"", 5644)
, Tuple.Create(Tuple.Create("", 5622), Tuple.Create("mailto:", 5622), true)

#line 137 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5629), Tuple.Create<System.Object, System.Int32>(Html.Raw(item)

#line default
#line hidden
, 5629), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 137 "..\..\Views\Provider\Detail.cshtml"
                                      WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 138 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 139 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 141 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyAsLinkHtml(string title, string cssClass, string classTitle, string classIdentifier, string url, string urlTitle = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 142 "..\..\Views\Provider\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(url))
    {
        var linkProtocol = url.StartsWith("http") ? string.Empty : "http://";


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5968), Tuple.Create("\"", 5987)

#line 146 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5976), Tuple.Create<System.Object, System.Int32>(classTitle

#line default
#line hidden
, 5976), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 146 "..\..\Views\Provider\Detail.cshtml"
      WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd>\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 6038), Tuple.Create("\"", 6062)

#line 148 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 6045), Tuple.Create<System.Object, System.Int32>(linkProtocol

#line default
#line hidden
, 6045), false)

#line 148 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 6058), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 6058), false)
);

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6094), Tuple.Create("\"", 6128)

#line 148 "..\..\Views\Provider\Detail.cshtml"
  , Tuple.Create(Tuple.Create("", 6102), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 6102), false)

#line 148 "..\..\Views\Provider\Detail.cshtml"
           , Tuple.Create(Tuple.Create(" ", 6111), Tuple.Create<System.Object, System.Int32>(classIdentifier

#line default
#line hidden
, 6112), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 149 "..\..\Views\Provider\Detail.cshtml"
                    

#line default
#line hidden

#line 149 "..\..\Views\Provider\Detail.cshtml"
                     if (string.IsNullOrEmpty(urlTitle))
                    {
                        

#line default
#line hidden

#line 151 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, url);


#line default
#line hidden

#line 151 "..\..\Views\Provider\Detail.cshtml"
                            
                    }
                    else
                    {
                        

#line default
#line hidden

#line 155 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, urlTitle);


#line default
#line hidden

#line 155 "..\..\Views\Provider\Detail.cshtml"
                                 
                    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                </a>\r\n            </dd>\r\n");


#line 159 "..\..\Views\Provider\Detail.cshtml"
    }


#line default
#line hidden
});

#line 160 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 162 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetSatisfactionsHtml()
 {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 163 "..\..\Views\Provider\Detail.cshtml"
  


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "     <div");

WriteLiteralTo(__razor_helper_writer, " class=\"rates-list\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n         <div>\r\n             <b>Employer satisfaction:</b>\r\n             <span" +
"");

WriteLiteralTo(__razor_helper_writer, " id=\"employer-satisfaction\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 168 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.EmployerSatisfactionMessage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </span>\r\n");

WriteLiteralTo(__razor_helper_writer, "             ");


#line 170 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, CreateProgressBar(Model.EmployerSatisfactionMessage, Model.EmployerSatisfaction));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n         </div>\r\n\r\n\r\n         <div>\r\n             <b>Learner satisfaction:</b>\r" +
"\n             <span");

WriteLiteralTo(__razor_helper_writer, " id=\"learner-satisfaction\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 177 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.LearnerSatisfactionMessage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </span>\r\n");

WriteLiteralTo(__razor_helper_writer, "             ");


#line 179 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, CreateProgressBar(Model.LearnerSatisfactionMessage, (int)Model.LearnerSatisfaction));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\r\n        </div>\r\n\r\n");


#line 183 "..\..\Views\Provider\Detail.cshtml"
        

#line default
#line hidden

#line 183 "..\..\Views\Provider\Detail.cshtml"
         if (!(Model.EmployerSatisfactionMessage == "no data available" && Model.LearnerSatisfactionMessage == "no data available"))
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <p");

WriteLiteralTo(__razor_helper_writer, " class=\"satisfaction-source font-small\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                Source: <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 7299), Tuple.Create("\"", 7334)

#line 186 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 7306), Tuple.Create<System.Object, System.Int32>(Model.SatisfactionSourceUrl

#line default
#line hidden
, 7306), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">Skills Funding Agency FE Choices</a>\r\n            </p>\r\n");


#line 188 "..\..\Views\Provider\Detail.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <hr/>\r\n\r\n         <div>\r\n             <b>Achievement rate:</b>\r\n         " +
"    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"national-rate\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                 ");


#line 194 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.AchievementRateMessage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n             </span>\r\n");


#line 196 "..\..\Views\Provider\Detail.cshtml"
             

#line default
#line hidden

#line 196 "..\..\Views\Provider\Detail.cshtml"
              if (Model.AchievementRateMessage != "no data available")
             {
                 

#line default
#line hidden

#line 198 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, CreateProgressBar(Model.AchievementRateMessage, Model.AchievementRate));


#line default
#line hidden

#line 198 "..\..\Views\Provider\Detail.cshtml"
                                                                                        
             }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "         </div>\r\n");


#line 201 "..\..\Views\Provider\Detail.cshtml"
         

#line default
#line hidden

#line 201 "..\..\Views\Provider\Detail.cshtml"
          if (Model.AchievementRateMessage != "no data available")
         {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "             <div");

WriteLiteralTo(__razor_helper_writer, " class=\"national-achievement-bar\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                 <b");

WriteLiteralTo(__razor_helper_writer, " class=\"font-small\"");

WriteLiteralTo(__razor_helper_writer, ">National average:</b>\r\n                 <span");

WriteLiteralTo(__razor_helper_writer, " class=\"national-rate\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                     ");


#line 206 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.NationalAchievementRateMessage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                 </span>\r\n");

WriteLiteralTo(__razor_helper_writer, "                 ");


#line 208 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, CreateProgressBar(Model.NationalAchievementRateMessage, Model.NationalAchievementRate));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n             </div>\r\n");


#line 210 "..\..\Views\Provider\Detail.cshtml"
         }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");


#line 211 "..\..\Views\Provider\Detail.cshtml"
         if (Model.AchievementRateMessage != "no data available")
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <details");

WriteLiteralTo(__razor_helper_writer, " class=\"more-information\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <summary>More information</summary>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <p>Achievement rates based on latest figures for similar a" +
"pprenticeship training with this training provider.</p>\r\n                    <p>" +
"Achievement rate sample size: ");


#line 217 "..\..\Views\Provider\Detail.cshtml"
                       WriteTo(__razor_helper_writer, Model.OverallCohort);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</p>\r\n                    <p");

WriteLiteralTo(__razor_helper_writer, " class=\"font-small\"");

WriteLiteralTo(__razor_helper_writer, ">Source: <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 8784), Tuple.Create("\"", 8822)

#line 218 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 8791), Tuple.Create<System.Object, System.Int32>(Model.AchievementRateSourceUrl

#line default
#line hidden
, 8791), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, ">Skills Funding Agency apprenticeship achievement rates</a></p>\r\n                " +
"</div>\r\n            </details>\r\n");


#line 221 "..\..\Views\Provider\Detail.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        \r\n    </div>\r\n");


#line 224 "..\..\Views\Provider\Detail.cshtml"


#line default
#line hidden
});

#line 224 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 226 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult CreateProgressBar(string message, int progress)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 227 "..\..\Views\Provider\Detail.cshtml"
 
    if (message != "no data available")
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 9191), Tuple.Create("\"", 9216)
, Tuple.Create(Tuple.Create("", 9199), Tuple.Create("width:", 9199), true)

#line 231 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create(" ", 9205), Tuple.Create<System.Object, System.Int32>(progress

#line default
#line hidden
, 9206), false)
, Tuple.Create(Tuple.Create("", 9215), Tuple.Create("%", 9215), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n        </div>\r\n");


#line 233 "..\..\Views\Provider\Detail.cshtml"
    }


#line default
#line hidden
});

#line 234 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 236 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetDeliveryModesHtml(string title, List<string> items, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 237 "..\..\Views\Provider\Detail.cshtml"
 
if (items != null)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"training-structure\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 240 "..\..\Views\Provider\Detail.cshtml"
         WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"delivery-modes\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <ul>\r\n");


#line 243 "..\..\Views\Provider\Detail.cshtml"
                

#line default
#line hidden

#line 243 "..\..\Views\Provider\Detail.cshtml"
                 if (items.Exists(m => m.Equals("DayRelease")))
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"day-release\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 245 "..\..\Views\Provider\Detail.cshtml"
              WriteTo(__razor_helper_writer, Html.Raw("day release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 246 "..\..\Views\Provider\Detail.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                ");


#line 247 "..\..\Views\Provider\Detail.cshtml"
                 if (items.Exists(m => m.Equals("BlockRelease")))
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"block-release\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 249 "..\..\Views\Provider\Detail.cshtml"
                WriteTo(__razor_helper_writer, Html.Raw("block release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 250 "..\..\Views\Provider\Detail.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                ");


#line 251 "..\..\Views\Provider\Detail.cshtml"
                 if (items.Exists(m => m.Equals("100PercentEmployer")))
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"hundred-percent-employer\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 253 "..\..\Views\Provider\Detail.cshtml"
                           WriteTo(__razor_helper_writer, Html.Raw("at your location"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 254 "..\..\Views\Provider\Detail.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n            <details>\r\n                <summary>Explain traini" +
"ng options</summary>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <p>\r\n                        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">Day release:</span> for example one day a week at the training provider\'s locati" +
"on.\r\n                    </p>\r\n                    <p>\r\n                        " +
"<span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">Block release:</span> for example 3-4 weeks at the training provider\'s location." +
"\r\n                    </p>\r\n                    <p>\r\n                        <sp" +
"an");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">At your location:</span> the training provider comes to your workplace.\r\n       " +
"             </p>\r\n                </div>\r\n            </details>\r\n        </dd>" +
"\r\n");


#line 271 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 272 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

        public Detail()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Views\Provider\Detail.cshtml"
  
    ViewBag.Title = @Model.Name + " - Apprenticeship Provider";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"provider-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"provider-name\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 18 "..\..\Views\Provider\Detail.cshtml"
               Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n");

            
            #line 20 "..\..\Views\Provider\Detail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Provider\Detail.cshtml"
                 if (Is<NationalProvidersFeature>.Enabled && Model.NationalProvider)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" class=\"national-message\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"tag tag-new\"");

WriteLiteral(">National</span> This training provider is willing to offer apprenticeship traini" +
"ng across England.\r\n                    </p>\r\n");

            
            #line 25 "..\..\Views\Provider\Detail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" id=\"marketing\"");

WriteLiteral(" class=\"provider-marketing-info\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 27 "..\..\Views\Provider\Detail.cshtml"
               Write(Html.MarkdownToHtml(Model.ProviderMarketingInfo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <section>\r\n          " +
"      <header");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large apprenticeship-name-level\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 34 "..\..\Views\Provider\Detail.cshtml"
                   Write(Model.ApprenticeshipName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </h2>\r\n                    <b>Level:</b>\r\n                 " +
"   <span>\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Views\Provider\Detail.cshtml"
                   Write(Model.ApprenticeshipLevel);

            
            #line default
            #line hidden
WriteLiteral(" (equivalent to ");

            
            #line 38 "..\..\Views\Provider\Detail.cshtml"
                                                             Write(EquivalenveLevelService.GetApprenticeshipLevel(@Model.ApprenticeshipLevel));

            
            #line default
            #line hidden
WriteLiteral(")\r\n                    </span>\r\n                </header>\r\n                <dl");

WriteLiteral(" class=\"data-list data-list--compact\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 42 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyAsLinkHtml("Website:", "course-link", "apprenticeshipContactTitle", "apprenticeshipContact", @Model.Apprenticeship.ApprenticeshipInfoUrl, "training provider website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 43 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyHtml("Phone:", "phone", Model.ContactInformation.Phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Provider\Detail.cshtml"
               Write(GetEmailPropertyHtml("Email:", "email", Model.ContactInformation.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyAsLinkHtml("Contact page:", "contact-link", "providerContactTitle", "providerContact", @Model.ContactInformation.ContactUsUrl, "contact this training provider"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\Views\Provider\Detail.cshtml"
               Write(GetDeliveryModesHtml("Training options:", Model.DeliveryModes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 47 "..\..\Views\Provider\Detail.cshtml"
               Write(ShowTrainingLocation("Training location:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dl>\r\n\r\n            </section>\r\n\r\n            <section>\r\n     " +
"           <header>\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Apprenticeship training information</h2>\r\n                </header>\r\n           " +
"     <article");

WriteLiteral(" class=\"apprenticeship-marketing-info\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 57 "..\..\Views\Provider\Detail.cshtml"
               Write(Html.MarkdownToHtml(Model.Apprenticeship.ApprenticeshipMarketingInfo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <p><em>Content maintained by ");

            
            #line 58 "..\..\Views\Provider\Detail.cshtml"
                                            Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n                    </p>\r\n                </article>\r\n            </sectio" +
"n>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                        Training provider quality assessment\r\n                " +
"    </h2>\r\n");

WriteLiteral("                    ");

            
            #line 70 "..\..\Views\Provider\Detail.cshtml"
               Write(GetSatisfactionsHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </aside>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n   " +
" <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"survey-panel\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"bold-large\"");

WriteLiteral(@">
                    Give us your feedback
                </h2>
                <p>
                    This is a new service and your feedback will help us improve it.<br />
                    Use the link below to take part in a short survey.
                </p>
                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3821), Tuple.Create("\"", 3844)
            
            #line 87 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 3828), Tuple.Create<System.Object, System.Int32>(Model.SurveyUrl
            
            #line default
            #line hidden
, 3828), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Take the survey</a>\r\n            </div>\r\n            <aside");

WriteLiteral(" class=\"disclaimer\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(@">Content disclaimer</h3>
                <p>
                    Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes no representations about the quality of any courses which appear on the site. Skills Funding Agency is not liable for any losses suffered as a result of any party relying on the course information provided.
                </p>
            </aside>
        </div>
    </div>

</main>



");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
