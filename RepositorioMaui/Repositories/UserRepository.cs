using Comun;
using MiddlewareMaui.Dtos.Collectios;
using MongoDB.Driver;

namespace RepositorioMaui.Repositories
{
    public class UserRepository : BaseRepository, IRepository<User>
    {
        IMongoCollection<User> collection;
        public UserRepository(IMongoDatabase database) : base(database)
        {
            collection = database.GetCollection<User>(nameof(User));
        }

        public void Delete(User enity)
        {
            throw new NotImplementedException();
        }

        public User Find(string id) => collection.Find(x => x.Username == id).FirstOrDefault();
       

        public void Save(User entity) => collection.InsertOne(entity);
       
    }
}
