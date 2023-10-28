using MiddlewareMaui.Contacts;
using RepositorioMaui;
using ServicioMaui;
namespace MauiBlazor.Pages;

public partial class Login : ContentPage
{
    
    IServiceFactory serviceFactory;
    IUnitOfWork unitOfWork;
    public Login()
	{
		InitializeComponent();
        this.unitOfWork = new UnitOfWork();
        this.serviceFactory = new ServiceFactory(unitOfWork);        
	}

  

   

  

   

    private async void bttnSend_Clicked(object sender, EventArgs e)
    {
        try
        {
            string username = controlUsername.Text;
            string password = controlPassword.Text;
            serviceFactory.ServiceUser.ValidateUser(username, password);

            await Navigation.PushAsync(new Pages.Home());
            await DisplayAlert("Login", "Succefully", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Ok");
        }
        
        
    }

   
}