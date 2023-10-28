using MiddlewareMaui.Contacts;
using ServicioMaui.Services;

namespace ServicioMaui
{
    public class ServiceFactory : IServiceFactory
    {
        private IServiceUser serviceUser = null;
        public readonly IUnitOfWork unitOfWork;
        public ServiceFactory(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IServiceUser ServiceUser => serviceUser ??= new ServiceUser(this,unitOfWork);
    }
}
