using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
//using hr_management.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using hr_management;
using hr_management.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class AuthEmployeeTest
    {
        [TestMethod]
        
        public void IndexMethod()
        {
            //Arrange
            AuthEmployeeController controller = new AuthEmployeeController();

            //Act
            var result = controller.Index() as ViewResult;
            

            //Assert
            Assert.AreEqual("Index",result.ViewName);
            
        }
    }
}
