using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // e.g ignore this /trace,axd/1/2/3/4 
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // our map route
            // /home/contact/1
            /*
             * Maps URLS to controllers!
             */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
