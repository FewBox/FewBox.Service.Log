
using AutoMapper;
using FewBox.Core.Web.Dto;
using FewBox.Service.Log.Controllers;
using FewBox.Service.Log.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FewBox.Service.Log.TestSuite
{
    [TestClass]
    public class LogsControllerUnitTest
    {
        private LogsController LogsController { get; set; }

        [TestInitialize]
        public void Init()
        {
            // E.G: l.Method(It.IsAny<string>());
            /*var exceptionLogRepository = Mock.Of<IExceptionLogRepository>();
            var traceLogRepository = Mock.Of<ITraceLogRepository>();
            var mapper = Mock.Of<IMapper>();
            this.LogsController = new LogsController(exceptionLogRepository, traceLogRepository, mapper);*/
        }


        /*[TestMethod]
        public void TestGet()
        {
            LogResponseDto response = this.LogsController.Post(new LogRequestDto {} );
            Assert.IsNotNull(response);
        }*/
    }
}