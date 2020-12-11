using NetCoreSample.Framework.Abstract;
using NetCoreSample.Model;
using System.Collections.Generic;

namespace NetCoreSample.Framework.Services
{
    public class Settings : ISettings
    {
        #region ctor & member

        readonly ISettingsReader settingsReader;

        public Settings(ISettingsReader settingsReader)
        {
            this.settingsReader = settingsReader;
        }

        #endregion

        #region private helpers

        string GetConnectionString(ConfigKey key)
        {
            return settingsReader.GetConnectionString(key.ToString());
        }

        string GetAppSettingValueAsString(ConfigKey key)
        {
            return settingsReader.GetAppSettingValueAsString(key.ToString());
        }

        int GetAppSettingValueAsInt(ConfigKey key)
        {
            return settingsReader.GetAppSettingValueAsInt(key.ToString());
        }

        List<string> GetAppSettingValuesAsStringList(ConfigKey key)
        {
            return settingsReader.GetAppSettingValueAsSeparatedStringList(key.ToString(), ',');
        }

        #endregion

        #region application version

        public string ApplicationVersion => GetAppSettingValueAsString(ConfigKey.ApplicationVersion);

        #endregion

        #region db connection strings

        public string MsSqlDbConnectionString => GetConnectionString(ConfigKey.MsSqlDbConnectionString);

        public string MongoDbConnectionString => GetConnectionString(ConfigKey.MongoDbConnectionString);

        #endregion
    }
}