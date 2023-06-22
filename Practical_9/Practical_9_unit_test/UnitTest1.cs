using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practical_9.Controllers;
using System;
using System.Web.Mvc;

namespace Practical_9_unit_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController controller = new HomeController();



            ViewResult result = controller.Index() as ViewResult;


            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result.ViewData.Model);
        }
    }
}
