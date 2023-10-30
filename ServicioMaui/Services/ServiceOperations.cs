using MiddlewareMaui.Contacts;

namespace ServicioMaui.Services
{
    public class ServiceOperations : BaseService, IServiceOperations
    {
        public ServiceOperations(IServiceFactory serviceFactory, IUnitOfWork unitOfWork) : base(serviceFactory, unitOfWork)
        {
        }

        public List<object> QueryOpertaions()
        {
            throw new NotImplementedException();
        }
    }
}
