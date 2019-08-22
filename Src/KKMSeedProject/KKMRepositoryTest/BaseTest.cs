using Moq;
using KKM.Repository.Common.Interface;
using KKM.Repository.Host.Controllers;
using KKM.Repository.Repository;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;

namespace MB.Repository.Test
{
    public class BaseTest
    {

        protected static Mock<ISeedProject> SeedRedository = new Mock<ISeedProject>();

        protected static UserController userControllerTest = null;
        


        protected BaseTest()
        {
            userControllerTest = new UserController(SeedRedository.Object) { Request = new HttpRequestMessage() { Properties = { { HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration() } } } };
           
        }
    }
}


