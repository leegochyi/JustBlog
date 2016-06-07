using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JustBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute(
            //    "Post",
            //    "Archive/Post/{year}-{month}-{day}",
            //    new { controller = "Blog", action = "Post" },
            //    new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
            //);

            routes.MapRoute(
                "Post",
                "Archive/{year}/{month}/{title}",
                new { controller = "Blog", action = "Post" }
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Blog", action = "Posts", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               "Category",
               "Category/{category}",
                new { controller = "Blog", action = "Category" }
                );

            routes.MapRoute(
                "Tag",
                "Tag/{tag}",
                new { controller = "Blog", action = "Tag" }
                );
        }
    }
}
