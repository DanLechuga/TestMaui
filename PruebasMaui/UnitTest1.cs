using MiddlewareMaui.Contacts;
using RepositorioMaui;
using MiddlewareMaui.Dtos.Collectios;

namespace PruebasMaui
{
    public class UnitTest1
    {
        IUnitOfWork unitOfWork;
        public UnitTest1()
        {
            this.unitOfWork = new UnitOfWork();
            
        }
        [Fact]
        public void AddUserInCollection()
        {
            var user = new User()
            {
                Username = "Test",
                Password = "Test",
                AuditFields = new ConfigAuditFields()
                {
                    CreationDate = DateTime.Now,
                    UserCreation = "TestUser",
                    DateLastModified = DateTime.Now,
                    UserLastModified = "TestUser",
                    IsActive = true
                }
            };
            unitOfWork.RepositoryUser.Save(user); 
        }
    }
}