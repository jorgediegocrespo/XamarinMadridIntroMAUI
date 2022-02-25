using XamarinMadridDemo.Features;

namespace XamarinMadridDemo;

public partial class App : Application
{
	public App(MainView mainView)
	{
		InitializeComponent();

		MainPage = new NavigationPage(mainView);
	}
}
