    
using FewBox.Service.Log.Controllers;
using FewBox.Service.Log.Model.Configs;
using FewBox.Service.Log.Model.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FewBox.Service.Log.TestSuite
{
    [TestClass]
    public class HealthyControllerUnitTest
    {
        private HealthyController HealthyController { get; set; }

        [TestInitialize]
        public void Init()
        {
            // E.G: l.Method(It.IsAny<string>());
            var healthyConfig = Mock.Of<HealthyConfig>(l=>
                l.Version=="1.0.1");
            this.HealthyController = new HealthyController(healthyConfig);
        }


        [TestMethod]
        public void TestGet()
        {
            var response = this.HealthyController.Get();
            Assert.AreEqual("1.0.1", response.Payload.Version);
        }
    }
}