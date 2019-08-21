using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using KKM.Repository.Host.Controllers;

namespace MB.Repository.Test
{
    [TestClass]
    public class HealthControllerTest
    {
        protected static HealthController healthController = null;
        [ClassInitialize]

        public static void RunFirst(TestContext context)

        {
            healthController = new HealthController();
            healthController.Request = new HttpRequestMessage();
            healthController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
        }

        [ClassCleanup]
        public static void RunLast()
        {
        }
        [TestInitialize]
        public void RunBeforeEachTest()
        {
        }

        [TestCleanup]
        public void RunAfterEachTest()
        {
        }
        [TestMethod]
        public void HealthControllerGetTest()
        {
            var response = healthController.Get();
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);

        }
    }
}
