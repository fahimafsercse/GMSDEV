using GMS.BL;
using GMS.Interface.IRepository;
using GMS.Interface.IService;
using GMS.Repository;
using GMS.WebApi.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
namespace GMS.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //Dependency Injection
            var container = new UnityContainer();
            //Repository
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));

            //Service
           // container.RegisterType<IProductCategoryService, ProductCategoryService>();
            container.RegisterType<IProductCategoryService, ProductCategoryService>();
            container.RegisterType<IProductService, ProductService>();



            config.DependencyResolver = new UnityResolver(container);

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
