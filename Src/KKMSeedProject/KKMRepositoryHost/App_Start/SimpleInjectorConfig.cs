
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using KKM.Repository.Common.Interface;
using KKM.Repository.Repository;
using System.Web.Http;

namespace MB.Repository.Host
{
    public static class SimpleInjectorConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var container = new Container();
            container.Register<ISeedProject, SeedProject>();
            container.Register<ILoginUser, LoginUser>();
            container.Verify();            
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}