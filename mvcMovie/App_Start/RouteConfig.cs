using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Hello route
            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}"
            );

            // Movies route
            routes.MapRoute(
                name: "Movies",
                url: "{controller}/{action}/{name}/{id}"
            );
        }
    }
}
