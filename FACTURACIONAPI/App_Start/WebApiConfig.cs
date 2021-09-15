using System;
using System.Collections.Generic;
using System.Web.Http.Cors;
using System.Web.Http;

namespace FACTURACIONAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var enabledCorsAtributte = new EnableCorsAttribute("*", 
                "Origin, Content-Type,Accept",
                "GET,POST,PUT,DELETE","OPTIONS"
                );
            config.EnableCors(enabledCorsAtributte);

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
