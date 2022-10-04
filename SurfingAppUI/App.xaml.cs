using SurfingAppUI.Views;

namespace SurfingAppUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new HomeView();
	}
}
