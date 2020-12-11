using System.Collections.Generic;

namespace NetCoreSample.Framework.Abstract
{
    /// <summary>
    /// Uygulama ayarlarını okur.
    /// </summary>
    public interface ISettingsReader
    {
        #region get app settings

        /// <summary>
        /// string tipinde bir ayarı okur ve döndürür.
        /// </summary>
        /// <param name="key">AppSettings anahtar adı</param>
        /// <returns>AppSettings anahtarına ait değer bilgisi</returns>
        string GetAppSettingValueAsString(string key);

        /// <summary>
        /// Int32 tipinde bir ayarı okur ve döndürür.
        /// </summary>
        /// <param name="key">AppSettings anahtar adı</param>
        /// <returns>AppSettings anahtarına ait değer bilgisi</returns>
        int GetAppSettingValueAsInt(string key);

        /// <summary>
        /// bool tipinde bir ayarı okur ve döndürür.
        /// </summary>
        /// <param name="key">AppSettings anahtar adı</param>
        /// <returns>AppSettings anahtarına ait değer bilgisi</returns>
        bool GetAppSettingValueAsBool(string key);

        /// <summary>
        /// Bir ayraç ile oluşturulmuş çoklu ayar değer listesini okur ve döndürür.
        /// </summary>
        /// <param name="key">AppSettings anahtar adı</param>
        /// <param name="separator">Çoklu değerleri ayırmak için kullanılan ayraç karakteri</param>
        /// <returns>AppSettings anahtarına ait değer listesi</returns>
        List<string> GetAppSettingValueAsSeparatedStringList(string key, char separator);

        #endregion

        #region get connection string

        /// <summary>
        /// Veritabanı bağlantı bilgisini okur ve döndürür.
        /// </summary>
        /// <param name="key">Bağlantı dizisi adı</param>
        /// <returns>Bağlantı dizisi elementinin connectionString değeri</returns>
        string GetConnectionString(string key);

        #endregion
    }
}