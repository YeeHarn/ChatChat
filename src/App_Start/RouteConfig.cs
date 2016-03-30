using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ChatChat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Member Chat",
                url: "chat/{id}",
                defaults: new { controller = "Member", action = "Chat" }
            );

            routes.MapRoute(
                name: "Agent Dashboard",
                url: "agent/{action}",
                defaults: new {controller = "Agent", action = "Login" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Member", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
