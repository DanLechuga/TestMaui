using Comun;
using MiddlewareMaui.Dtos.Collectios;

namespace MiddlewareMaui.Contacts
{
    public interface IUnitOfWork
    {
        IRepository<User> RepositoryUser { get; }
    }
}
