using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Domain;
using Repository;
using Services;
using Unity;
using Unity.WebApi;

namespace SalariosITUruguayRestService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<SalariosITUruguayDBEntities, SalariosITUruguayDBEntities>();
            container.RegisterType<IRepository, EntityFrameworkRepository<SalariosITUruguayDBEntities>>();
            container.RegisterType<ICompanyService, CompanyService>();
            config.DependencyResolver = new UnityDependencyResolver(container);

            // Web API configuration and services

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
