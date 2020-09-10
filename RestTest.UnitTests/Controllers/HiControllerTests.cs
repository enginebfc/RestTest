using Microsoft.AspNetCore.Mvc;
using Moq;
using RestTest.Controllers;
using RestTest.Interfaces;
using WebApi.Models;
using Xunit;

namespace RestTest.UnitTests.Controllers
{
    public class HiControllerTests
    {
        public Mock<IHiRepository> Stub { get; set; }
        HiController Controller { get; set; }

        public HiControllerTests()
        {
            Stub = new Mock<IHiRepository>();
            Stub.Setup(x => x.Get(It.IsAny<int>())).Returns(new WebApi.Models.HiModel());
            Controller = new HiController(Stub.Object);
        }

        [Fact]
        public void Get_Returns_Ok()
        {
            var resp = Controller.Get(1);
            Stub.Verify(x => x.Get(It.IsAny<int>()), Times.Once);
            Assert.IsType<ActionResult<HiModel>>(resp);
        }


    }
}
