namespace MauiBlazor.Pages;

public partial class ContView : ContentView
{
	public ContView()
	{
		InitializeComponent();
	}

    private void controlEdit_Completed(object sender, EventArgs e)
    {
		string txt = ((InputView)sender).Text;
    }
}