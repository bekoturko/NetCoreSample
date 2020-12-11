using Microsoft.Extensions.Configuration;
using NetCoreSample.Framework.Abstract;

namespace NetCoreSample.Framework.Wrappers
{
    /// <summary>
    /// .NET Core uygulamalarında appsettings.json dosyası ayarlarını okur.
    /// </summary>
    public class ConfigurationManagerWrapper : IConfigurationManager
    {
        #region ctor

        readonly IConfiguration configuration;

        public ConfigurationManagerWrapper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        #region connection string

        public string GetConnectionString(string key)
        {
            if (!configuration.GetSection(SectionNames.ConnectionStrings).Exists())
            {
                return null;
            }

            return configuration.GetConnectionString(key);
        }

        #endregion

        #region app settings

        public bool AppSettingsKeyExists(string key)
        {
            return GetAppSettingsValue(key) != null;
        }

        public string GetAppSettingsValue(string key)
        {
            return configuration.GetSection(SectionNames.AppSettings)[key];
        }

        #endregion
    }

    public static class SectionNames
    {
        public static string AppSettings => nameof(AppSettings);

        public static string ConnectionStrings => nameof(ConnectionStrings);
    }
}