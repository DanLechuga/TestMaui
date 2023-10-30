namespace MiddlewareMaui.Contacts
{
    public interface IServiceFactory
    {
        IServiceUser ServiceUser { get; }
        IServiceOperations ServiceOperations { get; }
    }
}
