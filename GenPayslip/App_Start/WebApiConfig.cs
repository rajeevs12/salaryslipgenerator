
using BussinessLogic;
using IBussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;
using WebApiDepInject.Models;

namespace GenPayslip
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

           


            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Unity configuration
            var container = new UnityContainer();
            container.RegisterType<IPaySlip, PaySlip>(new HierarchicalLifetimeManager());
            container.RegisterType<IPaySlipType, ClsPaySlip>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            //this
          //  config.DependencyResolver = new UnityDependencyResolver(container);

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

        }
    }
}
