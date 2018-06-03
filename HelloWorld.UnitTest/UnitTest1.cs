using System;
using HelloWorld.API.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new HelloWorldController();
            var result = controller.Get() as string;
            Assert.AreEqual("Hello World", result);
        }
    }
}
