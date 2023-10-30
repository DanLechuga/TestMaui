using AutoMapper;
using MauiBlazor.Data;
using MiddlewareMaui.Contacts;
using RepositorioMaui;
using ServicioMaui;

namespace MauiBlazor.Pages;

public partial class Home : ContentPage
{
    IServiceFactory serviceFactory;
    IMapper Mapper;
    
	public Home(IServiceFactory serviceFactory, IMapper mapper)
	{
		InitializeComponent();
        this.serviceFactory = serviceFactory;
        this.Mapper = mapper;
	}

    private void tbPg_Loaded(object sender, EventArgs e)
    {
        List<object> list = serviceFactory.ServiceOperations.QueryOpertaions();
        
    }

    private void tbVw_Loaded(object sender, EventArgs e)
    {

    }

    private void tbVw_Unloaded(object sender, EventArgs e)
    {

    }

    private void tbPg_Unloaded(object sender, EventArgs e)
    {

    }
}