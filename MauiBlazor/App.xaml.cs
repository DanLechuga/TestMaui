using AutoMapper;
using MiddlewareMaui.Automap;
using MiddlewareMaui.Contacts;
using RepositorioMaui;
using ServicioMaui;

namespace MauiBlazor;

public partial class App : Application
{

	public App()
	{
		InitializeComponent();
		IMapper mapper = new MapperConfiguration(mc => mc.AddProfile<DtoToDto>()).CreateMapper();
		IUnitOfWork unitOfWork = new UnitOfWork();
		IServiceFactory serviceFactory = new ServiceFactory(unitOfWork,mapper);
		MainPage = new NavigationPage(new Pages.Login(serviceFactory,mapper));
		
	}
}
