using MongoDB_Driver;

namespace MongoDB_Test
{
    public class Config : IMongoDBConfig
    {
        public string MongoDBConnectionString { get => "mongodb://localhost"; }
        public string DatabaseName { get => "MongoDriverTest"; }
    }
}
