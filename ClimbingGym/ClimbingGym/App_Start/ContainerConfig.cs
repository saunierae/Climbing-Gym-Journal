using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClimbingGym.Data.Services;
using System.Web.Http;

namespace ClimbingGym.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);            
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterType<InMemoryClimbingGymData>()
            //    .As<IClimbingGymData>()
            //    .InstancePerRequest();
            builder.RegisterType<ClimbingGymDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}