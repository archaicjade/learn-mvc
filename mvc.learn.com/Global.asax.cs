using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using Autofac.Configuration;
using ClassLibrary2;

namespace mvc.learn.com
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ContainerBuilder builder = new ContainerBuilder();

            //builder.RegisterControllers(Assembly.GetExecutingAssembly());//注册了当前程序集内所有的Controller类
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .AsImplementedInterfaces();//注册了当前程序集内的所有类。

            //var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //builder.RegisterType<DBLog>().As<ILog>();

            var basetype = typeof(IDependency);
            var assemblys = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var allservces = assemblys
                .SelectMany(s => s.GetTypes())
                .Where(p => basetype.IsAssignableFrom(p) && p != basetype);

            builder.RegisterControllers(assemblys.ToArray());
            builder.RegisterAssemblyTypes(assemblys.ToArray())
                .Where(t => basetype.IsAssignableFrom(t) && t != basetype)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
