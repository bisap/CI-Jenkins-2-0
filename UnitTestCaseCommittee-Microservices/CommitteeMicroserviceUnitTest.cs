using Committee_Microservices.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace UnitTestCaseCommittee_Microservices
{
    public class CommitteeMicroserviceUnitTest
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();
            var actionResult =  controller.Get();
            var okResult = actionResult as OkObjectResult;
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}
