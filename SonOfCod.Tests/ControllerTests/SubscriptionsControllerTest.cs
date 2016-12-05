using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class SubscriptionsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            SubscriptionsController controller = new SubscriptionsController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
        
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            SubscriptionsController controller = new SubscriptionsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = new SubscriptionsController().Index() as ViewResult;
            //Act
            var result = indexView.ViewData.Model;
            //Assert
            Assert.IsType<List<Subscriber>>(result);
        }
    }
}
