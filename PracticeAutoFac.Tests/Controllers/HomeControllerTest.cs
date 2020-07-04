using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeAutoFac;
using PracticeAutoFac.Controllers;
using PracticeAutoFac.Models;

namespace PracticeAutoFac.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var person = new Person() { Name = "Test Person" };
            HomeController controller = new HomeController(person);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
