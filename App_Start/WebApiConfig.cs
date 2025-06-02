using API_WEB_INMOBILIARIA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API_WEB_INMOBILIARIA
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.MessageHandlers.Add(new TokenValidationHandler());
            config.EnableCors();



            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
