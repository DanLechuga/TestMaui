using MiddlewareMaui.Contacts;

namespace ServicioMaui
{
    // All the code in this file is included in all platforms.
    public class BaseService
    {
        public readonly IServiceFactory ServiceFactory;
        public readonly IUnitOfWork UnitOfWork;
        public BaseService(IServiceFactory serviceFactory, IUnitOfWork unitOfWork)
        {
            this.ServiceFactory = serviceFactory;
            this.UnitOfWork = unitOfWork;
        }
    }
}