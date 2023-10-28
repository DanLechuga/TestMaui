using MongoDB.Driver;

namespace RepositorioMaui
{
    // All the code in this file is included in all platforms.
    public class BaseRepository
    {
        public readonly IMongoDatabase database;
        public BaseRepository(IMongoDatabase database)
        {
            this.database = database;
        }

    }
}