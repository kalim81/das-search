﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Sfa.Das.Sas.Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Cookies",
                url: "cookies",
                defaults: new { controller = "Start", action = "Cookies", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Start", action = "Start", id = UrlParameter.Optional });
        }
    }
}
