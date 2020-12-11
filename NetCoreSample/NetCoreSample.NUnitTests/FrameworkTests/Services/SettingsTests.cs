using FluentAssertions;
using NetCoreSample.Framework.Abstract;
using NetCoreSample.Framework.Services;
using NetCoreSample.Model;
using NetCoreSample.NUnitTests.Helpers.Fixtures;
using NetCoreSample.NUnitTests.Helpers.Mock;
using NUnit.Framework;

namespace NetCoreSample.NUnitTests.FrameworkTests.Services
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SettingsTests : BaseTestFixture
    {
        #region members & setup

        StrictMock<ISettingsReader> settingsReader;

        Settings settings;

        [SetUp]
        public void Initialize()
        {
            settingsReader = new StrictMock<ISettingsReader>();

            settings = new Settings(settingsReader.Object);
        }

        #endregion

        #region verify mocks

        protected override void VerifyMocks()
        {
            settingsReader.VerifyAll();
        }

        #endregion

        #region application version

        [Test]
        public void ApplicationVersion_NoCondition_ReturnValue()
        {
            // Arrange
            const string value = "test";
            var key = ConfigKey.ApplicationVersion.ToString();

            settingsReader.Setup(x => x.GetAppSettingValueAsString(key)).Returns(value);

            // Act
            var result = settings.ApplicationVersion;

            // Assert
            result.Should().Be(value);
        }

        #endregion

        #region db connection strings

        [Test]
        public void MsSqlDbConnectionString_NoCondition_ReturnValue()
        {
            // Arrange
            const string value = "mssql";
            var key = ConfigKey.MsSqlDbConnectionString.ToString();

            settingsReader.Setup(x => x.GetConnectionString(key)).Returns(value);

            // Act
            var result = settings.MsSqlDbConnectionString;

            // Assert
            result.Should().Be(value);
        }

        [Test]
        public void MongoDbConnectionString_NoCondition_ReturnValue()
        {
            // Arrange
            const string value = "mongodb+srv";
            var key = ConfigKey.MongoDbConnectionString.ToString();

            settingsReader.Setup(x => x.GetConnectionString(key)).Returns(value);

            // Act
            var result = settings.MongoDbConnectionString;

            // Assert
            result.Should().Be(value);
        }

        #endregion
    }
}