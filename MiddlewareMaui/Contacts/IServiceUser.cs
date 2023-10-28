namespace MiddlewareMaui.Contacts
{
    public interface IServiceUser
    {
        void ValidateUser(string username, string password);
    }
}
