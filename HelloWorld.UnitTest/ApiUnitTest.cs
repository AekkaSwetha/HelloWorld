using System;
using HelloWorld.API.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.UnitTest
{
    [TestClass]
    public class ApiUnitTest
    {
        [TestMethod]
        public void ApiTest_Get_HelloWorld()
        {
            var controller = new HelloWorldController();
            var result = controller.Get() as string;
            Assert.AreEqual("Hello World", result);
        }
    }
}
