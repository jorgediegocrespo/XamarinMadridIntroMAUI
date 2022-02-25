namespace XamarinMadridDemo.Features;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
	}

    private void OnCounterButtonClicked(object sender, EventArgs e)
    {

    }

    private void OnOrientationButtonClicked(object sender, EventArgs e)
    {

    }
}

