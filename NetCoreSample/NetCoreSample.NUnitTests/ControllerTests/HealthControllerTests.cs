using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NetCoreSample.Api.Controllers;
using NetCoreSample.Framework.Abstract;
using NetCoreSample.NUnitTests.Helpers.Fixtures;
using NetCoreSample.NUnitTests.Helpers.Mock;
using NUnit.Framework;

namespace NetCoreSample.NUnitTests.ControllerTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class HealthControllerTests : BaseTestFixture
    {
        #region members & setup

        StrictMock<ISettings> settings;

        HealthController controller;

        [SetUp]
        public void Initialize()
        {
            settings = new StrictMock<ISettings>();

            controller = new HealthController(settings.Object);
        }

        #endregion

        #region verify mocks

        protected override void VerifyMocks()
        {
            settings.VerifyAll();
        }

        #endregion

        [Test]
        public void Index_NoCondition_ReturnNegotiatedContentResult()
        {
            // Arrange

            // Act
            var result = controller.Index();

            // Assert
            result.Should().BeOfType<OkResult>();
        }

        [Test]
        public void Version_NoCondition_ReturnOkResultWithVersion()
        {
            // Arrange
            var version = "0.1.0.27";

            settings.Setup(x => x.ApplicationVersion).Returns(version);

            // Act
            var result = controller.Version();

            // Assert
            result.Should().BeOfType<OkObjectResult>(version);
        }
    }
}