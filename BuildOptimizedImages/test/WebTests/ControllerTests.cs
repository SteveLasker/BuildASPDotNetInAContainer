using System;
using Xunit;
using Web.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebTests
{
    public class SocketInputTests
    {
        [Fact]
        public void TestHomeController()
        {
            var controllerUnderTest = new HomeController();
            var result = controllerUnderTest.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}