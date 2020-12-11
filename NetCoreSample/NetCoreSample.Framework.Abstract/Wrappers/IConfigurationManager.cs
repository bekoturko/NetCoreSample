namespace NetCoreSample.Framework.Abstract
{
    /// <summary>
    /// .NET uygulamalarında Web.config, AppSettings ve ConnectionStrings ayarlarını okur.
    /// </summary>
    public interface IConfigurationManager
    {
        /// <summary>
        /// ConnectionStrings bölümündeki bağlantı bilgilerini okur.
        /// </summary>
        /// <param name="key">Bağlantı dizisi adı</param>
        /// <returns>Bağlantı dizisi elementinin connectionString değeri</returns>
        string GetConnectionString(string key);

        /// <summary>
        /// Uygulama ayarının bulunup bulunmadığı bilgisini döndürür.
        /// </summary>
        /// <param name="key">AppSettings anahtar adı</param>
        /// <returns>AppSettings anahtarının bulunup bulunmadığı bilgisi</returns>
        bool AppSettingsKeyExists(string key);

        /// <summary>
        /// Appsettings bölümündeki bağlantı bilgilerini okur.
        /// </summary>
        /// <param name="key">AppSettings anahtar adı</param>
        /// <returns>AppSettings anahtarına ait değer bilgisi</returns>
        string GetAppSettingsValue(string key);
    }
}