using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SpaceStorium
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new
                              {
                                  controller = "ProductOverview",
                                  action = "ProductOverview",
                                  id = UrlParameter.Optional
                              });

            routes.MapRoute(
                name: "Detail",
                url: "Detail/{id}",
                defaults: new { controller = "ProductDetail", action = "ProductDetail", id = UrlParameter.Optional }
            );
        }
    }
}
