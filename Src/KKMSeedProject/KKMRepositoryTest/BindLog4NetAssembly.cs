using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace MB.Repository.Test
{
    [TestClass]
    public class BindLog4NetAssembly
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
