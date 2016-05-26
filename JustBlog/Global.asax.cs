using Ninject;
using Ninject.Web.Common;
using System.Web.Mvc;
using System.Web.Routing;
using System;
using JustBlog;
using JustBlog.Core;



namespace JustBlog
{
    //public class MvcApplication : System.Web.HttpApplication
    //{
    //    protected void Application_Start()
    //    {
    //        AreaRegistration.RegisterAllAreas();
    //        RouteConfig.RegisterRoutes(RouteTable.Routes);
    //    }
    //}

    public class MvcApplication : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Load(new RepositoryModule());
            kernel.Bind<IBlogRepository>().To<BlogRepository>();

            return kernel;
        }

        protected override void OnApplicationStarted()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            base.OnApplicationStarted();
        }
    }
}
