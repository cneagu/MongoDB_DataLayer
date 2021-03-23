namespace MongoDB_Driver
{
    public interface IMongoDBConfig
    {
        string MongoDBConnectionString { get; }
        string DatabaseName { get; }
    }
}