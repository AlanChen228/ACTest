using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{name}",
                defaults: new { name = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetCandidateByName",
                routeTemplate: "api/{controller}/name/{name}",
                defaults: new { name = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetCandidateById",
                routeTemplate: "api/{controller}/id/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetCandidateByNameAndId",
                routeTemplate: "api/{controller}/{name}/{id}",
                defaults: new { name = RouteParameter.Optional, id = RouteParameter.Optional }
            );
        }
    }
}
