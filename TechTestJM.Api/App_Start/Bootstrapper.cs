using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using TechTestJM.Business.Interfaces;
using TechTestJM.Data.Service;
using TechTestJM.Data.Service.Interfaces;
using TechTestJM.Model.Factories;
using TechTestJM.Model.Interfaces;
using TechTestJM.Support.JsonHelper;

namespace TechTestJM.Api.App_Start
{
    public static class Bootstrapper
    {
        public static void ConfigureAutofac()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest().PropertiesAutowired();
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterAssemblyTypes(typeof(IBusiness).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            #region Services
            builder.RegisterType<EmployeeService>().As<IEmployeeService>().InstancePerLifetimeScope().PropertiesAutowired();
            #endregion

            #region Helpers
            builder.RegisterType<JsonRequestHelper>().As<IJsonRequestHelper>().PropertiesAutowired();
            #endregion

            #region Factories
            builder.RegisterType<EmployeeFactory>().As<IEmployeeFactory>().InstancePerLifetimeScope().PropertiesAutowired();
            #endregion

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = resolver;
        }
    }
}