namespace NetCoreSample.Framework.Abstract
{
    public interface ISettings
    {
        string MsSqlDbConnectionString { get; }

        string MongoDbConnectionString { get; }

        string ApplicationVersion { get; }
    }
}