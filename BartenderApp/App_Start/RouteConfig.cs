using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BartenderApp.Models;

namespace BartenderApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //long way to map route
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    "DrinksAlcoholAndMixer",
            //    "drinks/alcohol/{alcohol}/{mixer}",
            //    new { controller = "Drinks", action = "AlcoholAndMixer" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
