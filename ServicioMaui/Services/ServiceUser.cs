using MiddlewareMaui.Contacts;

namespace ServicioMaui.Services
{
    public class ServiceUser : BaseService, IServiceUser
    {
        public ServiceUser(IServiceFactory serviceFactory, IUnitOfWork unitOfWork) : base(serviceFactory, unitOfWork)
        {
        }

        public void ValidateUser(string username, string password)
        {
            var responsesp = UnitOfWork.RepositoryUser.Find(username);
            if (responsesp is null) throw new ArgumentException("Usuario no encontrado");
            if (responsesp.Password != password) throw new ArgumentException("Password incorrecto");
            
        }
    }
}
