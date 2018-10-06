using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using hr_management;
using hr_management.Controllers;

namespace hr_management.Tests
{
    [TestClass]
    public class AuthEmployeeTest
    {
        [TestMethod]
        public void getEmployees()
        {
            //Arange
            AuthEmployeeController controller = new AuthEmployeeController();

            //Act
            ViewResult result = controller.getEmployees() as ViewResult;


            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddEmployee()
        {

            //Arange
            AuthEmployeeController controller = new AuthEmployeeController();

            //Act
            ViewResult result = controller.AddEmployee() as ViewResult;


            //Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void DeleteEmployee()
        {
            //Arange
            AuthEmployeeController controller = new AuthEmployeeController();

            //Act
            ViewResult result = controller.DeleteEmployee(1) as ViewResult;


            //Assert
            Assert.IsNotNull(result);
        }


    }
}
