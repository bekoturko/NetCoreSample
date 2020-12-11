using NetCoreSample.Framework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreSample.Framework.Services
{
    /// <summary>
    /// Uygulama ayarlarını okur.
    /// </summary>
    public class SettingsReader : ISettingsReader
    {
        #region ctor

        readonly IConfigurationManager configService;

        public SettingsReader(IConfigurationManager configService)
        {
            this.configService = configService;
        }

        #endregion

        #region get app settings

        public int GetAppSettingValueAsInt(string key)
        {
            return Convert.ToInt32(configService.GetAppSettingsValue(key));
        }

        public string GetAppSettingValueAsString(string key)
        {
            return configService.GetAppSettingsValue(key);
        }

        public bool GetAppSettingValueAsBool(string key)
        {
            return Convert.ToBoolean(configService.GetAppSettingsValue(key));
        }

        public List<string> GetAppSettingValueAsSeparatedStringList(string key, char separator)
        {
            var values = configService.GetAppSettingsValue(key);

            return values?
                .Split(separator)
                .Select(x => x.Trim())
                .ToList();
        }

        #endregion

        #region get connection string

        public string GetConnectionString(string key)
        {
            return configService.GetConnectionString(key);
        }

        #endregion
    }
}