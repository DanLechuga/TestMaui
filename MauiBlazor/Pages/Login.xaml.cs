using AutoMapper;
using MiddlewareMaui.Contacts;
namespace MauiBlazor.Pages;

public partial class Login : ContentPage
{
    
    IServiceFactory ServiceFactory { get; }
    IMapper Mapper { get; }
    public Login(IServiceFactory serviceFactory, IMapper mapper)
	{
		InitializeComponent();
        this.ServiceFactory = serviceFactory;
        this.Mapper= mapper;
	}


    private async void bttnSend_Clicked(object sender, EventArgs e)
    {
        try
        {
            string username = controlUsername.Text;
            string password = controlPassword.Text;
            ServiceFactory.ServiceUser.ValidateUser(username, password);

            await Navigation.PushAsync(new Home(ServiceFactory,this.Mapper));
            await DisplayAlert("Login", "Succefully", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Ok");
        }
        
        
    }

   
}