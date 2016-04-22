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

namespace Sfa.Eds.Das.Web.Views.Apprenticeship
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/_SearchResultMessage.cshtml")]
    public partial class SearchResultMessage : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.ApprenticeshipSearchResultViewModel>
    {

#line 27 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderErrorMessage()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 28 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"result-summary\"");

WriteLiteralTo(__razor_helper_writer, " class=\"results-error\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There was a problem performing a search. Try again later.\r\n    </p>\r\n");


#line 32 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"


#line default
#line hidden
});

#line 32 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
}
#line default
#line hidden

#line 33 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult RenderZeroResult()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 34 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"result-summary\"");

WriteLiteralTo(__razor_helper_writer, " class=\"results-empty\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There are no apprenticeships matching your search for \'<b>");


#line 36 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                                    WriteTo(__razor_helper_writer, Model.SearchTerm);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\r\n    </p>\r\n");


#line 38 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"


#line default
#line hidden
});

#line 38 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
}
#line default
#line hidden

#line 39 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderAllResult()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 40 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"result-summary\"");

WriteLiteralTo(__razor_helper_writer, " class=\"results-all\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        All apprenticeships.\r\n    </p>\r\n");


#line 44 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
    

#line default
#line hidden

#line 44 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
WriteTo(__razor_helper_writer, RenderStandardMessage());


#line default
#line hidden

#line 44 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                            


#line default
#line hidden
});

#line 45 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
}
#line default
#line hidden

#line 46 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderMessageOneResult()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 47 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"result-summary\"");

WriteLiteralTo(__razor_helper_writer, " class=\"results-one\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There is <b>");


#line 49 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
WriteTo(__razor_helper_writer, Model.TotalResults);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> apprenticeship matching your search for \'<b>");


#line 49 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                                                          WriteTo(__razor_helper_writer, Model.SearchTerm);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\r\n    </p>\r\n");


#line 51 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
    

#line default
#line hidden

#line 51 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
WriteTo(__razor_helper_writer, RenderStandardMessage());


#line default
#line hidden

#line 51 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                            


#line default
#line hidden
});

#line 52 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
}
#line default
#line hidden

#line 54 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderMessage()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 55 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"result-summary\"");

WriteLiteralTo(__razor_helper_writer, " class=\"results-several\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There are <b>");


#line 57 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
WriteTo(__razor_helper_writer, Model.TotalResults);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> apprenticeships matching your search for \'<b>");


#line 57 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                                                            WriteTo(__razor_helper_writer, Model.SearchTerm);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\r\n    </p>\r\n");


#line 59 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
    

#line default
#line hidden

#line 59 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
WriteTo(__razor_helper_writer, RenderStandardMessage());


#line default
#line hidden

#line 59 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                            


#line default
#line hidden
});

#line 60 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
}
#line default
#line hidden

#line 62 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult RenderStandardMessage()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 63 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " class=\"labelmessage\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        Results labelled <strong");

WriteLiteralTo(__razor_helper_writer, " class=\"new\"");

WriteLiteralTo(__razor_helper_writer, ">new</strong> are apprenticeship standards developed by employer groups.\r\n    </p" +
">\r\n");


#line 67 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"


#line default
#line hidden
});

#line 67 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
}
#line default
#line hidden

        public SearchResultMessage()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div>\r\n");

            
            #line 4 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
     if (Model.HasError)
    {
        
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
   Write(RenderErrorMessage());

            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                             
    }
    else if (Model.TotalResults == 0)
    {
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
   Write(RenderZeroResult());

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                           
        ;
    }
    else if (string.IsNullOrEmpty(Model.SearchTerm) || Model.SearchTerm == "*")
    {
        
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
   Write(RenderAllResult());

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                          
    }
    else if (Model.TotalResults == 1)
    {
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
   Write(RenderMessageOneResult());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                                 
    }
    else
    {
        
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
   Write(RenderMessage());

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Apprenticeship\_SearchResultMessage.cshtml"
                        
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
