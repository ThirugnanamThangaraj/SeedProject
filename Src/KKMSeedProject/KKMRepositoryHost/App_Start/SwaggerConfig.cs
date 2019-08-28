using System.Web.Http;
using WebActivatorEx;
using Swashbuckle.Application;
using KKM.Repository.Host;
using KKM.SeedRepository.Host;

using System.Configuration;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace KKM.Repository.Host
{
    public static class SwaggerConfig
    {
        private static string _EnableSwagger = ConfigurationManager.AppSettings["EnableSwagger"];
        public static void Register()
        {
           if (_EnableSwagger.Equals("true"))
           {
                GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "SSM.SeedProject.Host");
                        c.OperationFilter<AddRequiredHeaderParameter>();
                    })
                .EnableSwaggerUi(c => c.DisableValidator());
            }
        }
    }
}
