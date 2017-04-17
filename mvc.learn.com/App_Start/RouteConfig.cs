using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc.learn.com
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //            routes.MapRoute(
            //    name: "User",
            //    url: "admin/{action}/{userName}",
            //    defaults: new { controller = "User", action = "Login", userName = UrlParameter.Optional },
            //    constraints: new { userName = @"[\d]*" }
            //);

            routes.MapRoute(
                name: "Page1",
                url: "{controller}/{action}/page_{pageIndex}",
                defaults: new { controller = "User", action = "UserList", pageIndex = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
