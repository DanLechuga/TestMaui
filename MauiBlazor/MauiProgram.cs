using MiddlewareMaui.Contacts;
using RepositorioMaui;
using ServicioMaui;
using AutoMapper;
using MiddlewareMaui.Automap;

namespace MauiBlazor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif


		var mapperconfig = new MapperConfiguration(mc => mc.AddProfile<DtoToDto>()).CreateMapper();
		builder.Services.AddSingleton(mapperconfig);
		builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
		builder.Services.AddTransient<IServiceFactory, ServiceFactory>();


		return builder.Build();
	}
}
