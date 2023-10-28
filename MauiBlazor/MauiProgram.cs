using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiBlazor.Data;
using MiddlewareMaui.Contacts;
using RepositorioMaui;
using ServicioMaui;

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
		
		builder.Services.AddSingleton<WeatherForecastService>();
		
		builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
		builder.Services.AddTransient<IServiceFactory, ServiceFactory>();


		return builder.Build();
	}
}
