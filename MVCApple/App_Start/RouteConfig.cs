using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCApple
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Mac",
                url: "mac",
                defaults: new { controller = "Mac", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Pad",
                url: "ipad",
                defaults: new { controller = "Pad", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Phone",
                url: "iphone",
                defaults: new { controller = "Phone", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AppleWatch",
                url: "Watch",
                defaults: new { controller = "Watch", action = "Index", id = UrlParameter.Optional }
            ); 
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
