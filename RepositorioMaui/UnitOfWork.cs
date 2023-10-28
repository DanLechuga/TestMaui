using Comun;
using MiddlewareMaui.Contacts;
using MiddlewareMaui.Dtos.Collectios;
using MongoDB.Driver;
using RepositorioMaui.Repositories;

namespace RepositorioMaui
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoDatabase database;
        private IRepository<User> repositoryUser;
        public UnitOfWork()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017/");
            database = client.GetDatabase("MauiBlazor");
            
        }
        public IRepository<User> RepositoryUser => repositoryUser ??= new UserRepository(database);
    }
}
