using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NetCoreSample.Api.Controllers;
using NetCoreSample.NUnitTests.Helpers.Fixtures;
using NUnit.Framework;

namespace NetCoreSample.NUnitTests.ControllerTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class HealthControllerTests : BaseTestFixture
    {
        #region members & setup

        HealthController controller;

        [SetUp]
        public void Initialize()
        {
            controller = new HealthController();
        }

        #endregion

        #region verify mocks

        protected override void VerifyMocks()
        {
            //TODO:
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
    }
}