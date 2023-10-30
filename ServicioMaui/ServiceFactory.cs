using AutoMapper;
using MiddlewareMaui.Contacts;
using ServicioMaui.Services;

namespace ServicioMaui
{
    public class ServiceFactory : IServiceFactory
    {
        private IServiceUser serviceUser = null;
        public readonly IUnitOfWork unitOfWork;
        public readonly IMapper mapper;
        public ServiceFactory(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper= mapper;
        }
        public IServiceUser ServiceUser => serviceUser ??= new ServiceUser(this,unitOfWork,mapper);

        public IServiceOperations ServiceOperations => throw new NotImplementedException();
    }
}
