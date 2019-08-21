using MB.Repository.Host.Filter;
using KKM.Repository.Host.TokenGenerator;
using System.Web.Http;

namespace MB.Repository.Host
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            // Web API configuration and services
           
            config.MapHttpAttributeRoutes();
            config.Filters.Add(new ModelValidateAttribute());
            config.MessageHandlers.Add(new TokenValidationHandler());
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional});
        }
    }
}